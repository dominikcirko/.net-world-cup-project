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

        public PlayerPictures()
        {
            InitializeComponent();
            pbPlayer1.BackColor = Color.Red;
            pbPlayer2.BackColor = Color.Green;
            pbPlayer3.BackColor = Color.Blue;
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
