using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGsb
{
    class Visite
    {
        private string reference;
        private DateTime date;
        private string commentaire;
        private Medecin unMedecin;
        private Visiteur unVisiteur;

        public Visite(string reference, DateTime date, string commentaire, Medecin unMedecin, Visiteur unVisiteur)
        {
            this.Reference = reference;
            this.Date = date;
            this.Commentaire = commentaire;
            this.UnMedecin = unMedecin;
            this.UnVisiteur = unVisiteur;
        }
        

        public string Reference
        {
            get
            {
                return reference;
            }

            set
            {
                reference = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        public Medecin UnMedecin
        {
            get
            {
                return unMedecin;
            }

            set
            {
                unMedecin = value;
            }
        }

        public Visiteur UnVisiteur
        {
            get
            {
                return unVisiteur;
            }

            set
            {
                unVisiteur = value;
            }
        }
    }
}
