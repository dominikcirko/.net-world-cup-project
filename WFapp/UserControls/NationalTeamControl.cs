using DataLayer;
using DataLayer.Constants;
using DataLayer.DTO;
using DataLayer.Utils.Implementation;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;


namespace WFapp.UserControls
{
    public partial class NationalTeamControl : UserControl
    {
        private readonly NationalTeamUtils _ntl;
        public Starting_Eleven[] starting_eleven { get; set; }
        public Substitute[] substitute { get; set; }

        private readonly InitialForm _initialForm;
        JsonDeserializer jsonDeserializer = new(new HttpClient());

        public Panel GetPnlFavoritePlayers() { return pnlFavoritePlayers; }
        public NationalTeamControl(InitialForm initialForm, NationalTeamUtils ntl)
        {
            InitializeComponent();
            _initialForm = initialForm;
            _ntl = ntl;
            CheckChampionship();
            lbAllPlayers.Size = new System.Drawing.Size(590, 142);
            lbAllPlayers.Location = new System.Drawing.Point(27, 31);
            lbFavoritePlayers.Size = new System.Drawing.Size(590, 142);
            lbFavoritePlayers.Location = new System.Drawing.Point(27, 247);
            btnTransferMultiplePlayers.Size = new System.Drawing.Size(153, 62);
            btnTransferMultiplePlayers.Location = new System.Drawing.Point(327, 179);
            btnTransferPlayer.Size = new System.Drawing.Size(139, 62);
            btnTransferPlayer.Location = new System.Drawing.Point(154, 179);
        }
        private async Task CheckChampionship()
        {

            bool isTrueMalePlayers = File.ReadLines("info.txt")
                .Any(line => line.Contains("Championship: male") || line.Contains("Prvenstvo: muško"));

            bool isTrueFemalePlayers = File.ReadLines("info.txt")
                .Any(line => line.Contains("Championship: female") || line.Contains("Prvenstvo: žensko"));

            if (isTrueMalePlayers)
                await PopulatePlayersListBoxAsync(Constants.MATCH_INFO_MEN);
            else if (isTrueFemalePlayers)
                await PopulatePlayersListBoxAsync(Constants.MATCH_INFO_WOMEN);
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

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFavoritePlayers.Visible = false;
            _initialForm.GetPnlInitialSettings().Enabled = true;
            _initialForm.GetPnlInitialSettings().Visible = true;
            _initialForm.GetPnlInitialSettings().Dock = DockStyle.Fill;
        }
        private async Task PopulatePlayersListBoxAsync(string requestUriPlayers)
        {
            Root[] rootData = null;
            try
            {
                rootData = await jsonDeserializer.DeserializeFromAPI<Root>(requestUriPlayers);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            foreach (var rd in rootData)
            {
                Home_Team_Statistics home_Team_Statistics = rd.home_team_statistics;
                string country = _initialForm.GetCbChampionship().SelectedItem.ToString();
                string countrySplit = country.Split()[0];
                if (home_Team_Statistics.country.Contains(countrySplit))
                {
                    Starting_Eleven[] starting_Eleven = home_Team_Statistics.starting_eleven;
                    Substitute[] substitutes = home_Team_Statistics.substitutes;
                    foreach (var player in starting_Eleven)
                    {
                        lbAllPlayers.Items.Add(player.name + "|broj: " + player.shirt_number + "|pozicija: " + player.position + "|kapetan: " + player.captain);
                    }

                    foreach (var player in substitutes)
                    {
                        lbAllPlayers.Items.Add(player.name + "|broj: " + player.shirt_number + "|pozicija: " + player.position + "|kapetan: " + player.captain);
                    }
                }
            }

        }
        private void lbAllPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbAllPlayers.Items.Count == 0)
                return;

            int index = lbAllPlayers.IndexFromPoint(e.X, e.Y);
            string s = lbAllPlayers.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s,
                DragDropEffects.All);

            //if (dde1 == DragDropEffects.All)
            //{
            //    lbAllPlayers.Items.RemoveAt(lbAllPlayers.IndexFromPoint(e.X, e.Y));
            //}
        }

        private void lbFavoritePlayers_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                RestrictPlayerNumber();
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);
            }
        }

        private void btnTransferMultiplePlayers_Click(object sender, EventArgs e)
        {
            if (lbAllPlayers.SelectedIndex == -1)
            {
                MessageBoxTranslateHelper("Please select a player", "Izaberite igrača");
                return;
            }
            while (lbAllPlayers.SelectedItems.Count > 0)
            {
                
                lbFavoritePlayers.Items.Add(lbAllPlayers.SelectedItems[0]);
                lbAllPlayers.Items.Remove(lbAllPlayers.SelectedItems[0]);
            }
            RestrictPlayerNumber();

        }    

        private void btnTransferPlayer_Click(object sender, EventArgs e)
        {
            if (lbAllPlayers.SelectedIndex == -1)
            MessageBoxTranslateHelper("Please select a player", "Izaberite igrača");

            else
            {               
                lbFavoritePlayers.Items.Add(lbAllPlayers.SelectedItem);
                lbAllPlayers.Items.Remove(lbAllPlayers.SelectedItem);
            }
            RestrictPlayerNumber();
            //_ntl.FileWriter(lbFavoritePlayers);
        }
        private void RestrictPlayerNumber()
        {
            if (lbAllPlayers.SelectedItems.Count > 0)
            {
                lbFavoritePlayers.Items.Add(lbAllPlayers.SelectedItems[0]);
                lbAllPlayers.Items.Remove(lbAllPlayers.SelectedItems[0]);
            }
                if (lbFavoritePlayers.Items.Count == 3)
                {
                    _ntl.FileWriter(lbFavoritePlayers);
                    return;
                }               

            if (lbFavoritePlayers.Items.Count > 3)
            {
                while (lbFavoritePlayers.Items.Count != 3)
                {
                    lbFavoritePlayers.Items.RemoveAt(0);
                    lbAllPlayers.Items.Add(lbAllPlayers.Items[0]);
                }

                MessageBoxTranslateHelper("Can not pick more than 3 players", "Maksimalno 3 igrača");
            }

        }

        private void MessageBoxTranslateHelper(string english, string croatian) {
            string culture = CultureInfo.CurrentCulture.ToString();

            switch (culture)
            {
                case "en":
                    MessageBox.Show(english);
                    break;
                case "hr-HR":
                    MessageBox.Show(croatian);
                    break;
            }
        }

       

    }

}
