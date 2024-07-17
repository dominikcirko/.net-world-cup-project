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
using WFapp.Properties;

namespace WFapp.UserControls
{
    public partial class PlayerPictures : UserControl
    {
        public Panel GetPnlPlayerPictures() { return pnlPlayerPictures; }
        private readonly PlayerPicturesUtils _playerPicturesUtils;

        public PlayerPictures(PlayerPicturesUtils playerPicturesUtils)
        {
            InitializeComponent();
            pbPlayer1.Image = Properties.Resources.defaultImg; //set default img to players
            pbPlayer2.Image = Properties.Resources.defaultImg;
            pbPlayer3.Image = Properties.Resources.defaultImg;
            _playerPicturesUtils = playerPicturesUtils;
            _playerPicturesUtils.MapParsedNamesToLabels(lbPlayer1, lbPlayer2, lbPlayer3);


        }

        private void ImageUpload(PictureBox pb) {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
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
