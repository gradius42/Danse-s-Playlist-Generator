using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danse_s_Playlist_Generator
{
    public sealed class Globals
    {
        public static Globals g = new Globals();

        public Globals() { }

        // Globals variables

            // Fichiers
        public string repertoire;

        public char sep;

        public char sep_final;

        public List<string> Type_Musique = new List<string>();

        public List<List<string>> Musique_Founded = new List<List<string>>();

        public string text = "";

        public string Speed_Unit;

            // Playlist
            
        public List<List<string>> Musique_playlist = new List<List<string>>();

        public List<string> Musique_Added = new List<string>();

    }

    public sealed class SQL_Command
    {
        public SQL_Command() { }

        public static SQL_Command g = new SQL_Command();

        // Commandes

        public string Get_Routine()
        {
            return "SELECT Nom FROM Routine;";
        }

        public string Get_Danse(string nom)
        {
            return "SELECT * FROM Danse WHERE Routine = '" + nom + "' ORDER BY Position;";
        }

        public string Get_Parameters()
        {
            return "SELECT * FROM Paramètres;";
        }

        public string Get_Number_Playlist()
        {
            return "SELECT Number_Playlist FROM Statistics WHERE N° = 0;";
        }

        public string Get_Musique(string nom,string id_danse)
        {
            return "SELECT Titre_Musique FROM Musique WHERE Routine = '" + nom + "' AND Id_Danse = " + id_danse +" ORDER BY Position_Musique;";
        }
        
        public string Insert_Routine(string nom, string description )
        {
            return "INSERT INTO Routine VALUES ('"+nom+"','"+description+"');";
        }
        
        public string Insert_Danse(string routine, int id_danse, string type,string nombre, int position,string min,string max,int tri,string Selection)
        {
            return @"INSERT INTO Danse (Routine,Id_Danse,TypeDeDanse,Nombre,VitesseMin,VitesseMax,OrdreTri,Position_Danse,Selection_Manuelle) VALUES('" +
            routine + "'," + id_danse + ",'" + type + "'," + nombre + "," + min + "," + max + "," + tri + ","  + position + "," + Selection +" );";
        }
        
        public string Insert_Musique(string routine, int id_danse, int id_musique, string titre , int position )
        {
            return @"INSERT INTO Musique (Id_Musique,Routine,Id_Danse,Titre_Musique,Position_Musique) VALUES("+
            id_musique +",'" + routine +"',"+id_danse+",'"+titre+"',"+position+" );";
        }           
        
        public string Insert_Number_Playlist()
        {
            return "INSERT INTO Statistics (N°,Number_Playlist) VALUES(0,0);";
        }

        public string Update_Number_Playlist(int number)
        {
            return "UPDATE Statistics Number_Playlist = " + number + " Where N° <2;" ;
        }

        public string Delete_Routine(string routine)
        {
            return "DELETE FROM Routine WHERE Nom = '"+ routine+"';";
        }

        public string Delete_Danse(string routine)
        {
            return "DELETE FROM Danse WHERE Routine = '" + routine + "';";
        }

        public string Delete_Musique(string routine)
        {
            return "DELETE FROM Musique WHERE Routine = '" + routine + "';";
        }
        
        public string Get_Max_Danse(string routine)
        {
            return "SELECT Max(Id_Danse) FROM Danse WHERE Routine = '" + routine + "';";
        }

        public string Get_Max_Musique(string routine, int id_danse)
        {
            return "SELECT Max(Id_Musique) FROM Musique WHERE Routine = '" + routine + "' AND Id_Danse = " + id_danse + ";";
        }

        public string Count_Routine()
        {
            return "SELECT Count(*) FROM Routine;";
        }

        public string Count_Stats()
        {
            return "SELECT Count(*) FROM Statistics;";
        }
    }


    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            string dir = Directory.GetCurrentDirectory();

            char sep;

            if (dir.Contains("/"))
            {
                sep = '/'; //Unix
            }
            else
            {
                sep = '\\'; // Windows
            }

            if (!File.Exists("." + sep + "Application.config"))
            {
                Application.Run(new Initialisation(sep));
            }

            if (File.Exists("." + sep + "Application.config"))
            {
                Application.Run(new Application_Fen());
                //Application.Run(new Menu());
            }

        }
    }
       
}
