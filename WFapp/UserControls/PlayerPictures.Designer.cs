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
            ((System.ComponentModel.ISupportInitialize)pbPlayer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer2).BeginInit();
            pnlPlayerPictures.SuspendLayout();
            SuspendLayout();
            // 
            // lbHeadline
            // 
            lbHeadline.AutoSize = true;
            lbHeadline.Location = new Point(76, 36);
            lbHeadline.Name = "lbHeadline";
            lbHeadline.Size = new Size(0, 20);
            lbHeadline.TabIndex = 0;
            // 
            // lbPlayer1
            // 
            lbPlayer1.AutoSize = true;
            lbPlayer1.Location = new Point(76, 111);
            lbPlayer1.Name = "lbPlayer1";
            lbPlayer1.Size = new Size(0, 20);
            lbPlayer1.TabIndex = 1;
            // 
            // lbPlayer3
            // 
            lbPlayer3.AutoSize = true;
            lbPlayer3.Location = new Point(477, 111);
            lbPlayer3.Name = "lbPlayer3";
            lbPlayer3.Size = new Size(0, 20);
            lbPlayer3.TabIndex = 2;
            // 
            // lbPlayer2
            // 
            lbPlayer2.AutoSize = true;
            lbPlayer2.Location = new Point(286, 111);
            lbPlayer2.Name = "lbPlayer2";
            lbPlayer2.Size = new Size(0, 20);
            lbPlayer2.TabIndex = 3;
            // 
            // pbPlayer3
            // 
            pbPlayer3.Location = new Point(439, 172);
            pbPlayer3.Name = "pbPlayer3";
            pbPlayer3.Size = new Size(159, 105);
            pbPlayer3.TabIndex = 4;
            pbPlayer3.TabStop = false;
            // 
            // pbPlayer1
            // 
            pbPlayer1.Location = new Point(49, 172);
            pbPlayer1.Name = "pbPlayer1";
            pbPlayer1.Size = new Size(159, 105);
            pbPlayer1.TabIndex = 5;
            pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            pbPlayer2.Location = new Point(244, 172);
            pbPlayer2.Name = "pbPlayer2";
            pbPlayer2.Size = new Size(159, 105);
            pbPlayer2.TabIndex = 6;
            pbPlayer2.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.ImeMode = ImeMode.NoControl;
            btnNext.Location = new Point(439, 375);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(193, 55);
            btnNext.TabIndex = 17;
            btnNext.Text = "Sljedeće";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.ImeMode = ImeMode.NoControl;
            btnExit.Location = new Point(19, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 55);
            btnExit.TabIndex = 18;
            btnExit.Text = "Izlaz";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlPlayerPictures
            // 
            pnlPlayerPictures.Controls.Add(lbHeadline);
            pnlPlayerPictures.Controls.Add(btnNext);
            pnlPlayerPictures.Controls.Add(btnExit);
            pnlPlayerPictures.Controls.Add(lbPlayer3);
            pnlPlayerPictures.Controls.Add(lbPlayer2);
            pnlPlayerPictures.Controls.Add(pbPlayer3);
            pnlPlayerPictures.Controls.Add(pbPlayer2);
            pnlPlayerPictures.Controls.Add(lbPlayer1);
            pnlPlayerPictures.Controls.Add(pbPlayer1);
            pnlPlayerPictures.Location = new Point(3, 3);
            pnlPlayerPictures.Name = "pnlPlayerPictures";
            pnlPlayerPictures.Size = new Size(640, 449);
            pnlPlayerPictures.TabIndex = 19;
            // 
            // PlayerPictures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPlayerPictures);
            Name = "PlayerPictures";
            Size = new Size(646, 455);
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
    }
}
