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
    }
}
