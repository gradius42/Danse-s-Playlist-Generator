using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace Danse_s_Playlist_Generator
{
    public partial class Menu : Form
    {
        public Globals g = new Globals();

        int gListView1LostFocusItem = -1;

        private string file_param;

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        public static bool IsNumeric(object Expression)
        {
            int retNum;

            bool isNum = Int32.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public class MusiqueComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {


                int X = Find_BPM((string)x);
                int Y = Find_BPM((string)y);

                if (X < Y) 
                    return -1;
                if (X > Y)
                    return 1;
                return 0;
            }
        }
       
        public Menu()
        {
            InitializeComponent();
            String strAppDir = Directory.GetCurrentDirectory();

            file_param = strAppDir + "\\param.config";
            if (!File.Exists(file_param))
            {
                var v = File.Create(file_param);

                v.Close();
            }
            else
            {
                string text = File.ReadAllText(file_param);

                text = text.Replace("\n","");

                load_files(text);

            }

            


        }

        // fonctions

        public void Generate_music_list(int Min, int Max, string danse_file, int number)
        {/*
            // vérifie l'ordre

            int min = Min;
            int max = Max;

            if (min > max)
            {
                min = Max;
                max = Min;
            }

            Random rand = new Random();

            // musique dans la porté 
            List<string> Musique_in_Range = new List<string>();


            int danse_index = g.Type_Musique.FindIndex(x => x.Equals(danse_file));

            // Pour toute les musiques de danse
            foreach (string m in g.Musique_Founded[danse_index])
            {
                string music = m.Split(g.sep).Last();

                //=========A=MODIFIER===========//
                try
                {
                    int BPM = Find_BPM(music);
                    
                    if (g.Musique_Added.Contains(music) == false && ( (min <= BPM && max >= BPM) || BPM == -1 ))
                    {
                        Musique_in_Range.Add(music);
                    }

                }
                catch { };
                //=============================//
            }


            if (Musique_in_Range.Count > 0)
            { 
                // ajoute la nouvelle danse
                string[] arr = new string[4]; ListViewItem itm;
                arr[0] = "";
                arr[1] = danse_file;
                arr[2] = min.ToString();
                arr[3] = max.ToString();
                itm = new ListViewItem(arr);
                listW_Danse_List.Items.Add(itm);

                // Musique sélectionnée
                List<string> selection = new List<string>();

                int i = 0;
                while ( i < number && Musique_in_Range.Count > 0)
                {
                    // tir une musique
                    int r = rand.Next(0, Musique_in_Range.Count - 1);
                    
                    // ajoute la musique a la sélection
                    selection.Add(Musique_in_Range[r]);

                    // ajoute aux musiques sélectionné
                    g.Musique_Added.Add(Musique_in_Range[r]);
                    
                    // Supprime la musique des possibilités    
                    Musique_in_Range.RemoveAt(r);
                    
                    i++;
                }

                if(Musique_in_Range.Count == 0 && i < number)
                {
                    MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist./n Seulement " + i + " musique(s) ont été ajoutée(s).");
                }

                // ajoute la sélection
                g.Musique_playlist.Add(selection);

            }
            else
            {
                // n'ajoute pas la danse
                MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist.");
            }
            */
        }
        
        public void Add_Music_to_Selection(int Min, int Max)
        {/*
            if (listW_Danse_List.SelectedItems.Count > 0)
            {
                int min = Min;
                int max = Max;

                if (min > max)
                {
                    min = Max;
                    max = Min;
                }

                // La position de la danse sélectionnée
                int index_danse_selected = listW_Danse_List.SelectedIndices[0];

                // La danse sélectionnée
                string danse_file = listW_Danse_List.SelectedItems[0].SubItems[1].Text;

                // Position de la danse
                int danse_index = g.Type_Musique.FindIndex(x => x.Equals(danse_file));

                // aléatoire
                Random rand = new Random();

                // Musiques dans la porté
                List<string> Musique_in_Range = new List<string>();

                foreach (string m in g.Musique_Founded[danse_index])
                {
                    string music = m.Split(g.sep).Last();

                    try
                    {
                        int BPM = Find_BPM(music);

                        if (g.Musique_Added.Contains(music) == false && ((min <= BPM && max >= BPM) || BPM == -1))
                        {
                            Musique_in_Range.Add(music);
                        }
                    }
                    catch { }

                }
                
                if (Musique_in_Range.Count > 0)
                {
                    // Musique sélectionnée
                    List<string> selection = g.Musique_playlist[index_danse_selected];

                    int i = 0;
                    if (Musique_in_Range.Count > 0)
                    {
                        // tir une musique
                        int r = rand.Next(0, Musique_in_Range.Count - 1);

                        // ajoute la musique a la sélection
                        selection.Add(Musique_in_Range[r]);

                        // ajoute aux musiques sélectionné
                        g.Musique_Added.Add(Musique_in_Range[r]);

                        // Supprime la musique des possibilités    
                        Musique_in_Range.RemoveAt(r);

                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist./n Seulement " + i + " musique(s) ont été ajoutée(s).");
                    }

                    g.Musique_playlist[index_danse_selected] = selection;
                }
                

            }
            else
            {
                // n'ajoute pas la danse
                MessageBox.Show("Tout les musiques de ce style et dans cette porté sont déjà dans la playlist.");
            }

            Maj_Liste_Musique();         
            */
        }

        public void Modify_Music_Selected(int Min, int Max)
        {/*

            int min = Min;
            int max = Max;

            if (min > max)
            {
                min = Max;
                max = Min;
            }

            // var
            string danse_file = listW_Danse_List.SelectedItems[0].SubItems[1].Text;
            Random rand = new Random();
            List<string> Musique_in_Range = new List<string>();

            //index 
            int index_danse_selected = listW_Danse_List.SelectedIndices[0];
            int danse_index = g.Type_Musique.FindIndex(x => x.Equals(danse_file));

            List<int> selected_indices = new List<int>();

            // find indices
            for (int i = 0; i < list_Musiques.SelectedItems.Count; i++)
            {
                selected_indices.Add(list_Musiques.SelectedIndices[i]);

                g.Musique_Added.Remove(list_Musiques.Items[list_Musiques.SelectedIndices[i]].ToString());
                
            }

            // find musique in range
            foreach (string m in g.Musique_Founded[danse_index])
            {
                string music = m.Split(g.sep).Last();

                try
                {
                    int BPM = Find_BPM(music);

                    if (g.Musique_Added.Contains(music) == false && ((min <= BPM && max >= BPM) || BPM == -1))
                    {
                        Musique_in_Range.Add(music);
                    }
                }
                catch { }

            }

            // change musique
            List<string> selection = g.Musique_playlist[index_danse_selected];
            if (Musique_in_Range.Count > 0)
            {
                for (int i = 0; i < selected_indices.Count && Musique_in_Range.Count > 0; i++)
                {
                    // tir une musique
                    int r = rand.Next(0, Musique_in_Range.Count - 1);

                    // ajoute la musique a la sélection
                    selection[selected_indices[i]] = Musique_in_Range[r];

                    // ajoute aux musiques sélectionné
                    g.Musique_Added.Add(Musique_in_Range[r]);

                    // Supprime la musique des possibilités    
                    Musique_in_Range.RemoveAt(r);
                    
                }
            }
            g.Musique_playlist[index_danse_selected] = selection;

            //Maj affichage
            Maj_Liste_Musique();

            // reselectionne les indices 
            foreach(int i in selected_indices)
            {
                list_Musiques.SetSelected(i, true);
            }
            */
        }

        public void Modify_All_Music(int Min, int Max)
        {
            /*
            int min = Min;
            int max = Max;

            if (min > max)
            {
                min = Max;
                max = Min;
            }

            // var
            string danse_file = listW_Danse_List.SelectedItems[0].SubItems[1].Text;
            Random rand = new Random();
            List<string> Musique_in_Range = new List<string>();
            
            //index 
            int index_danse_selected = listW_Danse_List.SelectedIndices[0];
            int danse_index = g.Type_Musique.FindIndex(x => x.Equals(danse_file));
            
            // change musique
            List<string> selection = g.Musique_playlist[index_danse_selected];
            
            // Supprime les musiques des sélectionnées

            foreach (string s in selection)
            {
                g.Musique_Added.Remove(s);
            }
            
            // find musique in range
            foreach (string m in g.Musique_Founded[danse_index])
            {
                string music = m.Split(g.sep).Last();

                try
                {
                    int BPM = Find_BPM(music);

                    if (g.Musique_Added.Contains(music) == false && ((min <= BPM && max >= BPM) || BPM == -1))
                    {
                        Musique_in_Range.Add(music);
                    }
                }
                catch { }

            }
            
            if (Musique_in_Range.Count > 0)
            {
                for (int i = 0; i < selection.Count; i++)
                {
                    // tir une musique
                    int r = rand.Next(0, Musique_in_Range.Count - 1);

                    // ajoute la musique a la sélection
                    selection[i] = Musique_in_Range[r];
                    
                    // ajoute aux musiques sélectionné
                    g.Musique_Added.Add(Musique_in_Range[r]);

                    // Supprime la musique des possibilités    
                    Musique_in_Range.RemoveAt(r);
                    
                }
                
            }
            
            Maj_Liste_Musique();

            g.Musique_playlist[index_danse_selected] = selection;*/
        }
        
        public void Change_Min_Max(int Min, int Max)
        {
            ListViewItem item = listW_Danse_List.SelectedItems[0];
            item.SubItems[2].Text = Min.ToString();
            item.SubItems[3].Text = Max.ToString();

            listW_Danse_List.Items[listW_Danse_List.SelectedIndices[0]] = item;
        }

        public void Maj_Liste_Musique()
        {/*
            list_Musiques.Items.Clear();

            if (listW_Danse_List.SelectedIndices.Count > 0)
            {
                foreach (string m in g.Musique_playlist[listW_Danse_List.SelectedIndices[0]])
                {
                    list_Musiques.Items.Add(m);
                }
            }*/
        }

        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;

            Random rng = new Random();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static int Find_BPM(string music)
        {
            string[] BPM_finder = music.Split(' ');

            string Valeur = BPM_finder[0];
            string Unité = BPM_finder[1].ToUpper();

            int i = 1;
            while (Unité != "BPM" || i == BPM_finder.Length - 1)
            {
                Valeur = BPM_finder[i];

                i++;

                Unité = BPM_finder[i].ToUpper();
            }

            if (Unité == "BPM" && IsNumeric(Valeur) == true)
                return Int32.Parse(Valeur);
            else
                return -1;
        }

        public void Ajout_Manuel(int position, string style, List<string> Musique)
        {/*
            if(position == -1)
            {
                string[] arr = new string[4]; ListViewItem itm;
                arr[0] = "";
                arr[1] = style;
                arr[2] = "ND";
                arr[3] = "ND";
                itm = new ListViewItem(arr);
                listW_Danse_List.Items.Add(itm);

                g.Musique_playlist.Add(Musique);

                foreach(string m in Musique)
                {
                    g.Musique_Added.Add(m);
                }
            }
            else
            {
                int counter = 0;
                for(int i = 0; i <  listW_Danse_List.Items.Count;i++)
                {
                    if(listW_Danse_List.Items[i].SubItems[1].Text == style)
                    {
                        counter++;
                        if (counter == position)
                        {
                            List<string> selection = g.Musique_playlist[i];
                            foreach (string m in Musique)
                            {
                                selection.Add(m);
                            }

                            g.Musique_playlist[i] = selection;

                            i = listW_Danse_List.Items.Count;
                        }
                    }
                    
                }
            }*/
        }

        public void load_files(string path_files)
        {/*
            string path = path_files;

            g.repertoire = path;

            // reset
            g.Musique_playlist.Clear();

            txt_Rep_Recherche.Text = path;
            txt_Rep_Generation.Text = path;

            // Sous-repertoire
            string[] dirs = Directory.GetDirectories(path, "*");

            // Find separateur
            try
            {
                if (dirs[1].Contains("/"))
                {
                    g.sep = '/'; //linux
                    rad_slash.Checked = true;
                }
                else
                {
                    g.sep = '\\'; // windows
                    rad_backslash.Checked = true;
                }


                int numb = 0;

                //sélectionne les musiques 
                foreach (string d in dirs)
                {
                    // enregistre les type des danses

                    string danse_file = d.Split(g.sep).Last();

                    g.Type_Musique.Add(danse_file);

                    cmb_Danses.Items.Add(new Item(danse_file, numb));

                    numb++;
                    // liste les musiques 

                    string danse_path = g.repertoire + g.sep + danse_file + g.sep;

                    List<String> Musique = Directory.GetFiles(danse_path).ToList();

                    List<String> Musiques_Founded = new List<string>();

                    foreach (string m in Musique)
                    {
                        Musiques_Founded.Add(m.Split(g.sep).Last());
                    }

                    // enregistrement des musiques

                    g.Musique_Founded.Add(Musiques_Founded);



                }

                grp_playlist.Visible = true;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                btn_reset.Visible = true;
                btn_save.Visible = true;

            }
            catch
            {
                MessageBox.Show("Mauvais répertoire");
            }*/
        }

        // events

        private void btn_folder_select_Click(object sender, EventArgs e)
        {/*
            //Lecture du repertoire de musique
            FolderBrowserDialog Folder = new FolderBrowserDialog();
            DialogResult result1 = Folder.ShowDialog();

            cmb_Danses.Items.Clear();
            g.Type_Musique.Clear();
            g.Musique_Founded.Clear();

            if (result1 == DialogResult.OK)
            {

                load_files(Folder.SelectedPath);
                File.WriteAllText(file_param, Folder.SelectedPath);
            }*/
        }

        private void btn_ajouter_danse_Click(object sender, EventArgs e)
        {
            if (g.repertoire != "" && cmb_Danses.SelectedIndex != -1)
            {
                Generate_music_list((int)Nup_Min.Value, (int)Nup_Max.Value, cmb_Danses.Text, (int)Nup_Nb.Value);

                cmb_Danses.SelectedIndex = -1;
            }
        }

        private void listW_Danse_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maj_Liste_Musique();

            foreach (ListViewItem i in listW_Danse_List.Items)
            {
                if (i.Selected)
                {
                    i.BackColor = Color.Blue;
                }
                else
                {
                    i.BackColor = Color.White;
                }
            }
        }

        private void btn_add_to_danse_Click(object sender, EventArgs e)
        {
            if (listW_Danse_List.SelectedItems.Count > 0 && listW_Danse_List.SelectedItems[0].SubItems[2].Text != "ND")
            {
                Add_Music_to_Selection(Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[2].Text), Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[3].Text));
            }
        }

        private void btn_reload_select_Click(object sender, EventArgs e)
        {
            if (listW_Danse_List.SelectedItems.Count > 0 && list_Musiques.SelectedIndices.Count > 0)
            {
                Modify_Music_Selected(Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[2].Text), Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[3].Text));
            }
        }

        private void btn_reload_all_Click(object sender, EventArgs e)
        {
            if (listW_Danse_List.SelectedItems.Count > 0)
            {
                Modify_All_Music(Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[2].Text), Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[3].Text));
            }
        }

        private void btn_delete_danse_Click(object sender, EventArgs e)
        {/*

            int index_danse_selected = listW_Danse_List.SelectedIndices[0];
            if (index_danse_selected != -1)
            {
                listW_Danse_List.Items.RemoveAt(index_danse_selected);

                List<string> selection = g.Musique_playlist[index_danse_selected];

                foreach( string s in selection)
                {
                    g.Musique_Added.Remove(s);
                }

                g.Musique_playlist.RemoveAt(index_danse_selected);
                
                Maj_Liste_Musique();
            }*/
        }

        private void btn_delete_selection_Click(object sender, EventArgs e)
        {/*
            int index_danse_selected = listW_Danse_List.SelectedIndices[0];

            List<int> selected_indices = new List<int>();

            // find indices
            for (int i = 0; i < list_Musiques.SelectedItems.Count; i++)
            {
                selected_indices.Add(list_Musiques.SelectedIndices[i]);
            }

            if (selected_indices.Count > 0)
            {
                List<string> selection = g.Musique_playlist[index_danse_selected];

                for (int i = selected_indices.Count - 1; i >= 0; i--)
                {
                    g.Musique_Added.Remove(selection[i]);

                    selection.RemoveAt(selected_indices[i]);
                }

                if (selection.Count > 0)
                {
                    g.Musique_playlist[index_danse_selected] = selection;
                }
                else
                {
                    g.Musique_playlist.RemoveAt(index_danse_selected);
                    listW_Danse_List.Items[index_danse_selected].Remove();
                }

                Maj_Liste_Musique();
            }*/
        }

        private void btn_music_up_Click(object sender, EventArgs e)
        {/*
            if (listW_Danse_List.SelectedIndices[0] > 0)
            {
                int index = listW_Danse_List.SelectedIndices[0];
                int index_ = index - 1;

                // change les musique

                List<string> music1 = g.Musique_playlist[index];
                g.Musique_playlist[index] = g.Musique_playlist[index - 1];
                g.Musique_playlist[index - 1] = music1;

                //Buffers 
                string[] ligne = { listW_Danse_List.Items[index].SubItems[1].Text, listW_Danse_List.Items[index].SubItems[2].Text, listW_Danse_List.Items[index].SubItems[3].Text };
                string[] ligne_ = { listW_Danse_List.Items[index_].SubItems[1].Text, listW_Danse_List.Items[index_].SubItems[2].Text, listW_Danse_List.Items[index_].SubItems[3].Text };
                
                ListViewItem item = listW_Danse_List.Items[index];
                item.SubItems[0].Text = "";
                item.SubItems[1].Text = ligne_[0];
                item.SubItems[2].Text = ligne_[1];
                item.SubItems[3].Text = ligne_[2];

                listW_Danse_List.Items[index] = item;
                listW_Danse_List.Items[index].Selected = false ;

                ListViewItem item_ = listW_Danse_List.Items[index_];
                item_.SubItems[0].Text = "";
                item_.SubItems[1].Text = ligne[0];
                item_.SubItems[2].Text = ligne[1];
                item_.SubItems[3].Text = ligne[2];

                listW_Danse_List.Items[index_] = item_;
                listW_Danse_List.Items[index_].Selected = true;
                
                listW_Danse_List.Focus();
            }*/
        }

        private void btn_music_down_Click(object sender, EventArgs e)
        {/*
            if ((listW_Danse_List.SelectedItems.Count > 0) && (listW_Danse_List.SelectedIndices[0] < listW_Danse_List.Items.Count - 1))
            {
                int index = listW_Danse_List.SelectedIndices[0];
                int index_ = index + 1;

                List<string> music1 = g.Musique_playlist[index];
                g.Musique_playlist[index] = g.Musique_playlist[index + 1];
                g.Musique_playlist[index + 1] = music1;

                //Buffers 
                string[] ligne = { listW_Danse_List.Items[index].SubItems[1].Text, listW_Danse_List.Items[index].SubItems[2].Text, listW_Danse_List.Items[index].SubItems[3].Text };
                string[] ligne_ = { listW_Danse_List.Items[index_].SubItems[1].Text, listW_Danse_List.Items[index_].SubItems[2].Text, listW_Danse_List.Items[index_].SubItems[3].Text };

                ListViewItem item = listW_Danse_List.Items[index];
                item.SubItems[0].Text = "";
                item.SubItems[1].Text = ligne_[0];
                item.SubItems[2].Text = ligne_[1];
                item.SubItems[3].Text = ligne_[2];

                listW_Danse_List.Items[index] = item;
                listW_Danse_List.Items[index].Selected = false;

                ListViewItem item_ = listW_Danse_List.Items[index_];
                item_.SubItems[0].Text = "";
                item_.SubItems[1].Text = ligne[0];
                item_.SubItems[2].Text = ligne[1];
                item_.SubItems[3].Text = ligne[2];

                listW_Danse_List.Items[index_] = item_;
                listW_Danse_List.Items[index_].Selected = true;

                listW_Danse_List.Focus();
            }*/
        }

        private void btn_selection_up_Click(object sender, EventArgs e)
        {/*
            if (list_Musiques.SelectedIndex > 0)
            {

                List<string> music1 = g.Musique_playlist[listW_Danse_List.SelectedIndices[0]];

                string m1 = music1[list_Musiques.SelectedIndex];
                music1[list_Musiques.SelectedIndex] = music1[list_Musiques.SelectedIndex - 1];
                music1[list_Musiques.SelectedIndex - 1] = m1;

                g.Musique_playlist[listW_Danse_List.SelectedIndices[0]] = music1;

                int index = list_Musiques.SelectedIndex;

                Maj_Liste_Musique();

                list_Musiques.SelectedIndex = index - 1;
            }*/
        }

        private void btn_selection_down_Click(object sender, EventArgs e)
        {/*
            if (list_Musiques.SelectedIndex != -1 && (list_Musiques.SelectedIndex < list_Musiques.Items.Count - 1))
            {
                List<string> music1 = g.Musique_playlist[listW_Danse_List.SelectedIndices[0]];

                string m1 = music1[list_Musiques.SelectedIndex];
                music1[list_Musiques.SelectedIndex] = music1[list_Musiques.SelectedIndex + 1];
                music1[list_Musiques.SelectedIndex + 1] = m1;

                g.Musique_playlist[listW_Danse_List.SelectedIndices[0]] = music1;

                int index = list_Musiques.SelectedIndex;

                Maj_Liste_Musique();

                list_Musiques.SelectedIndex = index + 1;
            }*/
        }

        private void btn_musique_asc_Click(object sender, EventArgs e)
        {/*
            IComparer<string> comparer = new MusiqueComparer();

            g.Musique_playlist[listW_Danse_List.SelectedIndices[0]].Sort(comparer);
            g.Musique_playlist[listW_Danse_List.SelectedIndices[0]].Reverse();
            Maj_Liste_Musique();*/
        }

        private void btn_music_desc_Click(object sender, EventArgs e)
        {/*
            IComparer<string> comparer = new MusiqueComparer();

            g.Musique_playlist[listW_Danse_List.SelectedIndices[0]].Sort(comparer);
            Maj_Liste_Musique();*/
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {/*
            if (listW_Danse_List.SelectedItems.Count > 0)
            {
                List<String> l = g.Musique_playlist[listW_Danse_List.SelectedIndices[0]];
                Shuffle(l);
                Shuffle(l);
                Shuffle(l);
                g.Musique_playlist[listW_Danse_List.SelectedIndices[0]] = l;
                Maj_Liste_Musique();
            }
            */
        }

        private void btn_save_Click(object sender, EventArgs e)
        {/*
            if(listW_Danse_List.Items.Count > 0)
            {
                // génère le texte de la playlist
                g.text = "#EXTM3U\n";
                char sep_final;
                if (rad_slash.Checked == true)
                    sep_final = '/';
                else
                    sep_final = '\\';

                for (int i = 0; i < listW_Danse_List.Items.Count; i++)
                {
                    foreach (string music in g.Musique_playlist[i])
                    {
                        g.text += txt_Rep_Generation.Text.Replace(g.sep,sep_final) + sep_final + listW_Danse_List.Items[i].SubItems[1].Text + sep_final + music + "\n";
                    }
                }


                DialogResult dialogResult = MessageBox.Show("Voulez-vous avoir un apperçu du fichier avant d'enregister?", "Finalisation", MessageBoxButtons.YesNoCancel);
                if(dialogResult == DialogResult.Yes)
                {
                    Apperçu fen = new Apperçu(g.text,true);
                    fen.ShowDialog();

                    if(fen.DialogResult == DialogResult.OK)
                    {
                        //repertoire de sauvegarde
                        SaveFileDialog save = new SaveFileDialog();
                        DialogResult result1 = save.ShowDialog();

                        if (result1 == DialogResult.OK)
                        {
                            // chemin
                            string file = save.FileName + ".m3u";
                            
                            File.WriteAllText(file, g.text);

                            MessageBox.Show("Sauvegarde Réussie !");

                        }
                    }
                }
                else if(dialogResult == DialogResult.No)
                {
                    //repertoire de sauvegarde
                    SaveFileDialog save = new SaveFileDialog();
                    DialogResult result1 = save.ShowDialog();

                    if (result1 == DialogResult.OK)
                    {
                        // chemin
                        string file = save.FileName + ".m3u";
                        
                        File.WriteAllText(file, g.text);

                        MessageBox.Show("Sauvegarde Réussie !");
                    }
                }
                
            }
            */
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {/*
            DialogResult dialogResult = MessageBox.Show("Etes-vous sure de vouloir supprimer la playlist ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listW_Danse_List.Items.Clear();
                list_Musiques.Items.Clear();
                g.Musique_playlist.Clear();
                g.Musique_Added.Clear();
            }*/
        }

        private void Nup_Min_ValueChanged(object sender, EventArgs e)
        {
            if (Nup_Min.Value > Nup_Max.Value)
            {
                int buffer = (int)Nup_Min.Value;
                Nup_Min.Value = Nup_Max.Value;
                Nup_Max.Value = buffer;
            }
        }

        private void Nup_Max_ValueChanged(object sender, EventArgs e)
        {
            if (Nup_Min.Value > Nup_Max.Value)
            {
                int buffer = (int)Nup_Min.Value;
                Nup_Min.Value = Nup_Max.Value;
                Nup_Max.Value = buffer;
            }
        }

        private void Nup_Nb_ValueChanged(object sender, EventArgs e)
        {
            if (Nup_Nb.Value.ToString() == "")
            {
                Nup_Nb.Value = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( listW_Danse_List.SelectedItems.Count > 0)
            {
                int min;
                int max;
                if (listW_Danse_List.SelectedItems[0].SubItems[3].Text == "ND")
                {
                    min = 50; max = 150;
                }
                else
                {
                    min = Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[2].Text);
                    max = Int32.Parse(listW_Danse_List.SelectedItems[0].SubItems[3].Text);
                }
                
                Selection_param fen = new Selection_param(this, min,max);

                fen.Show();
            }
        }

        private void Nup_Max_Leave(object sender, EventArgs e)
        {
            if (Nup_Max.Text.ToString() == "")
            {
                Nup_Max.Value = 150;
            }
        }

        private void Nup_Min_Leave(object sender, EventArgs e)
        {
            if (Nup_Min.Text.ToString() == "")
            {
                Nup_Min.Value = 50;
            }
        }

        private void Nup_Nb_Leave(object sender, EventArgs e)
        {
            if (Nup_Nb.Text.ToString() == "")
            {
                Nup_Nb.Value = 3;
            }
        }

        private void btn_new_rout_Click(object sender, EventArgs e)
        {
            Model_Constructeur fen = new Model_Constructeur(this);

            fen.ShowDialog();
        }

        private void btn_load_rout_Click(object sender, EventArgs e)
        {/*
            OpenFileDialog FileD = new OpenFileDialog();
            FileD.Filter = "Text Files (.rtnPlay)|*.rtnPlay";
            FileD.FilterIndex = 1;
            DialogResult result1 = FileD.ShowDialog();
            
            if (result1 == DialogResult.OK)
            {
                // chemin
                string path = FileD.FileName;

                string[] text = File.ReadAllLines(path);

                List<string> selection = new List<string>();

                string Last_cmd = text[0];

                for( int i = 1; i < text.Length; i++)
                {
                    if(text[i][0] == '#')
                    {
                        Last_cmd = text[i];
                    }
                    else
                    {
                        if(Last_cmd == "#Danse")
                        {
                            string[] cmd = text[i].Split(';');
                            Generate_music_list(Int32.Parse(cmd[2]), Int32.Parse(cmd[3]), cmd[0], Int32.Parse(cmd[1]));

                            List<string> s = g.Musique_playlist.Last();
                            IComparer<string> comparer = new MusiqueComparer();

                            switch (cmd[4])
                            {
                                case "Descroissant":
                                    
                                    s.Sort(comparer);
                                    s.Reverse();

                                    break;

                                case "Croissant":
                                    
                                    s.Sort(comparer);

                                    break;

                                default:

                                    break;
                            }

                        }
                        else if (Last_cmd == "#Musique")
                        {
                            if(text[i-1] == "#Musique")
                            {
                                string[] arr = new string[4]; ListViewItem itm;
                                arr[0] = "";
                                arr[1] = text[i];
                                arr[2] = "ND";
                                arr[3] = "ND";
                                itm = new ListViewItem(arr);
                                listW_Danse_List.Items.Add(itm);
                            }
                            else
                            {
                                selection.Add(text[i]);
                            }

                            if (text[i + 1][0] == '#')
                            {
                                g.Musique_playlist.Add(selection);

                                selection = new List<string>();
                            }

                        }
                        
                    }
                }

            }
            */
        }

        private void listW_Danse_List_Leave(object sender, EventArgs e)
        {
           /* foreach(ListViewItem i in listW_Danse_List.Items)
            {
                if (i.Selected)
                {
                    i.BackColor = Color.Blue;
                }
                else
                {
                    i.BackColor = Color.White;
                }
            }*/
        }

        private void listW_Danse_List_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // If this item is the selected item
            if (e.Item.Selected)
            {
                // If the selected item just lost the focus
                if (gListView1LostFocusItem == e.Item.Index)
                {
                    // Set the colors to whatever you want (I would suggest
                    // something less intense than the colors used for the
                    // selected item when it has focus)
                    e.Item.BackColor = SystemColors.Highlight;

                    // Indicate that this action does not need to be performed
                    // again (until the next time the selected item loses focus)
                    gListView1LostFocusItem = -1;
                }
                else if (listW_Danse_List.Focused)  // If the selected item has focus
                {
                    // Set the colors to the normal colors for a selected item
                    e.Item.BackColor = SystemColors.Highlight;
                }
            }
            else
            {
                // Set the normal colors for items that are not selected
                e.Item.BackColor = listW_Danse_List.BackColor;
            }

            e.DrawBackground();
        }

        private void listW_Danse_List_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.Item.Selected)
                if (gListView1LostFocusItem == e.Item.Index)
                {
                    e.SubItem.ForeColor = Color.White;
                    gListView1LostFocusItem = -1;
                }
                else
                {
                    e.SubItem.ForeColor = Color.White;
                }
            else
                e.SubItem.ForeColor = Color.Black;

            e.DrawText();
        }

        private void listW_Danse_List_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Not interested in changing the way columns are drawn - this works fine
            e.DrawDefault = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> Danse_List = new List<string>();

            for(int i = 0; i < listW_Danse_List.Items.Count; i++)
            {
                Danse_List.Add(listW_Danse_List.Items[i].SubItems[1].Text);
            }

            //Selection_Manuelle fen = new Selection_Manuelle(this, g.Type_Musique, g.Musique_Founded, 1, Danse_List);
            //fen.ShowDialog();
        }
    }
}
