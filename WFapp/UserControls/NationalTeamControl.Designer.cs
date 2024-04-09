namespace WFapp.UserControls
{
    partial class NationalTeamControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NationalTeamControl));
            btnBack = new Button();
            btnExit = new Button();
            btnNext = new Button();
            pnlFavoritePlayers = new Panel();
            btnTransferPlayer = new Button();
            btnTransferMultiplePlayers = new Button();
            lbFavoritePlayers = new ListBox();
            lbAllPlayers = new ListBox();
            pnlFavoritePlayers.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pnlFavoritePlayers
            // 
            resources.ApplyResources(pnlFavoritePlayers, "pnlFavoritePlayers");
            pnlFavoritePlayers.Controls.Add(btnTransferPlayer);
            pnlFavoritePlayers.Controls.Add(btnTransferMultiplePlayers);
            pnlFavoritePlayers.Controls.Add(lbFavoritePlayers);
            pnlFavoritePlayers.Controls.Add(lbAllPlayers);
            pnlFavoritePlayers.Controls.Add(btnNext);
            pnlFavoritePlayers.Controls.Add(btnExit);
            pnlFavoritePlayers.Controls.Add(btnBack);
            pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            // 
            // btnTransferPlayer
            // 
            resources.ApplyResources(btnTransferPlayer, "btnTransferPlayer");
            btnTransferPlayer.Name = "btnTransferPlayer";
            btnTransferPlayer.UseVisualStyleBackColor = true;
            btnTransferPlayer.Click += btnTransferPlayer_Click;
            // 
            // btnTransferMultiplePlayers
            // 
            resources.ApplyResources(btnTransferMultiplePlayers, "btnTransferMultiplePlayers");
            btnTransferMultiplePlayers.Name = "btnTransferMultiplePlayers";
            btnTransferMultiplePlayers.UseVisualStyleBackColor = true;
            btnTransferMultiplePlayers.Click += btnTransferMultiplePlayers_Click;
            // 
            // lbFavoritePlayers
            // 
            resources.ApplyResources(lbFavoritePlayers, "lbFavoritePlayers");
            lbFavoritePlayers.AllowDrop = true;
            lbFavoritePlayers.FormattingEnabled = true;
            lbFavoritePlayers.Name = "lbFavoritePlayers";
            lbFavoritePlayers.DragDrop += lbFavoritePlayers_DragDrop;
            lbFavoritePlayers.DragOver += lbFavoritePlayers_DragOver;
            // 
            // lbAllPlayers
            // 
            resources.ApplyResources(lbAllPlayers, "lbAllPlayers");
            lbAllPlayers.AllowDrop = true;
            lbAllPlayers.FormattingEnabled = true;
            lbAllPlayers.Name = "lbAllPlayers";
            lbAllPlayers.SelectionMode = SelectionMode.MultiExtended;
            lbAllPlayers.MouseDown += lbAllPlayers_MouseDown;
            // 
            // NationalTeamControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlFavoritePlayers);
            Name = "NationalTeamControl";
            pnlFavoritePlayers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnExit;
        private Button btnNext;
        private Panel pnlFavoritePlayers;
        private ListBox lbFavoritePlayers;
        private ListBox lbAllPlayers;
        private Button btnTransferMultiplePlayers;
        private Button btnTransferPlayer;
    }
}
