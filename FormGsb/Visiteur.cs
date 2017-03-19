using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGsb
{
    class Visiteur
    {
        private string matricule;
        private string nom;
        private string prenom;
        private string login;
        private string mdp;
        private string adresse;
        private Localite uneLocalite;
        private string telephone;
        private DateTime dateEntree;
        private string codeUnite;
        private string nomUnite;

        public Visiteur(string matricule, string nom, string prenom,
            string login, string mdp, string adresse, Localite uneLocalite, DateTime dateEntree, string codeUnite, string nomUnite)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.Mdp = mdp;
            this.Adresse = adresse;
            this.UneLocalite = uneLocalite;
            this.CodeUnite = codeUnite;
            this.NomUnite = nomUnite;
        }


        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
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

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                mdp = value;
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

        internal Localite UneLocalite
        {
            get
            {
                return uneLocalite;
            }

            set
            {
                uneLocalite = value;
            }
        }
       
        public DateTime DateEntree
        {
            get
            {
                return dateEntree;
            }

            set
            {
                dateEntree = value;
            }
        }

        public string CodeUnite
        {
            get
            {
                return codeUnite;
            }

            set
            {
                codeUnite = value;
            }
        }

        public string NomUnite
        {
            get
            {
                return nomUnite;
            }

            set
            {
                nomUnite = value;
            }
        }
    }
}
