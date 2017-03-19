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
    public partial class FormNouvVisite : Form
    {
        public FormNouvVisite()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string refe = tbReference.Text;
            string codeVis = cbVisiteur.Text;
            string codeMed = cbMedecin.Text;
            DateTime dateVisite = dtpDateVisite.Value.Date;


            Visite laVisite = new Visite(refe, dateVisite, codeMed, codeVis);
            PasserelleOracle.verifVisite()
        }
    }
}
