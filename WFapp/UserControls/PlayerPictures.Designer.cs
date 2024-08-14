
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
            btnNext = new Button();
            btnExit = new Button();
            pnlPlayerPictures = new Panel();
            lbAllPlayers = new ListBox();
            btnUpload = new Button();
            pbPlayer1 = new PictureBox();
            pnlPlayerPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayer1).BeginInit();
            SuspendLayout();
            // 
            // lbHeadline
            // 
            resources.ApplyResources(lbHeadline, "lbHeadline");
            lbHeadline.Name = "lbHeadline";
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
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
            pnlPlayerPictures.Controls.Add(lbAllPlayers);
            pnlPlayerPictures.Controls.Add(btnUpload);
            pnlPlayerPictures.Controls.Add(lbHeadline);
            pnlPlayerPictures.Controls.Add(btnNext);
            pnlPlayerPictures.Controls.Add(btnExit);
            pnlPlayerPictures.Controls.Add(pbPlayer1);
            pnlPlayerPictures.Name = "pnlPlayerPictures";
            // 
            // lbAllPlayers
            // 
            resources.ApplyResources(lbAllPlayers, "lbAllPlayers");
            lbAllPlayers.FormattingEnabled = true;
            lbAllPlayers.Name = "lbAllPlayers";
            // 
            // btnUpload
            // 
            resources.ApplyResources(btnUpload, "btnUpload");
            btnUpload.Name = "btnUpload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pbPlayer1
            // 
            resources.ApplyResources(pbPlayer1, "pbPlayer1");
            pbPlayer1.BorderStyle = BorderStyle.FixedSingle;
            pbPlayer1.Name = "pbPlayer1";
            pbPlayer1.TabStop = false;
            // 
            // PlayerPictures
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPlayerPictures);
            Name = "PlayerPictures";
            pnlPlayerPictures.ResumeLayout(false);
            pnlPlayerPictures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayer1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Label lbHeadline;
        private Button btnNext;
        private Button btnExit;
        private Panel pnlPlayerPictures;
        private Button btnUpload;
        private ListBox lbAllPlayers;
        private PictureBox pbPlayer1;
    }
}
