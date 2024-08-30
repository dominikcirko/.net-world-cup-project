using DataLayer;
using DataLayer.Constants;
using DataLayer.DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFapp.UserControls
{
    public partial class RangListsControl : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly InitialForm _initialForm;
        public Panel GetPnlRangList() { return pnlRangList; }


        public RangListsControl(InitialForm initialForm)
        {
            InitializeComponent();
            CheckChampionship();
            lbRangListOther.HorizontalScrollbar = true;
            lbRangListPlayers.HorizontalScrollbar = true;
            _initialForm = initialForm;
            btnExit.Size = new Size(231, 51);

        }

        private async Task CheckChampionship()
        {
            string filePath = Constants.TXT_FILE_PATH;

            bool isTrueMalePlayers = File.ReadLines(filePath)
                .Any(line => line.Contains("Championship: male") || line.Contains("Prvenstvo: muško"));

            bool isTrueFemalePlayers = File.ReadLines(filePath)
                .Any(line => line.Contains("Championship: female") || line.Contains("Prvenstvo: žensko"));

            if (isTrueMalePlayers)
                await FetchAndDisplayRankingListAsync(Constants.MATCH_INFO_MEN);
            else if (isTrueFemalePlayers)
                await FetchAndDisplayRankingListAsync(Constants.MATCH_INFO_WOMEN);
        }

        public async Task FetchAndDisplayRankingListAsync(string jsonUrl)
        {
            try
            {
                string jsonData = await _httpClient.GetStringAsync(jsonUrl);

                List<MatchData> matches = JsonConvert.DeserializeObject<List<MatchData>>(jsonData);

                DisplayPlayerRankings(matches);
                DisplayMatchInfo(matches);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DisplayPlayerRankings(List<MatchData> matches)
        {
            var playerStats = new Dictionary<string, (int Goals, int YellowCards, int Appearances)>();

            string country = _initialForm.GetCbChampionship().SelectedItem.ToString();
            string countrySplit = country.Split()[0];

            foreach (var match in matches)
            {

                if (match.home_team_statistics.country.Contains(countrySplit))
                {
                    foreach (var player in match.home_team_statistics.starting_eleven)
                    {
                        if (!playerStats.ContainsKey(player.name!))
                        {
                            playerStats[player.name!] = (0, 0, 0);
                        }
                        var currentStats = playerStats[player.name!];
                        playerStats[player.name!] = (currentStats.Goals, currentStats.YellowCards, currentStats.Appearances + 1);
                    }

                    foreach (var player in match.home_team_statistics.substitutes)
                    {
                        if (!playerStats.ContainsKey(player.name!))
                        {
                            playerStats[player.name!] = (0, 0, 0);
                        }
                        var currentStats = playerStats[player.name!];
                        playerStats[player.name!] = (currentStats.Goals, currentStats.YellowCards, currentStats.Appearances + 1);
                    }
                }


                if (match.away_team_statistics.country.Contains(countrySplit))
                {
                    foreach (var player in match.away_team_statistics.starting_eleven)
                    {
                        if (!playerStats.ContainsKey(player.name!))
                        {
                            playerStats[player.name!] = (0, 0, 0);
                        }
                        var currentStats = playerStats[player.name!];
                        playerStats[player.name!] = (currentStats.Goals, currentStats.YellowCards, currentStats.Appearances + 1);
                    }
                    foreach (var player in match.away_team_statistics.substitutes)
                    {
                        if (!playerStats.ContainsKey(player.name!))
                        {
                            playerStats[player.name!] = (0, 0, 0);
                        }
                        var currentStats = playerStats[player.name!];
                        playerStats[player.name!] = (currentStats.Goals, currentStats.YellowCards, currentStats.Appearances + 1);
                    }
                }


                if (match.home_team_events != null)
                {
                    foreach (var homeEvent in match.home_team_events)
                    {
                        if (homeEvent.type_of_event == "goal")
                        {
                            if (playerStats.ContainsKey(homeEvent.player!))
                            {
                                var currentStats = playerStats[homeEvent.player!];
                                playerStats[homeEvent.player!] = (currentStats.Goals + 1, currentStats.YellowCards, currentStats.Appearances);
                            }
                        }
                        else if (homeEvent.type_of_event == "yellow_card")
                        {
                            if (playerStats.ContainsKey(homeEvent.player!))
                            {
                                var currentStats = playerStats[homeEvent.player!];
                                playerStats[homeEvent.player!] = (currentStats.Goals, currentStats.YellowCards + 1, currentStats.Appearances);
                            }
                        }
                    }
                }

                if (match.away_team_events != null)
                {
                    foreach (var awayEvent in match.away_team_events)
                    {
                        if (awayEvent.type_of_event == "goal")
                        {
                            if (playerStats.ContainsKey(awayEvent.player!))
                            {
                                var currentStats = playerStats[awayEvent.player!];
                                playerStats[awayEvent.player!] = (currentStats.Goals + 1, currentStats.YellowCards, currentStats.Appearances);
                            }
                        }
                        else if (awayEvent.type_of_event == "yellow_card")
                        {
                            if (playerStats.ContainsKey(awayEvent.player!))
                            {
                                var currentStats = playerStats[awayEvent.player!];
                                playerStats[awayEvent.player!] = (currentStats.Goals, currentStats.YellowCards + 1, currentStats.Appearances);
                            }
                        }
                    }
                }
            }

            var rankingList = playerStats
                .Select(p => new
                {
                    Player = p.Key,
                    Goals = p.Value.Goals,
                    YellowCards = p.Value.YellowCards,
                    Appearances = p.Value.Appearances
                })
                .OrderByDescending(p => p.Goals)
                .ThenByDescending(p => p.YellowCards)
                .ThenByDescending(p => p.Appearances)
                .ToList();

            foreach (var item in rankingList)
            {
                lbRangListPlayers.Items.Add($"{item.Player} - goals: {item.Goals}, yellow cards: {item.YellowCards}, appearances: {item.Appearances}");
            }
        }

        private void DisplayMatchInfo(List<MatchData> matches)
        {
            string country = _initialForm.GetCbChampionship().SelectedItem.ToString();
            string countrySplit = country.Split()[0];

            var matchVisitorList = matches
                .Where(m => m.home_team_country.Contains(countrySplit) || m.away_team_country.Contains(countrySplit))
                .Select(m => new
                {
                    Location = m.location,
                    Attendance = m.attendance,
                    HomeTeam = m.home_team_country,
                    AwayTeam = m.away_team_country
                })
                .ToList();

            foreach (var item in matchVisitorList)
            {
                lbRangListOther.Items.Add($"location: {item.Location}, attendance: {item.Attendance}, home team: {item.HomeTeam}, away team: {item.AwayTeam}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new();
            string culture = CultureInfo.CurrentCulture.ToString();
            switch (culture)
            {
                case "en":
                    dialog = MessageBox.Show("Do you want to close the application?", "Alert!", MessageBoxButtons.YesNo);
                    break;
                case "hr-HR":
                    dialog = MessageBox.Show("Želite li izaći iz aplikacije?", "Pozor!", MessageBoxButtons.YesNo);
                    break;
            }
            if (dialog == DialogResult.Yes) Environment.Exit(1);
        }
    }
}