namespace FormGsb
{
    partial class FormListVisiteur
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvVisiteur = new System.Windows.Forms.ListView();
            this.chMatricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvVisiteur
            // 
            this.lvVisiteur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMatricule,
            this.chNom,
            this.chPrenom,
            this.chAdresse,
            this.chCP});
            this.lvVisiteur.GridLines = true;
            this.lvVisiteur.Location = new System.Drawing.Point(12, 12);
            this.lvVisiteur.Name = "lvVisiteur";
            this.lvVisiteur.Size = new System.Drawing.Size(547, 355);
            this.lvVisiteur.TabIndex = 0;
            this.lvVisiteur.UseCompatibleStateImageBehavior = false;
            this.lvVisiteur.View = System.Windows.Forms.View.Details;
            this.lvVisiteur.SelectedIndexChanged += new System.EventHandler(this.lvVisiteur_SelectedIndexChanged);
            // 
            // chMatricule
            // 
            this.chMatricule.Text = "Matricule";
            // 
            // chNom
            // 
            this.chNom.Text = "Nom";
            this.chNom.Width = 86;
            // 
            // chPrenom
            // 
            this.chPrenom.Text = "Prenom";
            this.chPrenom.Width = 118;
            // 
            // chAdresse
            // 
            this.chAdresse.Text = "Adresse";
            this.chAdresse.Width = 130;
            // 
            // chCP
            // 
            this.chCP.Text = "Code Postal";
            this.chCP.Width = 91;
            // 
            // FormListVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 398);
            this.Controls.Add(this.lvVisiteur);
            this.Name = "FormListVisiteur";
            this.Text = "FormListVisiteur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVisiteur;
        private System.Windows.Forms.ColumnHeader chMatricule;
        private System.Windows.Forms.ColumnHeader chNom;
        private System.Windows.Forms.ColumnHeader chPrenom;
        private System.Windows.Forms.ColumnHeader chAdresse;
        private System.Windows.Forms.ColumnHeader chCP;
    }
}