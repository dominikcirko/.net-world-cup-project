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
            lbRangListPlayers = new ListBox();
            btnToPdf = new Button();
            lblRangListLabel = new Label();
            pnlRangList = new Panel();
            lbRangListOther = new ListBox();
            pnlRangList.SuspendLayout();
            SuspendLayout();
            // 
            // lbRangListPlayers
            // 
            lbRangListPlayers.FormattingEnabled = true;
            lbRangListPlayers.ItemHeight = 20;
            lbRangListPlayers.Location = new Point(28, 52);
            lbRangListPlayers.Name = "lbRangListPlayers";
            lbRangListPlayers.Size = new Size(303, 344);
            lbRangListPlayers.TabIndex = 0;
            // 
            // btnToPdf
            // 
            btnToPdf.Location = new Point(28, 408);
            btnToPdf.Name = "btnToPdf";
            btnToPdf.Size = new Size(231, 88);
            btnToPdf.TabIndex = 1;
            btnToPdf.Text = "btnToPdf";
            btnToPdf.UseVisualStyleBackColor = true;
            // 
            // lblRangListLabel
            // 
            lblRangListLabel.AutoSize = true;
            lblRangListLabel.Location = new Point(28, 18);
            lblRangListLabel.Name = "lblRangListLabel";
            lblRangListLabel.Size = new Size(118, 20);
            lblRangListLabel.TabIndex = 2;
            lblRangListLabel.Text = "lblRangListLabel";
            // 
            // pnlRangList
            // 
            pnlRangList.Controls.Add(lbRangListOther);
            pnlRangList.Controls.Add(lblRangListLabel);
            pnlRangList.Controls.Add(btnToPdf);
            pnlRangList.Controls.Add(lbRangListPlayers);
            pnlRangList.Location = new Point(0, 0);
            pnlRangList.Name = "pnlRangList";
            pnlRangList.Size = new Size(661, 499);
            pnlRangList.TabIndex = 3;
            // 
            // lbRangListOther
            // 
            lbRangListOther.FormattingEnabled = true;
            lbRangListOther.ItemHeight = 20;
            lbRangListOther.Location = new Point(337, 52);
            lbRangListOther.Name = "lbRangListOther";
            lbRangListOther.Size = new Size(303, 344);
            lbRangListOther.TabIndex = 3;
            // 
            // RangListsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRangList);
            Margin = new Padding(2);
            Name = "RangListsControl";
            Size = new Size(661, 499);
            pnlRangList.ResumeLayout(false);
            pnlRangList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbRangListPlayers;
        private Button btnToPdf;
        private Label lblRangListLabel;
        private Panel pnlRangList;
        private ListBox lbRangListOther;
    }
}
