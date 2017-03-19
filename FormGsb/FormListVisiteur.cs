using Oracle.DataAccess.Client;
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
    public partial class FormListVisiteur : Form
    {
        public FormListVisiteur()
        {
            InitializeComponent();
            String req = "Select * from visiteur";
            List<Visiteur> res=PasserelleOracle.retournerListVisiteur();
            int i = 0;
            do
            {
                ListViewItem lst = new ListViewItem();
                Visiteur unVisiteur = res[i];
                lst.Text = unVisiteur.Matricule;
                lst.SubItems.Add(unVisiteur.Nom);
                lst.SubItems.Add(unVisiteur.Prenom);
                lst.SubItems.Add(unVisiteur.Adresse);
                lst.SubItems.Add(unVisiteur.UneLocalite.CodePostal);
                lvVisiteur.Items.Add(lst);

                i++;
            } while (res.Read() == true);

        }

        private void lvVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
