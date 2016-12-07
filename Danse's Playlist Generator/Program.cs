using System;
using System.Collections.Generic;
using System.IO;
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

        public int nombre_Generation;

        public List<string> Type_Musique = new List<string>();

        public List<List<string>> Musique_Founded = new List<List<string>>();

        public string text = "";

        public string Speed_Unit;

        public IDictionary<string, int> Musique_duration = new Dictionary<string, int>();

            // Playlist
            
        public List<List<string>> Musique_playlist = new List<List<string>>();

        public List<string> Musique_Added = new List<string>();

        public TimeSpan Playlist_Length = new TimeSpan(0,0,0);

        public TimeSpan d_total = new TimeSpan(0, 0, 0);

    }

    public static class SQL_Command
    {
        
        // Commandes

        public static string Get_Routine()
        {
            return "SELECT Nom FROM Routine;";
        }

        public static string Get_Danse(string nom)
        {
            return "SELECT * FROM Danse WHERE Routine = '" + nom + "';";// ORDER BY Position;";
        }

        public static string Get_Parameters()
        {
            return "SELECT * FROM Paramètres;";
        }

        public static string Get_Number_Playlist()
        {
            return "SELECT Number_Playlist FROM Statistics WHERE N° = 0;";
        }

        public static string Get_Musique(string nom,string id_danse)
        {
            return "SELECT Titre_Musique FROM Musique WHERE Routine = '" + nom.Replace("'", "''") + "' AND Id_Danse = " + id_danse +" ORDER BY Position_Musique;";
        }
        
        public static string Insert_Routine(string nom, string description )
        {
            return "INSERT INTO Routine VALUES ('"+nom.Replace("'", "''").Replace("\\","").Replace("/","") + "','"+description+"');";
        }
        
        public static string Insert_Danse(string routine, int id_danse, string type,string nombre, int position,string min,string max,int tri,string Selection)
        {
            return @"INSERT INTO Danse (Routine,Id_Danse,TypeDeDanse,Nombre,VitesseMin,VitesseMax,OrdreTri,Position_Danse,Selection_Manuelle) VALUES('" +
            routine.Replace("'", "''").Replace("\\", "").Replace("/", "") + "'," + id_danse + ",'" + type + "'," + nombre + "," + min + "," + max + "," + tri + ","  + position + "," + Selection +" );";
        }
        
        public static string Insert_Musique(string routine, int id_danse, int id_musique, string titre , int position )
        {
            return @"INSERT INTO Musique (Id_Musique,Routine,Id_Danse,Titre_Musique,Position_Musique) VALUES("+
            id_musique +",'" + routine.Replace("'", "''").Replace("\\", "").Replace("/", "") + "',"+id_danse+",'"+titre.Replace("'", "''") + "',"+position+" );";
        }           
        
        public static string Insert_Number_Playlist()
        {
            return "INSERT INTO Statistics (N°,Number_Playlist) VALUES(0,0);";
        }

        public static string Update_Number_Playlist(int number)
        {
            return "UPDATE Statistics SET Number_Playlist = " + number + " WHERE N° <2;" ;
        }

        public static string Delete_Routine(string routine)
        {
            return "DELETE FROM Routine WHERE Nom = '"+ routine.Replace("'", "''") + "';";
        }

        public static string Delete_Danse(string routine)
        {
            return "DELETE FROM Danse WHERE Routine = '" + routine.Replace("'", "''") + "';";
        }

        public static string Delete_Musique(string routine)
        {
            return "DELETE FROM Musique WHERE Routine = '" + routine.Replace("'", "''") + "';";
        }
        
        public static string Count_Routine()
        {
            return "SELECT Count(*) FROM Routine;";
        }

        public static string Count_Stats()
        {
            return "SELECT Count(*) FROM Statistics;";
        }
    }

    public sealed class OBJ_Danse
    {
        private string nom;
        private int nombre;
        private int min;
        private int max;
        private int ordre;
        private List<string> musique_m;
        
        public OBJ_Danse(string nom,int nombre,int min, int max, int ordre,List<string> musique)
        {
            this.nom = nom;
            this.nombre = nombre;
            this.min = min;
            this.max = max;
            this.ordre = ordre;
            this.musique_m = musique;
        }

        public string Nom
        {
            get { return this.nom; }
            set{ this.nom = value; }
        }

        public int Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Min
        {
            get { return this.min; }
            set { this.min = value; }
        }

        public int Max
        {
            get { return this.max; }
            set { this.max = value; }
        }

        public int Ordre
        {
            get { return this.ordre; }
            set { this.ordre = value; }
        }

        public List<string> Musique_m
        {
            get { return this.musique_m; }
            set { this.musique_m = value; }
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
            }

        }
    }
       
}
