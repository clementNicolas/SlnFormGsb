namespace FormGsb
{
    partial class FormGsb
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédecinsEnRetraiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meneMnuVisite = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMnuNouvVisite = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMnuConsulterVisite = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMnuVisPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMnuCalendrier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStatistiques = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMnuPodium = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMnuListeVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medecinsToolStripMenuItem,
            this.meneMnuVisite,
            this.MnuStatistiques,
            this.MnuVisiteur});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medecinsToolStripMenuItem
            // 
            this.medecinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédecinsEnRetraiteToolStripMenuItem});
            this.medecinsToolStripMenuItem.Name = "medecinsToolStripMenuItem";
            this.medecinsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.medecinsToolStripMenuItem.Text = "Medecins";
            // 
            // listeDesMédecinsEnRetraiteToolStripMenuItem
            // 
            this.listeDesMédecinsEnRetraiteToolStripMenuItem.Name = "listeDesMédecinsEnRetraiteToolStripMenuItem";
            this.listeDesMédecinsEnRetraiteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.listeDesMédecinsEnRetraiteToolStripMenuItem.Text = "Liste des médecins en retraite";
            this.listeDesMédecinsEnRetraiteToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédecinsEnRetraiteToolStripMenuItem_Click);
            // 
            // meneMnuVisite
            // 
            this.meneMnuVisite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMnuNouvVisite,
            this.ssMnuConsulterVisite,
            this.ssMnuVisPrev,
            this.ssMnuCalendrier});
            this.meneMnuVisite.Name = "meneMnuVisite";
            this.meneMnuVisite.Size = new System.Drawing.Size(52, 20);
            this.meneMnuVisite.Text = "Visites";
            // 
            // ssMnuNouvVisite
            // 
            this.ssMnuNouvVisite.Name = "ssMnuNouvVisite";
            this.ssMnuNouvVisite.Size = new System.Drawing.Size(184, 22);
            this.ssMnuNouvVisite.Text = "Nouvelle visite";
            this.ssMnuNouvVisite.Click += new System.EventHandler(this.ssMnuNouvVisite_Click);
            // 
            // ssMnuConsulterVisite
            // 
            this.ssMnuConsulterVisite.Name = "ssMnuConsulterVisite";
            this.ssMnuConsulterVisite.Size = new System.Drawing.Size(184, 22);
            this.ssMnuConsulterVisite.Text = "Consulter visite";
            // 
            // ssMnuVisPrev
            // 
            this.ssMnuVisPrev.Name = "ssMnuVisPrev";
            this.ssMnuVisPrev.Size = new System.Drawing.Size(184, 22);
            this.ssMnuVisPrev.Text = "Visite à Prévoir";
            // 
            // ssMnuCalendrier
            // 
            this.ssMnuCalendrier.Name = "ssMnuCalendrier";
            this.ssMnuCalendrier.Size = new System.Drawing.Size(184, 22);
            this.ssMnuCalendrier.Text = "Calendrier des visites";
            // 
            // MnuStatistiques
            // 
            this.MnuStatistiques.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMnuPodium});
            this.MnuStatistiques.Name = "MnuStatistiques";
            this.MnuStatistiques.Size = new System.Drawing.Size(79, 20);
            this.MnuStatistiques.Text = "Statistiques";
            // 
            // ssMnuPodium
            // 
            this.ssMnuPodium.Name = "ssMnuPodium";
            this.ssMnuPodium.Size = new System.Drawing.Size(158, 22);
            this.ssMnuPodium.Text = "Podium Visiteur";
            // 
            // MnuVisiteur
            // 
            this.MnuVisiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMnuListeVisiteur});
            this.MnuVisiteur.Name = "MnuVisiteur";
            this.MnuVisiteur.Size = new System.Drawing.Size(63, 20);
            this.MnuVisiteur.Text = "Visiteurs";
            // 
            // ssMnuListeVisiteur
            // 
            this.ssMnuListeVisiteur.Name = "ssMnuListeVisiteur";
            this.ssMnuListeVisiteur.Size = new System.Drawing.Size(152, 22);
            this.ssMnuListeVisiteur.Text = "Liste";
            this.ssMnuListeVisiteur.Click += new System.EventHandler(this.ssMnuListeVisiteur_Click);
            // 
            // FormGsb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 348);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGsb";
            this.Text = "Application GSB";            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meneMnuVisite;
        private System.Windows.Forms.ToolStripMenuItem ssMnuNouvVisite;
        private System.Windows.Forms.ToolStripMenuItem MnuStatistiques;
        private System.Windows.Forms.ToolStripMenuItem ssMnuConsulterVisite;
        private System.Windows.Forms.ToolStripMenuItem ssMnuVisPrev;
        private System.Windows.Forms.ToolStripMenuItem ssMnuCalendrier;
        private System.Windows.Forms.ToolStripMenuItem ssMnuPodium;
        private System.Windows.Forms.ToolStripMenuItem MnuVisiteur;
        private System.Windows.Forms.ToolStripMenuItem ssMnuListeVisiteur;
        private System.Windows.Forms.ToolStripMenuItem medecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédecinsEnRetraiteToolStripMenuItem;
    }
}

