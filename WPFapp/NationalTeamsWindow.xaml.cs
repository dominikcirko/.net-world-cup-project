using DataLayer;
using DataLayer.Utils.Implementation;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Net.Http;
using System.Linq;
using DataLayer.Constants;
using Newtonsoft.Json;
using System.Windows.Media.Animation;

namespace WPFapp
{
    public partial class NationalTeamsWindow : Window
    {
        private readonly ChampionshipUtils _championshipUtils;
        private List<MatchData> _matches;
        private readonly HttpClient _httpClient = new HttpClient();


        public NationalTeamsWindow(ChampionshipUtils championshipUtils)
        {
            InitializeComponent();
            _championshipUtils = championshipUtils;
            LoadPreferredTeam();
        }

        private async void LoadPreferredTeam()
        {
            _championshipUtils.FileReader();
            string preferredNationalTeam = _championshipUtils.NationalTeam.ToString().Split(':')[1].Trim();

            if (!string.IsNullOrEmpty(preferredNationalTeam))
            {

                lblChosenNationalTeam.Content = $"{preferredNationalTeam}";
                var parsedTeamName = preferredNationalTeam.Split(':').LastOrDefault()?.Trim().Split('(')[0].Trim();

                await PopulateOpposingTeamsAsync(parsedTeamName);
            }
        }

        private async Task PopulateOpposingTeamsAsync(string selectedTeam)
        {
            string jsonData = await _httpClient.GetStringAsync(Constants.MATCH_INFO_MEN);

            List<MatchData> matches = JsonConvert.DeserializeObject<List<MatchData>>(jsonData);
            this._matches = matches;

            cbOpposingTeam.Items.Clear();

            foreach (var match in matches)
            {
                if (match.home_team_country == selectedTeam && !cbOpposingTeam.Items.Contains(match.away_team_country))
                {
                    cbOpposingTeam.Items.Add($"{match.away_team_country} ({match.away_team.code})");
                }
                else if (match.away_team_country == selectedTeam && !cbOpposingTeam.Items.Contains(match.home_team_country))
                {
                    cbOpposingTeam.Items.Add($"{match.home_team_country} ({match.home_team.code})");
                }
            }
        }

        private void btnViewTeamDetails_Click(object sender, RoutedEventArgs e)
        {
            string selectedTeam = cbOpposingTeam.SelectedItem?.ToString().Split('(')[0].Trim();

            if (string.IsNullOrEmpty(selectedTeam) || _matches == null)
            {
                MessageBox.Show("Please select a valid team.");
                return;
            }

            var match = _matches.FirstOrDefault(m =>
                m.home_team_country == selectedTeam || m.away_team_country == selectedTeam);

            if (match != null)
            {
                var teamDetailsWindow = new TeamDetailsWindow(selectedTeam, _matches);

                var fadeInAnimation = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(0.5)));
                teamDetailsWindow.BeginAnimation(Window.OpacityProperty, fadeInAnimation);

                teamDetailsWindow.Show();
            }
            else
            {
                MessageBox.Show("No match data available for the selected team.");
            }
        }

        private void cbOpposingTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayMatchResult();
        }

        private void DisplayMatchResult()
        {
            string selectedTeam = lblChosenNationalTeam.Content.ToString().Split('(')[0].Trim();
            string opposingTeam = cbOpposingTeam.SelectedItem?.ToString().Split('(')[0].Trim();

            if (string.IsNullOrEmpty(opposingTeam) || _matches == null)
            {
                return;
            }

            MatchData match = null;

            foreach (var m in _matches)
            {
                if (m.home_team_country == selectedTeam && m.away_team_country == opposingTeam)
                {
                    match = m;
                    break;
                }

                if (m.home_team_country == opposingTeam && m.away_team_country == selectedTeam)
                {
                    match = m;
                    break;
            }

            if (match != null)
            {
                lblMatchResult.Content = $"{match.home_team.goals} : {match.away_team.goals}";
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            string selectedTeam = cbOpposingTeam.SelectedItem?.ToString();

            if (selectedTeam == null || _matches == null)
            {
                MessageBox.Show("Please select a team and ensure matches are loaded.");
                return;
            }

            var teamDetailsWindow = new TeamDetailsWindow(selectedTeam, _matches);
            teamDetailsWindow.Show();
        }
    }
}