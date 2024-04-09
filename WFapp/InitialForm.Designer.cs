
namespace WFapp
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            lblGender = new Label();
            lblLanguage = new Label();
            btnCroatian = new Button();
            btnEnglish = new Button();
            btnFemale = new Button();
            btnMale = new Button();
            cbChampionship = new ComboBox();
            lblNationalTeam = new Label();
            btnExit = new Button();
            btnNext = new Button();
            lblErrMsg = new Label();
            pnlInitialSettings = new Panel();
            btnBack = new Button();
            pnlInitialSettings.SuspendLayout();
            SuspendLayout();
            // 
            // lblGender
            // 
            resources.ApplyResources(lblGender, "lblGender");
            lblGender.Name = "lblGender";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(lblLanguage, "lblLanguage");
            lblLanguage.Name = "lblLanguage";
            // 
            // btnCroatian
            // 
            resources.ApplyResources(btnCroatian, "btnCroatian");
            btnCroatian.Name = "btnCroatian";
            btnCroatian.UseVisualStyleBackColor = true;
            btnCroatian.Click += btnCroatian_Click;
            // 
            // btnEnglish
            // 
            resources.ApplyResources(btnEnglish, "btnEnglish");
            btnEnglish.Name = "btnEnglish";
            btnEnglish.UseVisualStyleBackColor = true;
            btnEnglish.Click += btnEnglish_Click;
            // 
            // btnFemale
            // 
            resources.ApplyResources(btnFemale, "btnFemale");
            btnFemale.Name = "btnFemale";
            btnFemale.UseVisualStyleBackColor = true;
            btnFemale.Click += btnFemale_Click;
            // 
            // btnMale
            // 
            resources.ApplyResources(btnMale, "btnMale");
            btnMale.Name = "btnMale";
            btnMale.UseVisualStyleBackColor = true;
            btnMale.Click += btnMale_Click;
            // 
            // cbChampionship
            // 
            cbChampionship.DropDownHeight = 100;
            cbChampionship.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChampionship.FormattingEnabled = true;
            resources.ApplyResources(cbChampionship, "cbChampionship");
            cbChampionship.Name = "cbChampionship";
            cbChampionship.SelectedIndexChanged += cbChampionship_SelectedIndexChanged;
            // 
            // lblNationalTeam
            // 
            resources.ApplyResources(lblNationalTeam, "lblNationalTeam");
            lblNationalTeam.Name = "lblNationalTeam";
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblErrMsg
            // 
            resources.ApplyResources(lblErrMsg, "lblErrMsg");
            lblErrMsg.Name = "lblErrMsg";
            // 
            // pnlInitialSettings
            // 
            pnlInitialSettings.Controls.Add(btnBack);
            pnlInitialSettings.Controls.Add(btnExit);
            pnlInitialSettings.Controls.Add(lblErrMsg);
            pnlInitialSettings.Controls.Add(btnFemale);
            pnlInitialSettings.Controls.Add(cbChampionship);
            pnlInitialSettings.Controls.Add(btnNext);
            pnlInitialSettings.Controls.Add(btnMale);
            pnlInitialSettings.Controls.Add(lblGender);
            pnlInitialSettings.Controls.Add(lblNationalTeam);
            pnlInitialSettings.Controls.Add(lblLanguage);
            pnlInitialSettings.Controls.Add(btnCroatian);
            pnlInitialSettings.Controls.Add(btnEnglish);
            resources.ApplyResources(pnlInitialSettings, "pnlInitialSettings");
            pnlInitialSettings.Name = "pnlInitialSettings";
            pnlInitialSettings.Paint += pnlInitialSettings_Paint;
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // InitialForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInitialSettings);
            Name = "InitialForm";
            Load += InitialForm_Load;
            pnlInitialSettings.ResumeLayout(false);
            pnlInitialSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblGender;
        private Label lblLanguage;
        private Button btnCroatian;
        private Button btnEnglish;
        private Button btnFemale;
        private Button btnMale;
        private ComboBox cbChampionship;
        private Label lblNationalTeam;
        private Button btnExit;
        private Button btnNext;
        private Label lblErrMsg;
        private Panel pnlInitialSettings;
        private Button btnBack;
    }
}
