using DataLayer.DTO;
using DataLayer;
using DataLayer.Utils.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFapp.Properties;
using DataLayer.Constants;
using System.Globalization;

namespace WFapp.UserControls
{
    public partial class PlayerPictures : UserControl
    {
        public Panel GetPnlPlayerPictures() { return pnlPlayerPictures; }
        private readonly PlayerPicturesUtils _playerPicturesUtils;
        public Starting_Eleven[] starting_eleven { get; set; }
        public Substitute[] substitute { get; set; }

        private readonly InitialForm _initialForm;
        private JsonDeserializer jsonDeserializer = new JsonDeserializer(new HttpClient());

        private Dictionary<string, Image> playerImages = new Dictionary<string, Image>();

        private Image defaultPlayerImage;

        public PlayerPictures(PlayerPicturesUtils playerPicturesUtils, InitialForm initialForm)
        {
            InitializeComponent();
            _initialForm = initialForm;
            CheckChampionship();
            lbAllPlayers.Size = new System.Drawing.Size(277, 344);
            lbAllPlayers.Location = new System.Drawing.Point(351, 11);
            btnUpload.Location = new System.Drawing.Point(52, 234);
            btnUpload.Size = new System.Drawing.Size(160, 36);
            pbPlayer1.Location = new System.Drawing.Point(52, 108);
            pbPlayer1.Size = new System.Drawing.Size(160, 105);
            _playerPicturesUtils = playerPicturesUtils;

            string defaultImagePath = Path.Combine(@"..\..\..\..\DataLayer\images\", "player3.png");

            if (File.Exists(defaultImagePath))
            {
                defaultPlayerImage = Image.FromFile(defaultImagePath);
            }
            else
            {
                MessageBox.Show("Default image file not found. Please check the path.");
                defaultPlayerImage = new Bitmap(160, 105); 
            }

            pbPlayer1.Image = defaultPlayerImage;
            pbPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayer1.Visible = true;

            lbAllPlayers.SelectedIndexChanged += LbAllPlayers_SelectedIndexChanged;
            btnUpload.Click += btnUpload_Click;

            pbPlayer1.Visible = false;
            btnUpload.Visible = false;
        }

        private string GetPlayerImagePath(string playerName)
        {
            string relativePath = @"..\..\..\..\DataLayer\images";
            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            return Path.Combine(imagesFolder, playerName + "Img.png");
        }

        private void LbAllPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllPlayers.SelectedItem != null)
            {
                string selectedPlayer = lbAllPlayers.SelectedItem.ToString();
                string imagePath = GetPlayerImagePath(selectedPlayer);

                if (File.Exists(imagePath))
                {
                    if (!playerImages.ContainsKey(selectedPlayer))
                    {
                        playerImages[selectedPlayer] = Image.FromFile(imagePath);
                    }

                    pbPlayer1.Image = playerImages[selectedPlayer];
                }
                else
                {
                    pbPlayer1.Image = defaultPlayerImage;
                }

                pbPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPlayer1.Visible = true;
                btnUpload.Visible = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lbAllPlayers.SelectedItem != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Select a picture",
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPlayer = lbAllPlayers.SelectedItem.ToString();
                    string imagePath = GetPlayerImagePath(selectedPlayer);

                    try
                    {
                        using (Image playerImage = Image.FromFile(openFileDialog.FileName))
                        {
                            playerImage.Save(imagePath);

                            if (playerImages.ContainsKey(selectedPlayer))
                            {
                                playerImages[selectedPlayer].Dispose();
                                playerImages[selectedPlayer] = new Bitmap(imagePath);
                            }
                            else
                            {
                                playerImages[selectedPlayer] = new Bitmap(imagePath);
                            }

                            pbPlayer1.Image = playerImages[selectedPlayer];
                            pbPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbPlayer1.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error uploading image: {ex.Message}");
                    }
                }
            }
        }

        private async Task PopulatePlayersListBoxAsync(string requestUriPlayers)
        {
            Root[] rootData = null;
            try
            {
                rootData = await jsonDeserializer.DeserializeFromAPI<Root>(requestUriPlayers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                        lbAllPlayers.Items.Add(player.name);
                    }

                    foreach (var player in substitutes)
                    {
                        lbAllPlayers.Items.Add(player.name);
                    }
                }
            }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            RangListsControl rangListsControl = new RangListsControl(_initialForm);

            if (Parent != null)
            {
                Parent.Controls.Add(rangListsControl);
                rangListsControl.Dock = DockStyle.Fill;
                this.pnlPlayerPictures.Visible = false;
                rangListsControl.BringToFront();
                rangListsControl.GetPnlRangList().Visible = true;
            }
        }
    }
}