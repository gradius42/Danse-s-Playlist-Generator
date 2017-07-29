using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Danse_s_Playlist_Generator
{
    public class Dossier
    {
        // Champs
        private List<Danse> danses = new List<Danse>() ;

        // Constructeur
        public Dossier()
        {

        }

        // Accesseur

        public List<Danse> Get_All_Danses()
        {
            return danses;
        }

        public List<string> Get_All_Danses_Name()
        {
            List<string> dl = new List<string>();

            foreach (Danse d in danses)
                dl.Add(d.nom);

            return dl;
        }

        public Danse Get_Danse(string nom)
        {
            foreach(Danse d in danses)
                if( d.nom == nom)
                    return d;

            return null;
        }

        public Danse Get_Danse(int i)
        {
            return danses[i];
        }

        public void Add_Danse(Danse d)
        {
            danses.Add(d);
        }

        // Methode

            // not implemented
        public void Get_TreeView()
        {

        }
    }
}