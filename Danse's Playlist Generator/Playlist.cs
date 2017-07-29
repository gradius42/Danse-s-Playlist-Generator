using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Danse_s_Playlist_Generator
{
    public class Playlist
    {
        // champs
        private string nom;
        private List<PlaylistPart> liste = new List<PlaylistPart>();
        private TimeSpan duree = new TimeSpan(0,0,0);

        private bool saved = false;

        // Constructeur

        public Playlist(string n)
        {
            nom = n;
        }

        // Accesseurs
        
        public bool Is_Saved()
        {
            return saved;
        }

        public string Get_Name()
        {
            return nom;
        }

        public void Set_Nom(string n)
        {
            nom = n;
        }

        public TimeSpan Get_Duree()
        {
            return duree;
        }

        public List<PlaylistPart> Get_All_PlaylistPart()
        {
            return liste;
        }
        
        public PlaylistPart Get_PlaylistPart(int i)
        {
            return liste[i];
        }

        // Methode

        public void Add_PlaylistPart( PlaylistPart p)
        {
            liste.Add(p);
            duree.Add(p.Get_Duree());

            saved = false;
        }
        
        public void Remove_PlaylistPart(int index)
        {
            duree.Subtract(liste[index].Get_Duree());
            liste.RemoveAt(index);

            saved = false;
        }

        public void Swap_Parts(int i,int j)
        {
            PlaylistPart buf = liste[i];
            liste[i] = liste[j];
            liste[j] = buf;

            saved = false;
        }

        public void Shuffle<T>(IList<T> list)
        {
            int count = list.Count;
            Random random = new Random();
            while (count > 1)
            {
                --count;
                int index = random.Next(count + 1);
                T obj = list[index];
                list[index] = list[count];
                list[count] = obj;
            }
        }

    }
}