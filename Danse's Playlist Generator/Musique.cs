using System;
using NAudio.Wave;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Danse_s_Playlist_Generator
{
    public class Musique
    {
        // Champ
        public readonly string file;
        public readonly string nom;
        public readonly int rythme;
        private TimeSpan duree = new TimeSpan(0,0,-1);

        // Constructeur

        public Musique(string f)
        {
            file = f;

            // get Name + Rythme

            string unit = Application_Fen.g.Speed_Unit;

            string m = file.Split(Path.DirectorySeparatorChar).Last();
            m.Replace(m.Split('.').Last(),"");

            if (m.Contains(unit))
            {
                if (m.IndexOfAny(unit.ToArray()) == 3)
                {
                    rythme = Int32.Parse(m.Substring(0, 2));
                    nom = m.Substring(9);
                }
                else if (m.IndexOfAny(unit.ToArray()) == 4)
                {
                    rythme = Int32.Parse(m.Substring(0, 3));
                    nom = m.Substring(10);
                }
                else
                {
                    rythme = 0;
                    nom = m;
                }
            }
            else
            {
                rythme = 0;
                nom = m;
            }
            
        }

        public Musique(string f, string n, int r, TimeSpan d)
        {
            nom = n;
            rythme = r;
            duree = d;
        }

        public Musique(string n, int r)
        {
            nom = n;
            rythme = r;
        }

        // Accesseur

        public TimeSpan Get_Duration()
        {
            return duree;
        }

        public void Init_Duration()
        {
            if (duree.Seconds == -1)
            {
                try
                {
                    Mp3FileReader reader = new Mp3FileReader(file);
                    duree = reader.TotalTime;
                }
                catch(System.InvalidOperationException err)
                {
                    Console.WriteLine(err);

                    duree = new TimeSpan(0, 0, 0);
                }
            }
        }

        // Methode 
                       
    }
}