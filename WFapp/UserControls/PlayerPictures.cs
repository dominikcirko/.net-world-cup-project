using DataLayer.Utils.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFapp.UserControls
{
    public partial class PlayerPictures : UserControl
    {
        public Panel GetPnlPlayerPictures() { return pnlPlayerPictures; }
        private readonly PlayerPicturesUtils _playerPicturesUtils;
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        static string player1 = Path.Combine(projectDirectory, "DataLayer", "images", "defaultImgPlayer.jpg");
        static string player2 = Path.Combine(projectDirectory, "DataLayer", "images", "defaultImgPlayer.jpg");
        static string player3 = Path.Combine(projectDirectory, "DataLayer", "images", "defaultImgPlayer.jpg");

        public PlayerPictures(PlayerPicturesUtils playerPicturesUtils)
        {
            InitializeComponent();
            pbPlayer1.Image = Image.FromFile(player1);
            pbPlayer2.Image = Image.FromFile(player2);
            pbPlayer3.Image = Image.FromFile(player3);
            _playerPicturesUtils = playerPicturesUtils;
            _playerPicturesUtils.MapParsedNamesToLabels(lbPlayer1, lbPlayer2, lbPlayer3);


        }

        private void ImageUpload(PictureBox pb) {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            ImageUpload(pbPlayer1);
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        {
            ImageUpload(pbPlayer2);

        }

        private void btnUpload3_Click(object sender, EventArgs e)
        {
            ImageUpload(pbPlayer3);

        }


    }
}
