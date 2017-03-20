using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGsb
{
    public partial class FormGsb : Form
    {
        public FormGsb()
        {
            InitializeComponent();
        }

        private void ssMnuNouvVisite_Click(object sender, EventArgs e)
        {
            FormNouvVisite newMDIChild = new FormNouvVisite();
            //Set the parent form of the child window
            newMDIChild.MdiParent = this;
            //display the new form
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void ssMnuListeVisiteur_Click(object sender, EventArgs e)
        {
            FormListVisiteur newMDIChild = new FormListVisiteur();
            newMDIChild.MdiParent = this;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void listeDesMédecinsEnRetraiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListMedecin newMDIChild = new FormListMedecin();
            newMDIChild.MdiParent = this;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }
     
    }
}
