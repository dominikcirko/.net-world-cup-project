namespace WFapp.UserControls
{
    partial class PlayerPictures
    {
         /*
         Svakom igraču iz odabrane reprezentacije moguće je postaviti sliku. Slike je potrebno pohraniti unutar samog rješenja
         (isto kao i datoteke) kako bi se mogle koristiti u oba klijentska projekta. Slika treba biti dio korisničke kontrole igrača.
         Ako neki igrač nema postavljenu sliku, treba prikazati neku zadanu sliku igrača.
         */

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPictures));
            lbHeadline = new Label();
            lbPlayer1 = new Label();
            lbPlayer3 = new Label();
            lbPlayer2 = new Label();
            pbPlayer3 = new PictureBox();
            pbPlayer1 = new PictureBox();
            pbPlayer2 = new PictureBox();
            btnNext = new Button();
            btnExit = new Button();
            pnlPlayerPictures = new Panel();
            btnUpload3 = new Button();
            btnUpload2 = new Button();
            btnUpload1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPlayer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer2).BeginInit();
            pnlPlayerPictures.SuspendLayout();
            SuspendLayout();
            // 
            // lbHeadline
            // 
            resources.ApplyResources(lbHeadline, "lbHeadline");
            lbHeadline.Name = "lbHeadline";
            // 
            // lbPlayer1
            // 
            resources.ApplyResources(lbPlayer1, "lbPlayer1");
            lbPlayer1.Name = "lbPlayer1";
            // 
            // lbPlayer3
            // 
            resources.ApplyResources(lbPlayer3, "lbPlayer3");
            lbPlayer3.Name = "lbPlayer3";
            // 
            // lbPlayer2
            // 
            resources.ApplyResources(lbPlayer2, "lbPlayer2");
            lbPlayer2.Name = "lbPlayer2";
            // 
            // pbPlayer3
            // 
            resources.ApplyResources(pbPlayer3, "pbPlayer3");
            pbPlayer3.BorderStyle = BorderStyle.FixedSingle;
            pbPlayer3.Name = "pbPlayer3";
            pbPlayer3.TabStop = false;
            // 
            // pbPlayer1
            // 
            resources.ApplyResources(pbPlayer1, "pbPlayer1");
            pbPlayer1.BorderStyle = BorderStyle.FixedSingle;
            pbPlayer1.Name = "pbPlayer1";
            pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            resources.ApplyResources(pbPlayer2, "pbPlayer2");
            pbPlayer2.BorderStyle = BorderStyle.FixedSingle;
            pbPlayer2.Name = "pbPlayer2";
            pbPlayer2.TabStop = false;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlPlayerPictures
            // 
            resources.ApplyResources(pnlPlayerPictures, "pnlPlayerPictures");
            pnlPlayerPictures.Controls.Add(btnUpload3);
            pnlPlayerPictures.Controls.Add(btnUpload2);
            pnlPlayerPictures.Controls.Add(btnUpload1);
            pnlPlayerPictures.Controls.Add(lbHeadline);
            pnlPlayerPictures.Controls.Add(btnNext);
            pnlPlayerPictures.Controls.Add(btnExit);
            pnlPlayerPictures.Controls.Add(lbPlayer3);
            pnlPlayerPictures.Controls.Add(lbPlayer2);
            pnlPlayerPictures.Controls.Add(pbPlayer3);
            pnlPlayerPictures.Controls.Add(pbPlayer2);
            pnlPlayerPictures.Controls.Add(lbPlayer1);
            pnlPlayerPictures.Controls.Add(pbPlayer1);
            pnlPlayerPictures.Name = "pnlPlayerPictures";
            // 
            // btnUpload3
            // 
            resources.ApplyResources(btnUpload3, "btnUpload3");
            btnUpload3.Name = "btnUpload3";
            btnUpload3.UseVisualStyleBackColor = true;
            btnUpload3.Click += btnUpload3_Click;
            // 
            // btnUpload2
            // 
            resources.ApplyResources(btnUpload2, "btnUpload2");
            btnUpload2.Name = "btnUpload2";
            btnUpload2.UseVisualStyleBackColor = true;
            btnUpload2.Click += btnUpload2_Click;
            // 
            // btnUpload1
            // 
            resources.ApplyResources(btnUpload1, "btnUpload1");
            btnUpload1.Name = "btnUpload1";
            btnUpload1.UseVisualStyleBackColor = true;
            btnUpload1.Click += btnUpload1_Click;
            // 
            // PlayerPictures
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPlayerPictures);
            Name = "PlayerPictures";
            ((System.ComponentModel.ISupportInitialize)pbPlayer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer2).EndInit();
            pnlPlayerPictures.ResumeLayout(false);
            pnlPlayerPictures.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbHeadline;
        private Label lbPlayer1;
        private Label lbPlayer3;
        private Label lbPlayer2;
        private PictureBox pbPlayer3;
        private PictureBox pbPlayer1;
        private PictureBox pbPlayer2;
        private Button btnNext;
        private Button btnExit;
        private Panel pnlPlayerPictures;
        private Button btnUpload3;
        private Button btnUpload2;
        private Button btnUpload1;
    }
}
