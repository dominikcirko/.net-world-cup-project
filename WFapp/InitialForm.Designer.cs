
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
            labelErrMsg = new Label();
            cbChampionship = new ComboBox();
            lblNationalTeam = new Label();
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
            // labelErrMsg
            // 
            resources.ApplyResources(labelErrMsg, "labelErrMsg");
            labelErrMsg.Name = "labelErrMsg";
            // 
            // cbChampionship
            // 
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
            // InitialForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNationalTeam);
            Controls.Add(cbChampionship);
            Controls.Add(labelErrMsg);
            Controls.Add(btnMale);
            Controls.Add(btnFemale);
            Controls.Add(btnEnglish);
            Controls.Add(btnCroatian);
            Controls.Add(lblLanguage);
            Controls.Add(lblGender);
            Name = "InitialForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblGender;
        private Label lblLanguage;
        private Button btnCroatian;
        private Button btnEnglish;
        private Button btnFemale;
        private Button btnMale;
        private Label labelErrMsg;
        private ComboBox cbChampionship;
        private Label lblNationalTeam;
    }
}
