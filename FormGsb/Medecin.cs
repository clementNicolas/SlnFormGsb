using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGsb
{
    class Medecin
    {
        protected string codeMed;
        protected string nom;
        protected string prenom;
        protected string adresse;
        protected Localite cp;
        protected string telephone;
        protected string potentiel;
        protected string specialite;


        public Medecin(string codeMed, string nom,string prenom,string adresse,Localite cp,string telephone,string potentiel,string specialite)
        {
            this.codeMed = codeMed;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cp = cp;
            this.telephone = telephone;
            this.specialite = specialite;
        }


        public string CodeMed
        {
            get
            {
                return codeMed;
            }

            set
            {
                codeMed = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        internal Localite Cp
        {
            get
            {
                return cp;
            }

            set
            {
                cp = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Potentiel
        {
            get
            {
                return potentiel;
            }

            set
            {
                potentiel = value;
            }
        }

        public string Specialite
        {
            get
            {
                return specialite;
            }

            set
            {
                specialite = value;
            }
        }
    }
}
