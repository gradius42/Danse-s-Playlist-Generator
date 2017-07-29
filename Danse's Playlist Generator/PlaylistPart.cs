using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Danse_s_Playlist_Generator
{
    public class PlaylistPart
    {
        // Champs
        public readonly string danse;

        private int number;
        private TimeSpan duree;

        public int min_rythme;
        public int max_rythme;

        private Danse liste_musique;

        // Constructeur

        public PlaylistPart(string pl_name, string d,int n,int min,int max)
        {
            danse = d;
            number = n;
            min_rythme = min;
            max_rythme = max;
            liste_musique = new Danse(d);

            // find musiques + duration


        }

        // Accesseur

        public TimeSpan Get_Duree()
        {
            return duree;
        }
        
        // Methode

        


        public void Add_musique(int i)
        {

        }

        public void Remove_musique(int index)
        {

        }

        public override string ToString()
        {
            return danse + " | " + number + " | " + min_rythme + " | " + max_rythme;
        }

    }
}