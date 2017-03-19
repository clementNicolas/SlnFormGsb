namespace FormGsb
{
    partial class FormNouvVisite
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.Visiteur = new System.Windows.Forms.Label();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateVisite = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            // 
            // tbReference
            // 
            this.tbReference.Location = new System.Drawing.Point(153, 21);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(146, 20);
            this.tbReference.TabIndex = 1;
            // 
            // Visiteur
            // 
            this.Visiteur.AutoSize = true;
            this.Visiteur.Location = new System.Drawing.Point(28, 63);
            this.Visiteur.Name = "Visiteur";
            this.Visiteur.Size = new System.Drawing.Size(41, 13);
            this.Visiteur.TabIndex = 2;
            this.Visiteur.Text = "Visiteur";
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(153, 60);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(146, 21);
            this.cbVisiteur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Médecin";
            // 
            // cbMedecin
            // 
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(153, 94);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(146, 21);
            this.cbMedecin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Visite";
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Location = new System.Drawing.Point(153, 133);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(146, 20);
            this.dtpDateVisite.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnValider.Location = new System.Drawing.Point(29, 203);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(269, 37);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider la visite";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormNouvVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 273);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dtpDateVisite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVisiteur);
            this.Controls.Add(this.Visiteur);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.label1);
            this.Name = "FormNouvVisite";
            this.Text = "Nouvelle Visite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.Label Visiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbVisiteur;
    }
}