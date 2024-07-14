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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}
