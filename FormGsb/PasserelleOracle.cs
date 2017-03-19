using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGsb
{
    class PasserelleOracle
    {
        public static OracleConnection conn;

        public static void connexionBase()
        {
            // chaine de connexion
            string connection = "Data Source=192.168.60.53:1521;User Id=gsb;Password=password";
            conn = new OracleConnection(connection);
            try
            {
                conn.Open();
                Console.WriteLine("connexion Oracle");
            }
            catch (Exception)
            {
                Console.WriteLine("erreur connexion bd");
            }
        }

        public static OracleDataReader selectionner(string requete)
        {
            connexionBase();
            OracleDataReader dr = null;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = requete;
            try
            {

                dr = cmd.ExecuteReader();
            }
            catch
            {
                Console.WriteLine("erreur exécution requête : " + requete);
            }
            return dr;
        }

        public static Localite retournerLocalite(string unCode)
        {
            Localite uneLocalite = null;
            OracleDataReader dr = selectionner("Select * from localite");    // where CODEPOSTAL ='" + unCode + "'");
            try
            {
                if (dr.Read())
                {
                    uneLocalite = new Localite(dr.GetString(0), dr.GetString(1));
                }
            }
            catch
            {
                Console.WriteLine("Erreur requête : " + "Select * from LOCALITE where CODEPOSTAL ='" + unCode + "'");
            }
            dr.Close();
            conn.Dispose();
            return uneLocalite;
        }
        
        public static Visiteur retournerVisiteur(String unMat)
        {
            Visiteur vis = null;
            OracleDataReader dr = selectionner("Select * from Visiteur where MATRICULE='" + unMat + "';");
            if (dr.HasRows)
            {
                String mat = dr.GetString(0);
                String nom = dr.GetString(1);
                String prenom = dr.GetString(2);
                String login = dr.GetString(3);
                String mdp = dr.GetString(4);
                String adresse = dr.GetString(5);
                String cp = dr.GetString(6);
                Localite uneloc = retournerLocalite(cp);
                DateTime dateE = dr.GetDateTime(7);
                String codeU = dr.GetString(8);
                String nomUnit = dr.GetString(9);
                vis = new Visiteur(mat, nom, prenom, login, mdp, adresse, uneloc, dateE, codeU,nomUnit);
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            return vis;
        }

        public static Medecin retournerMedecin(String unCode)
        {
            Medecin med = null;
            OracleDataReader dr = selectionner("Select * from MEDECIN where CODEMED='" + unCode + "';");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string cod = dr.GetString(0);
                    string nom = dr.GetString(1);
                    string pre = dr.GetString(2);
                    string adr = dr.GetString(3);
                    string cp = dr.GetString(4);
                    Localite uneLoc = retournerLocalite(cp);
                    string tel = dr.GetString(5);
                    string pot = dr.GetString(6);
                    string spe = dr.GetString(7);
                    med = new Medecin(cod, nom, pre, adr, uneLoc, tel, pot, spe);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            return med;
        }


        public static List<Medecin> retournerListMedecin()
        {
            List<Medecin> lesMedecins = new List<Medecin>();
            OracleDataReader dr = selectionner("Select * from MEDECIN");
            if (dr.HasRows)
            {
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                  // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                  // string telephone, string potentiel, string specialite)
                    string cod = dr.GetString(0);
                    string nom = dr.GetString(1);
                    string pre = dr.GetString(2);
                    string adr = dr.GetString(3);
                    string cp = dr.GetString(4);
                    Localite uneLoc = retournerLocalite(cp);
                    string tel = dr.GetString(5);
                    string pot = dr.GetString(6);
                    string spe = dr.GetString(7);
                    lesMedecins.Add(new Medecin(cod, nom, pre, adr, uneLoc, tel, pot, spe));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            return lesMedecins;
        }

        public static List<Visiteur> retournerListVisiteur()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            OracleDataReader dr = selectionner("Select * from visiteur");
            if (dr.HasRows)
            {
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                  // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                  // string telephone, string potentiel, string specialite)
                    String mat = dr.GetString(0);
                    String nom = dr.GetString(1);
                    String prenom = dr.GetString(2);
                    String login = dr.GetString(3);
                    String mdp = dr.GetString(4);
                    String adresse = dr.GetString(5);
                    String cp = dr.GetString(6);
                    Localite uneloc = retournerLocalite(cp);
                    DateTime dateE = dr.GetDateTime(7);
                    String codeU = dr.GetString(8);
                    String nomUnit = dr.GetString(9);
                    Visiteur vis = new Visiteur(mat, nom, prenom,login,mdp,adresse,uneloc,dateE,codeU,nomUnit);
                    lesVisiteurs.Add(vis);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            conn.Dispose();
            return lesVisiteurs;
        }

        public static List<Visite> retournerListVisite()
        {
            List<Visite> lstVis = new List<Visite>();
            OracleDataReader dr = selectionner("Select * from visite");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String reference= dr.GetString(0);
                    DateTime date = dr.GetDateTime(1);
                    String com = dr.GetString(2);
                    Visiteur vis=retournerVisiteur(dr.GetString(3));
                    Medecin med = retournerMedecin(dr.GetString(4));
                    Visite uneVisite = new Visite(reference, date, com, med, vis);
                    lstVis.Add(uneVisite);
                }

            }
            dr.Close();
            conn.Dispose();
            return lstVis;
        }


        public static int verifVisite(Visite uneVisite)
        {//retourne 1 si aucune visite de ce type existe, s'il y en a une, retourne 1 
            int resultat = 1;
            OracleDataReader dr = selectionner("SELECT * FROM VISITE where reference='" + uneVisite.Reference + "',date=" + uneVisite.Date);
            if (dr.HasRows)
            {
                resultat = 0;
            }
            dr.Close();
            conn.Dispose();
            return resultat;
        }

        public static void creerVisite(Visite uneVisite)
        { 
            string oradb = "Data Source= 192.168.60.53:1521;User Id=GSB;Password=password;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //      OracleDataReader dr = selectionner("INSERT INTO VISITE VALUES ('" + uneVisite.Reference + "'," + uneVisite.Date + ",'" + uneVisite.Commentaire + "','" + uneVisite.UnMedecin.CodeMed + "','" + uneVisite.UnVisiteur.Matricule + "');");
            // Perform insert using parameters (bind variables)
            cmd.CommandText = "Insert into USER.EMPLOYEE VALUES (:1, :2, :3, :4, :5)";

            // Here's one way to use parameters aka bind variables:
            // Create parameters to hold values from front-end
            cmd.Parameters.Add(new OracleParameter("1",
                                                   OracleDbType.Varchar2,
                                                   uneVisite.Reference,
                                                   ParameterDirection.Input));

            cmd.Parameters.Add(new OracleParameter("2",
                                                   OracleDbType.Date,
                                                   uneVisite.Date,
                                                   ParameterDirection.Input));

            cmd.Parameters.Add(new OracleParameter("3",
                                                    OracleDbType.Varchar2,
                                                    uneVisite.Commentaire,
                                                    ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
                                                    OracleDbType.Varchar2,
                                                    uneVisite.UnMedecin.CodeMed,
                                                    ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
                                                    OracleDbType.Varchar2,
                                                    uneVisite.UnVisiteur.Matricule,
                                                    ParameterDirection.Input));
            

            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Record not inserted");
            else
                MessageBox.Show("Success!");
            conn.Dispose();
        }
    }
}
