using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGsb
{
    class Localite
    {
        protected string codePostal;
        protected string ville;

        public Localite(string codePostal, string ville)
        {
            this.CodePostal = codePostal;
            this.Ville = ville;
        }

        public string CodePostal
        {
            get { return CodePostal; }
            set { CodePostal = value; }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }
    }
}
