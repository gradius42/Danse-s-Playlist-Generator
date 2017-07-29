using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Danse_s_Playlist_Generator
{
    public class Danse
    {
        // Champs  
        public readonly string nom;

        private List<Musique> liste = new List<Musique>();

        // Constructeur
        public Danse(string n)
        {
            nom = n;
        }

        public Danse()
        {
            nom = "";
        }

        //Accesseur

        public List<Musique> Get_All_Musique()
        {
            return liste;
        }

        public List<string> Get_All_Musique_Name()
        {
            List<string> ml = new List<string>();

            foreach(Musique m in liste)
                ml.Add(m.nom);

            return ml;
        }

        public Musique Get_Musique(string nom)
        {
            foreach (Musique m in liste)
                if (m.nom == nom)
                    return m;

            return null;
        }

        public Musique Get_Musique(int i)
        {
            return liste[i];
        }

        public void Add_Musique(Musique m)
        {
            liste.Add(m);
        }

        // Methode

        
    }
}