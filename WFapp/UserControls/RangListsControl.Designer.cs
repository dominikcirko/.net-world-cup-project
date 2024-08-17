namespace WFapp.UserControls
{
    partial class RangListsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangListsControl));
            lbRangListPlayers = new ListBox();
            btnExit = new Button();
            pnlRangList = new Panel();
            lbRangListOther = new ListBox();
            pnlRangList.SuspendLayout();
            SuspendLayout();
            // 
            // lbRangListPlayers
            // 
            resources.ApplyResources(lbRangListPlayers, "lbRangListPlayers");
            lbRangListPlayers.FormattingEnabled = true;
            lbRangListPlayers.Name = "lbRangListPlayers";
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlRangList
            // 
            resources.ApplyResources(pnlRangList, "pnlRangList");
            pnlRangList.Controls.Add(lbRangListOther);
            pnlRangList.Controls.Add(btnExit);
            pnlRangList.Controls.Add(lbRangListPlayers);
            pnlRangList.Name = "pnlRangList";
            // 
            // lbRangListOther
            // 
            resources.ApplyResources(lbRangListOther, "lbRangListOther");
            lbRangListOther.FormattingEnabled = true;
            lbRangListOther.Name = "lbRangListOther";
            // 
            // RangListsControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRangList);
            Name = "RangListsControl";
            pnlRangList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbRangListPlayers;
        private Button btnExit;
        private Panel pnlRangList;
        private ListBox lbRangListOther;
    }
}
