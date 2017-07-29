using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading;

namespace Danse_s_Playlist_Generator
{
    public partial class Application_Fen : Form
    {
        // Initialisation

        public Application_Fen()
        {
            InitializeComponent();
        }
        
        // Globals

        public static Globals g = new Globals();
        public Worker fen_loading_worker = new Worker();
        
        // to move
        public int gListView1LostFocusItem = -1;
                
        // Global Classe

        public class MusiqueComparer : IComparer<Musique>
        {
            public int Compare(Musique x, Musique y)
            {
                int bpm1 = x.rythme;
                int bpm2 = y.rythme;
                if (bpm1 < bpm2)
                    return -1;
                return bpm1 > bpm2 ? 1 : 0;
            }
        }

        //----

        private class Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                this.Name = name;
                this.Value = value;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }


        // --- 
        public class Worker
        {
            private volatile bool _shouldStop;
            private string status;

            public Chargement fen = new Chargement("");

            public Worker()
            {

            }

            public void DoWork()
            {
                this.fen.Show();
                Label label1 = (Label)fen.Controls.Find("label1", true)[0];
                Label label3 = (Label)fen.Controls.Find("label3", true)[0];

                while (!_shouldStop)
                {
                   if (status != label3.Text)
                    { 
                        label3.Visible = true;
                        label3.Text = status;
                        label3.Left = (fen.Width - label3.Width) / 2;
                        fen.Update();
                    }

                    label1.Text = "Chargement ...  \\";

                    fen.Update();

                    //Thread.Sleep(250);

                    label1.Text = "Chargement .... |";

                    //fen.Update();

                    //Thread.Sleep(250);

                    label1.Text = "Chargement .    /";

                    //fen.Update();

                    //Thread.Sleep(250);

                    label1.Text = "Chargement ..   -";

                    //fen.Update();

                   // Thread.Sleep(250);
                }

                fen.Close();
                
            }

            public void UpDate_Status(string s)
            {
                this.status = s;
            }

            public void RequestStop()
            {
                _shouldStop = true;
            }
         
        }

        /*public class Load_Worker
        {
            public int Index;
            public string Name;
            public List<string> List;
            public Worker fen_loading_worker;
            
            public Load_Worker(int index, string name, List<string> list, Worker fen)
            {
                this.Index = index;
                this.Name = name;
                this.List = list;
                this.fen_loading_worker = fen;
                //Console.WriteLine("Create : " + index + " : " + name);
            }

            public void DoWork_loading()
            {
                int index = this.Index;
                string name = this.Name;
                List< string > list = this.List;


                if (index == -1)
                    return;

                //Console.WriteLine("Start : " + index + " : " + name);

                List<string> stringList = new List<string>();

                //
                foreach (string str2 in list)
                {
                    //Console.WriteLine(str2 + "\n");

                    stringList.Add(((IEnumerable<string>)str2.Split(g.sep)).Last<string>());
                    

                }

                //g.Musique_Founded[index] = stringList;
                //Console.WriteLine(index + " : " + name);

                fen_loading_worker.UpDate_Status(name + " musics loaded ...");
            }

        }*/
        // ---


        // Global Functions

        public static bool IsNumeric(object Expression)
        {
            int result;
            return int.TryParse(Convert.ToString(Expression), NumberStyles.Any, (IFormatProvider)NumberFormatInfo.InvariantInfo, out result);
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

        // ============== ACCUEIL & DEMARRAGE  ============== //

        // -------------- Fonctions -------------- //

        
        private void Read_Parametres()
        {
            if (!File.Exists("." + Path.DirectorySeparatorChar + "Application.config"))
                return;

            using (StreamReader streamReader = new StreamReader("." + Path.DirectorySeparatorChar + "Application.config"))
            {

                string str1;

                while ((str1 = streamReader.ReadLine()) != null)
                {

                    switch (str1.Split('=')[0])
                    {
                        case "Path":

                            g.repertoire = str1.Split('=')[1];

                            if(g.repertoire == "" || !Directory.Exists(g.repertoire))
                            {
                                MessageBox.Show("Le repertoire de recherche est introuvable ou inexistant.\nMerci de sélectionner un repertoire valide.");

                                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                                    this.Close();

                                g.repertoire = folderBrowserDialog.SelectedPath;

                                Write_Parametres(g.repertoire);
                            }

                            this.txt_Rep_Recherche.Text = g.repertoire;
                            this.txt_Rep_Recherche2.Text = g.repertoire;
                            
                            break;

                        case "Sep":

                            if ((int)str1.Split('=')[1][0] == '/')
                            {
                                this.rad_slash.Checked = true;
                                g.sep_final = '/';
                            }
                            else
                            {
                                this.rad_backslash.Checked = true;
                                g.sep_final = '\\';
                            }

                            break;

                        case "Unit":
                            if (str1.Split('=')[1] == "BPM")
                            {
                                this.rdb_bpm.Checked = true;
                                g.Speed_Unit = "BPM";
                            }
                            else if (str1.Split('=')[1] == "MPM")
                            {
                                this.rdb_mpm.Checked = true;
                                g.Speed_Unit = "MPM";
                            }
                            else
                            {
                                this.rdb_Aucune.Checked = true;
                                g.Speed_Unit = "";
                            }
                            this.Change_Units();

                            break;
                    }
                    
                }
            }
        }
        
        private void Load_Files(string path_files)
        {
            // trouve le repertoire
            if (Directory.Exists(path_files))
            {
                Console.WriteLine("Repertoire OK");
            }
            else
            {
                MessageBox.Show("Repertoire de recherche introuvabe.\n Merci de relancer l'application pour resélectionner le repertoire.");
                // supprime le parametrage erroné
                Write_Parametres("");
                // Ferme l'application
                Close();
            } 
             
            string path = path_files;
                        
            // Trouve les repetoire de danse
            string[] directories = Directory.GetDirectories(path, "*");
            
            // pour chaque danse
            foreach (string Dir in directories)
            {
                // Liste toute les musiques du répertoire
                List<string> list = ((IEnumerable<string>)Directory.GetFiles(Dir, "*.mp3")).ToList<string>();
                                
                if (list.Count > 0)
                {
                    // Crée une nouvelle danse
                    Danse d = new Danse(Dir.Split(Path.DirectorySeparatorChar).Last());
                    
                    // Change le status de chargement
                    fen_loading_worker.UpDate_Status("Loading : " + d.nom);
                    
                    // On ajoute toutes les musiques
                    foreach (string m in list)
                    {
                        d.Add_Musique(new Musique(m));
                    }

                    g.dossier.Add_Danse(d);
                }
            }

                





            this.txt_Rep_Recherche.Text = path;

            this.Load_Stats();
            this.Fill_three_view();

        }

        private void Fill_three_view()
        {
            this.treeView1.Nodes.Clear();

            treeView1.PathSeparator = Path.DirectorySeparatorChar.ToString();

            foreach (Danse d in g.dossier.Get_All_Danses())
            {
                // Ajoute un Noeud danse avec le nombre de musique
                TreeNode children = new TreeNode(d.nom + " (" + d.Get_All_Musique_Name().Count + ")");

                // Ajoute les musiques au noeud
                foreach (Musique m in d.Get_All_Musique())
                {
                    children.Nodes.Add(m.nom);
                }

                // ajoute les musique a l'arbre
                treeView1.Nodes.Add(children);
                
            }
        }

        private void Load_Stats()
        {
            fen_loading_worker.UpDate_Status("Loading statistics ...");

            // nombre style de danse
            int nb = g.dossier.Get_All_Danses().Count;
            if (nb == 0)
                this.lbl_danse_f.Text = "Aucun style de danse referencée.";
            else if (nb == 1)
                this.lbl_danse_f.Text = nb + " style de danse referencée.";
            else
                this.lbl_danse_f.Text = nb + " styles de danse referencées.";

            // Nombre de musique avec et sans rythme
            int num1 = 0;
            int num2 = 0;

            foreach(Danse d in g.dossier.Get_All_Danses())
            {
                foreach(Musique m in d.Get_All_Musique())
                {
                    num1++;
                    if (m.rythme != 0)
                        num2++;
                }
            }
            

            // nb musique tot

            if (num1 == 0)
                this.lbl_music_f.Text = "Aucune musique trouvée.";
            else if (num1 == 1)
                this.lbl_music_f.Text = num1.ToString() + " musique trouvée.";
            else
                this.lbl_music_f.Text = num1.ToString() + " musiques trouvées.";

            // rythme 

            if (num2 == 0)
                this.lbl_music_f_r.Text = "Aucune musique, avec rythme, trouvée.";
            else if (num2 == 1)
                this.lbl_music_f_r.Text = num2.ToString() + " musique, avec rythme, trouvée.";
            else
                this.lbl_music_f_r.Text = num2.ToString() + " musiques avec rythme trouvées.";



            fen_loading_worker.UpDate_Status("Statistics loaded ...");
            

        }

        private void Change_Units()
        {
            string upper = g.Speed_Unit.ToUpper();
            if (!(upper == "BPM"))
            {
                if (upper == "MPM")
                {
                    this.groupBox5.Text = "Rythme (mpm)";
                    this.groupBox11.Text = "Rythme (mpm)";
                    this.groupBox11.Enabled = true;
                    this.groupBox5.Enabled = true;
                    this.btn_music_desc.Visible = true;
                    this.btn_musique_asc.Visible = true;
                    this.Nup_Max.Value = new Decimal(150);
                    this.Nup_Max_Rout.Value = new Decimal(150);
                    this.Nup_Min.Value = new Decimal(50);
                    this.Nup_Min_Rout.Value = new Decimal(50);
                }
                else
                {
                    this.groupBox5.Text = "Rythme";
                    this.groupBox11.Text = "Rythme";
                    this.groupBox11.Enabled = false;
                    this.groupBox5.Enabled = false;
                    this.btn_music_desc.Visible = false;
                    this.btn_musique_asc.Visible = false;
                    this.Nup_Max.Value = new Decimal(300);
                    this.Nup_Max_Rout.Value = new Decimal(300);
                    this.Nup_Min.Value = Decimal.Zero;
                    this.Nup_Min_Rout.Value = Decimal.Zero;
                }
            }
            else
            {
                this.groupBox5.Text = "Rythme (bpm)";
                this.groupBox11.Text = "Rythme (bpm)";
                this.groupBox11.Enabled = true;
                this.groupBox5.Enabled = true;
                this.btn_music_desc.Visible = true;
                this.btn_musique_asc.Visible = true;
                this.Nup_Max.Value = new Decimal(150);
                this.Nup_Max_Rout.Value = new Decimal(150);
                this.Nup_Min.Value = new Decimal(50);
                this.Nup_Min_Rout.Value = new Decimal(50);
            }
        }

        private void Load_Routine()
        {
            
        }

        // -------------- Events -------------- //

        private void Application_Load(object sender, EventArgs e)
        {
            this.Enabled = false;

            DoWork();

            this.Enabled = true;

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void DoWork()
        {
            //Thread t = new Thread(new ThreadStart(fen_loading_worker.DoWork));
            //t.Start();
            
            //fen_loading_worker.UpDate_Status("Loading : Parameters ...");

            this.Read_Parametres();

            //fen_loading_worker.UpDate_Status("Loading : Musics ...");

            if (g.repertoire != "")
                this.Load_Files(g.repertoire);
            else
                this.Load_Stats();

            this.status_modif(false);
            
            //fen_loading_worker.UpDate_Status("Loading : Routines ...");

            Load_Routine();
            
            //fen_loading_worker.RequestStop();
            //t.Join();

        }

        private void btn_folder_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            g.repertoire = folderBrowserDialog.SelectedPath;

            this.Enabled = false;

            Chargement fen = new Chargement("Mise à jour des données");
            fen.Show();

            DoWork();

            fen.Close();

            this.Enabled = true;
        }

        // ============== Playlist ============== //

        // -------------- Fonctions -------------- //

        public int Generate_music_list(int Min, int Max, string danse_file, int number)
        {
            /*int return_value = 0;

            int num1 = Min;
            int num2 = Max;
            if (num1 > num2)
            {
                num1 = Max;
                num2 = Min;
            }
            Random random = new Random();
            List<string> stringList1 = new List<string>();
            int index1 = g.Type_Musique.FindIndex((Predicate<string>)(x => x.Equals(danse_file)));
            foreach (string str in g.Musique_Founded[index1])
            {
                char[] chArray = new char[1]
                {
                    g.sep
                };

                string music = ((IEnumerable<string>)str.Split(chArray)).Last<string>();

                try
                {
                    int bpm = (music.Contains(' '))? Find_BPM(music, g.Speed_Unit):-1;
                    if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                        stringList1.Add(music);
                }
                catch(Exception e)
                {
                }

            }

            if (stringList1.Count > 0)
            {
                this.listW_Danse_List.Items.Add(new ListViewItem(new string[4]
                {
                  "",
                  danse_file,
                  num1.ToString(),
                  num2.ToString()
                }));

                List<string> stringList2 = new List<string>();

                int num3;

                for (num3 = 0; num3 < number && stringList1.Count > 0; ++num3)
                {
                    int index2 = random.Next(0, stringList1.Count - 1);
                    stringList2.Add(stringList1[index2]);

                    int duration = 0;
                    g.Musique_duration.TryGetValue(stringList1[index2], out duration);
                    g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds + duration);

                    g.Musique_Added.Add(stringList1[index2]);
                    stringList1.RemoveAt(index2);
                }

                if (stringList1.Count == 0 && num3 < number)
                {
                    int num4 = (int)MessageBox.Show("Toutes les musiques de " + danse_file + " dans cette portée ont déjà été ajoutées dans la playlist.\n Seulement " + (object)num3 + " musique(s) ont été ajoutée(s).");
                    return_value = -1;    
                }
                g.Musique_playlist.Add(stringList2);

            }
            else
            {
                int num5 = (int)MessageBox.Show("Toutes les musiques de " + danse_file + " dans cette portée ont déjà été ajoutées dans la playlist.");
                return -1;
            }
            return return_value;*/
            return 0;
        }

        public void Add_Music_to_Selection(int Min, int Max)
        {
           /* if (this.listW_Danse_List.SelectedItems.Count > 0)
            {
                int num1 = Min;
                int num2 = Max;
                if (num1 > num2)
                {
                    num1 = Max;
                    num2 = Min;
                }
                int index1 = this.listW_Danse_List.SelectedIndices[0];
                string danse_file = this.listW_Danse_List.SelectedItems[0].SubItems[1].Text;
                int index2 = g.Type_Musique.FindIndex((Predicate<string>)(x => x.Equals(danse_file)));
                Random random = new Random();
                List<string> stringList1 = new List<string>();
                foreach (string str in g.Musique_Founded[index2])
                {
                    char[] chArray = new char[1]
                    {
                        g.sep
                    };
                    string music = ((IEnumerable<string>)str.Split(chArray)).Last<string>();
                    
                    int bpm = (music.Contains(' '))? Find_BPM(music, g.Speed_Unit):-1;
                    if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                        stringList1.Add(music);
                    
                }
                if (stringList1.Count > 0)
                {
                    List<string> stringList2 = g.Musique_playlist[index1];
                    int num3 = 0;
                    if (stringList1.Count > 0)
                    {
                        int index3 = random.Next(0, stringList1.Count - 1);
                        stringList2.Add(stringList1[index3]);

                        int duration = 0;
                        g.Musique_duration.TryGetValue(stringList1[index3],out duration);
                        g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds + duration);

                        g.Musique_Added.Add(stringList1[index3]);
                        stringList1.RemoveAt(index3);
                        int num4 = num3 + 1;
                    }
                    else
                    {
                        int num5 = (int)MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist.\n Seulement " + (object)num3 + " musique(s) ont été ajoutée(s).");
                    }
                    g.Musique_playlist[index1] = stringList2;
                }
            }
            else
            {
                int num = (int)MessageBox.Show("Tout les musiques de ce style et dans cette porté sont déjà dans la playlist.");
            }
            this.Maj_Liste_Musique();*/
        }

        public void Modify_Music_Selected(int Min, int Max)
        {
            /*int num1 = Min;
            int num2 = Max;
            if (num1 > num2)
            {
                num1 = Max;
                num2 = Min;
            }
            string danse_file = this.listW_Danse_List.SelectedItems[0].SubItems[1].Text;
            Random random = new Random();
            List<string> stringList1 = new List<string>();
            int index1 = this.listW_Danse_List.SelectedIndices[0];
            int index2 = g.Type_Musique.FindIndex((Predicate<string>)(x => x.Equals(danse_file)));
            List<int> intList = new List<int>();
            for (int index3 = 0; index3 < this.list_Musiques.SelectedItems.Count; ++index3)
            {
                intList.Add(this.list_Musiques.SelectedIndices[index3]);

                int duration = 0;
                g.Musique_duration.TryGetValue(this.list_Musiques.Items[this.list_Musiques.SelectedIndices[index3]].ToString(), out duration);
                g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds - duration);

                g.Musique_Added.Remove(this.list_Musiques.Items[this.list_Musiques.SelectedIndices[index3]].ToString());
            }
            foreach (string str in g.Musique_Founded[index2])
            {
                char[] chArray = new char[1]
                {
          g.sep
                };
                string music = ((IEnumerable<string>)str.Split(chArray)).Last<string>();
                try
                {
                    int bpm = (music.Contains(' '))? Find_BPM(music, g.Speed_Unit):-1;
                    if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                        stringList1.Add(music);
                }
                catch(Exception e)
                {
                }
            }
            List<string> stringList2 = g.Musique_playlist[index1];
            if (stringList1.Count > 0)
            {
                for (int index3 = 0; index3 < intList.Count && stringList1.Count > 0; ++index3)
                {
                    int index4 = random.Next(0, stringList1.Count - 1);
                    stringList2[intList[index3]] = stringList1[index4];

                    int duration = 0;
                    g.Musique_duration.TryGetValue(stringList1[index4], out duration);
                    g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds + duration);

                    g.Musique_Added.Add(stringList1[index4]);
                    stringList1.RemoveAt(index4);
                }
            }
            g.Musique_playlist[index1] = stringList2;
            this.Maj_Liste_Musique();
            foreach (int index3 in intList)
                this.list_Musiques.SetSelected(index3, true);*/
        }

        public void Modify_All_Music(int Min, int Max)
        {/*
            int num1 = Min;
            int num2 = Max;
            if (num1 > num2)
            {
                num1 = Max;
                num2 = Min;
            }
            string danse_file = this.listW_Danse_List.SelectedItems[0].SubItems[1].Text;
            Random random = new Random();
            List<string> stringList1 = new List<string>();
            int index1 = this.listW_Danse_List.SelectedIndices[0];
            int index2 = g.Type_Musique.FindIndex((Predicate<string>)(x => x.Equals(danse_file)));
            List<string> stringList2 = g.Musique_playlist[index1];
            foreach (string str in stringList2)
            {
                int duration = 0;
                g.Musique_duration.TryGetValue(str, out duration);
                g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds - duration);
                g.Musique_Added.Remove(str);
            }
            foreach (string str in g.Musique_Founded[index2])
            {
                char[] chArray = new char[1]
                {
          g.sep
                };
                string music = ((IEnumerable<string>)str.Split(chArray)).Last<string>();
                
                int bpm = (music.Contains(' '))? Find_BPM(music, g.Speed_Unit):-1;
                if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                    stringList1.Add(music);
                
            }
            if (stringList1.Count > 0)
            {
                for (int index3 = 0; index3 < stringList2.Count; ++index3)
                {
                    int index4 = random.Next(0, stringList1.Count - 1);
                    stringList2[index3] = stringList1[index4];

                    int duration = 0;
                    g.Musique_duration.TryGetValue(stringList1[index4], out duration);
                    g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds + duration);

                    g.Musique_Added.Add(stringList1[index4]);
                    stringList1.RemoveAt(index4);
                }
            }
            this.Maj_Liste_Musique();
            g.Musique_playlist[index1] = stringList2;*/
        }

        public void Change_Min_Max(int Min, int Max)
        {
            ListViewItem listViewItem = this.listW_Danse_List.SelectedItems[0];
            listViewItem.SubItems[2].Text = Min.ToString();
            listViewItem.SubItems[3].Text = Max.ToString();
            this.listW_Danse_List.Items[this.listW_Danse_List.SelectedIndices[0]] = listViewItem;
        }

        public void Maj_Liste_Musique()
        {
            /*this.list_Musiques.Items.Clear();
            if (this.listW_Danse_List.SelectedIndices.Count <= 0)
                return;
            foreach (object obj in g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]])
                this.list_Musiques.Items.Add(obj);*/
        }

        public void Ajout_Manuel(int position, string style, List<string> Musique)
        {
            /*if (position == -1)
            {
                this.listW_Danse_List.Items.Add(new ListViewItem(new string[4]
                {
          "",
          style,
          "ND",
          "ND"
                }));
                g.Musique_playlist.Add(Musique);
                foreach (string str in Musique)
                {
                    int duration = 0;
                    g.Musique_duration.TryGetValue(str, out duration);
                    g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds + duration);
                    g.Musique_Added.Add(str);
                }
            }
            else
            {
                int num = 0;
                for (int index = 0; index < this.listW_Danse_List.Items.Count; ++index)
                {
                    if (this.listW_Danse_List.Items[index].SubItems[1].Text == style)
                    {
                        ++num;
                        if (num == position)
                        {
                            List<string> stringList = g.Musique_playlist[index];
                            foreach (string str in Musique)
                            {
                                int duration = 0;
                                g.Musique_duration.TryGetValue(str, out duration);
                                g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds + duration);
                                stringList.Add(str);
                            }
                                
                            g.Musique_playlist[index] = stringList;
                            index = this.listW_Danse_List.Items.Count;
                        }
                    }
                }
            }
            this.btn_save.Visible = true;
            this.btn_reset.Visible = true;*/
        }

        public void Add_Routine_to_Playlist(List<string> routine,int nb , TimeSpan time)
        {
            /*List<OBJ_Danse> Liste_routine = new List<OBJ_Danse>();

            connect.Open();

            foreach (string name in routine)
            {
                
                OleDbCommand cmd = new OleDbCommand(SQL_Command.Get_Danse(name), connect);

                OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                int i = 0;
                List<string> Musiques = new List<string>();
                while (reader.Read())
                {
                    if ((bool)reader[8] == false)
                    {
                        OleDbCommand cmd2 = new OleDbCommand(SQL_Command.Get_Musique(name, i.ToString()), connect);

                        OleDbDataReader reader2 = cmd2.ExecuteReader();
                        
                        while (reader2.Read())
                        {
                            Musiques.Add((string)reader2[0]);
                        }

                        reader2.Close();
                    }

                    OBJ_Danse obj = new OBJ_Danse((string)reader[2], (int)reader[3], (int)reader[4], (int)reader[5], (int)reader[6], Musiques);
                    Liste_routine.Add(obj);
                }

                reader.Close();
                
            }

            connect.Close();
            
            if (Liste_routine.Count == 0)
                return;

            int counter = 0;
            int limite = nb * Liste_routine.Count;
            TimeSpan timer = g.Playlist_Length + time;
            while ( ( (nb != -1 && counter < limite) || ( time != new TimeSpan(0,0,0) && g.Playlist_Length < timer) ) && Liste_routine.Count > 0)
            {
                OBJ_Danse obj = Liste_routine[ counter%Liste_routine.Count ];
                
                if(obj.Musique_m.Count == 0)
                {
                    if (Generate_music_list(obj.Min, obj.Max, obj.Nom, obj.Nombre) == -1)
                    {
                        string nom = obj.Nom;
                        for (int j = Liste_routine.Count-1; j >= 0; j--)
                            if (Liste_routine[j].Nom == nom)
                                Liste_routine.RemoveAt(j);
                        limite = nb * Liste_routine.Count;
                    }
                        
                }
                else
                {
                    Ajout_Manuel(-1, obj.Nom, obj.Musique_m);
                }

                IComparer<string> comparer = (IComparer<string>)new MusiqueComparer();

                switch (obj.Ordre)
                {
                    case -1:
                        g.Musique_playlist[g.Musique_playlist.Count - 1].Sort(comparer);
                        g.Musique_playlist[g.Musique_playlist.Count - 1].Reverse();
                        break;

                    case 1:
                        g.Musique_playlist[g.Musique_playlist.Count - 1].Sort(comparer);
                        break;

                    default:
                         // nothing
                        break;
                }

                counter++;
            }

            this.btn_save.Visible = true;
            this.btn_reset.Visible = true;*/
        }

        public void Maj_Stat_Geneation(int val)
        {/*
            connect.Open();

            OleDbCommand cmd = new OleDbCommand(SQL_Command.Update_Number_Playlist(val), connect);

            cmd.ExecuteNonQuery();

            connect.Close();

            Load_Stats();
            */
        }

        // -------------- Events -------------- //

        private void btn_ajouter_danse_Click(object sender, EventArgs e)
        {
            if (!(g.repertoire != "") || this.cmb_Danses.SelectedIndex == -1)
                return;
            this.Generate_music_list((int)this.Nup_Min.Value, (int)this.Nup_Max.Value, this.cmb_Danses.Text, (int)this.Nup_Nb.Value);
            this.cmb_Danses.SelectedIndex = -1;
            this.btn_save.Visible = true;
            this.btn_reset.Visible = true;
        }

        private void listW_Danse_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedItems.Count > 0)
            {
                this.Maj_Liste_Musique();
                this.groupBox2.Enabled = true;
            }
            else
                this.groupBox2.Enabled = false;
        }

        private void btn_add_to_danse_Click(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedItems.Count <= 0 || !(this.listW_Danse_List.SelectedItems[0].SubItems[2].Text != "ND"))
                return;
            this.Add_Music_to_Selection(int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[2].Text), int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[3].Text));
        }

        private void btn_reload_select_Click(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedItems.Count <= 0 || this.list_Musiques.SelectedIndices.Count <= 0)
                return;
            this.Modify_Music_Selected(int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[2].Text), int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[3].Text));
        }

        private void btn_reload_all_Click(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedItems.Count <= 0)
                return;
            this.Modify_All_Music(int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[2].Text), int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[3].Text));
        }

        private void btn_delete_danse_Click(object sender, EventArgs e)
        {/*
            if (this.listW_Danse_List.SelectedItems.Count == 0)
                return;

            int index = this.listW_Danse_List.SelectedIndices[0];
            if (index != -1)
            {
                this.listW_Danse_List.Items.RemoveAt(index);
                foreach (string str in g.Musique_playlist[index])
                {
                    int duration = 0;
                    g.Musique_duration.TryGetValue(str, out duration);
                    g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds - duration);

                    g.Musique_Added.Remove(str);
                }
                g.Musique_playlist.RemoveAt(index);
                this.Maj_Liste_Musique();
            }
            if (this.listW_Danse_List.Items.Count != 0)
                return;
            this.btn_save.Visible = false;
            this.btn_reset.Visible = false;*/
        }

        private void btn_delete_selection_Click(object sender, EventArgs e)
        {/*
            int index1 = this.listW_Danse_List.SelectedIndices[0];
            List<int> intList = new List<int>();
            for (int index2 = 0; index2 < this.list_Musiques.SelectedItems.Count; ++index2)
                intList.Add(this.list_Musiques.SelectedIndices[index2]);
            if (intList.Count <= 0)
                return;
            List<string> stringList = g.Musique_playlist[index1];
            for (int index2 = intList.Count - 1; index2 >= 0; --index2)
            {
                g.Musique_Added.Remove(stringList[index2]);

                int duration = 0;
                g.Musique_duration.TryGetValue(stringList[index2], out duration);
                g.Playlist_Length = new TimeSpan(0, 0, (int)g.Playlist_Length.TotalSeconds - duration);

                stringList.RemoveAt(intList[index2]);
            }
            if (stringList.Count > 0)
            {
                g.Musique_playlist[index1] = stringList;
            }
            else
            {
                g.Musique_playlist.RemoveAt(index1);
                this.listW_Danse_List.Items[index1].Remove();
                if (this.listW_Danse_List.Items.Count == 0)
                {
                    this.btn_reset.Visible = false;
                    this.btn_save.Visible = false;
                }
            }
            this.Maj_Liste_Musique();*/
        }

        private void btn_music_up_Click(object sender, EventArgs e)
        {/*
            if(this.listW_Danse_List.SelectedItems.Count == 0)
                return;

            int index1 = this.listW_Danse_List.SelectedIndices[0];
            int index2 = index1 - 1;
            List<string> stringList = g.Musique_playlist[index1];
            g.Musique_playlist[index1] = g.Musique_playlist[index1 - 1];
            g.Musique_playlist[index1 - 1] = stringList;

            string[] strArray1 = new string[3]
            {
            this.listW_Danse_List.Items[index1].SubItems[1].Text,
            this.listW_Danse_List.Items[index1].SubItems[2].Text,
            this.listW_Danse_List.Items[index1].SubItems[3].Text
            };

            string[] strArray2 = new string[3]
            {
                this.listW_Danse_List.Items[index2].SubItems[1].Text,
                this.listW_Danse_List.Items[index2].SubItems[2].Text,
                this.listW_Danse_List.Items[index2].SubItems[3].Text
            };

            ListViewItem listViewItem1 = this.listW_Danse_List.Items[index1];
            listViewItem1.SubItems[0].Text = "";
            listViewItem1.SubItems[1].Text = strArray2[0];
            listViewItem1.SubItems[2].Text = strArray2[1];
            listViewItem1.SubItems[3].Text = strArray2[2];
            this.listW_Danse_List.Items[index1] = listViewItem1;
            this.listW_Danse_List.Items[index1].Selected = false;
            ListViewItem listViewItem2 = this.listW_Danse_List.Items[index2];
            listViewItem2.SubItems[0].Text = "";
            listViewItem2.SubItems[1].Text = strArray1[0];
            listViewItem2.SubItems[2].Text = strArray1[1];
            listViewItem2.SubItems[3].Text = strArray1[2];
            this.listW_Danse_List.Items[index2] = listViewItem2;
            this.listW_Danse_List.Items[index2].Selected = true;
            this.listW_Danse_List.Focus();*/
        }

        private void btn_music_down_Click(object sender, EventArgs e)
        {/*
            if (this.listW_Danse_List.SelectedItems.Count <= 0 || this.listW_Danse_List.SelectedIndices[0] >= this.listW_Danse_List.Items.Count - 1)
                return;
            int index1 = this.listW_Danse_List.SelectedIndices[0];
            int index2 = index1 + 1;
            List<string> stringList = g.Musique_playlist[index1];
            g.Musique_playlist[index1] = g.Musique_playlist[index1 + 1];
            g.Musique_playlist[index1 + 1] = stringList;
            string[] strArray1 = new string[3]
            {
        this.listW_Danse_List.Items[index1].SubItems[1].Text,
        this.listW_Danse_List.Items[index1].SubItems[2].Text,
        this.listW_Danse_List.Items[index1].SubItems[3].Text
            };
            string[] strArray2 = new string[3]
            {
        this.listW_Danse_List.Items[index2].SubItems[1].Text,
        this.listW_Danse_List.Items[index2].SubItems[2].Text,
        this.listW_Danse_List.Items[index2].SubItems[3].Text
            };
            ListViewItem listViewItem1 = this.listW_Danse_List.Items[index1];
            listViewItem1.SubItems[0].Text = "";
            listViewItem1.SubItems[1].Text = strArray2[0];
            listViewItem1.SubItems[2].Text = strArray2[1];
            listViewItem1.SubItems[3].Text = strArray2[2];
            this.listW_Danse_List.Items[index1] = listViewItem1;
            this.listW_Danse_List.Items[index1].Selected = false;
            ListViewItem listViewItem2 = this.listW_Danse_List.Items[index2];
            listViewItem2.SubItems[0].Text = "";
            listViewItem2.SubItems[1].Text = strArray1[0];
            listViewItem2.SubItems[2].Text = strArray1[1];
            listViewItem2.SubItems[3].Text = strArray1[2];
            this.listW_Danse_List.Items[index2] = listViewItem2;
            this.listW_Danse_List.Items[index2].Selected = true;
            this.listW_Danse_List.Focus();*/
        }

        private void btn_selection_up_Click(object sender, EventArgs e)
        {/*
            if (this.list_Musiques.SelectedIndex <= 0)
                return;
            List<string> stringList = g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]];
            string str = stringList[this.list_Musiques.SelectedIndex];
            stringList[this.list_Musiques.SelectedIndex] = stringList[this.list_Musiques.SelectedIndex - 1];
            stringList[this.list_Musiques.SelectedIndex - 1] = str;
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]] = stringList;
            int selectedIndex = this.list_Musiques.SelectedIndex;
            this.Maj_Liste_Musique();
            this.list_Musiques.SelectedIndex = selectedIndex - 1;*/
        }

        private void btn_selection_down_Click(object sender, EventArgs e)
        {/*
            if (this.list_Musiques.SelectedIndex == -1 || this.list_Musiques.SelectedIndex >= this.list_Musiques.Items.Count - 1)
                return;
            List<string> stringList = g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]];
            string str = stringList[this.list_Musiques.SelectedIndex];
            stringList[this.list_Musiques.SelectedIndex] = stringList[this.list_Musiques.SelectedIndex + 1];
            stringList[this.list_Musiques.SelectedIndex + 1] = str;
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]] = stringList;
            int selectedIndex = this.list_Musiques.SelectedIndex;
            this.Maj_Liste_Musique();
            this.list_Musiques.SelectedIndex = selectedIndex + 1;*/
        }

        private void btn_musique_asc_Click(object sender, EventArgs e)
        {/*
            IComparer<string> comparer = (IComparer<string>)new MusiqueComparer();
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]].Sort(comparer);
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]].Reverse();
            this.Maj_Liste_Musique();*/
        }

        private void btn_music_desc_Click(object sender, EventArgs e)
        {/*
            IComparer<string> comparer = (IComparer<string>)new MusiqueComparer();
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]].Sort(comparer);
            this.Maj_Liste_Musique();*/
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {/*
            if (this.listW_Danse_List.SelectedItems.Count <= 0)
                return;
            List<string> stringList = g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]];
            this.Shuffle<string>((IList<string>)stringList);
            this.Shuffle<string>((IList<string>)stringList);
            this.Shuffle<string>((IList<string>)stringList);
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]] = stringList;
            this.Maj_Liste_Musique();*/
        }

        private void btn_save_Click(object sender, EventArgs e)
        {/*
            if (this.listW_Danse_List.Items.Count <= 0)
                return;
            g.text = "#EXTM3U\n";
            char ch = !this.rad_slash.Checked ? '\\' : '/';
            for (int index = 0; index < this.listW_Danse_List.Items.Count; ++index)
            {
                foreach (string str in g.Musique_playlist[index])
                {
                    Globals globals = g;
                    globals.text = globals.text + "." + ch.ToString() + this.listW_Danse_List.Items[index].SubItems[1].Text + ch.ToString() + str + "\n";
                }
            }
            switch (MessageBox.Show("Voulez-vous avoir un apperçu du fichier avant d'enregister?", "Finalisation", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    Apperçu apperçu = new Apperçu(g.text,true);
                    int num1 = (int)apperçu.ShowDialog();
                    if (apperçu.DialogResult == DialogResult.OK)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = g.repertoire;
                        saveFileDialog.FileName = "Nouvelle playlist";
                        saveFileDialog.Title = "Enregistrement de la playlist";
                        saveFileDialog.DefaultExt = ".m3u";
                        saveFileDialog.AddExtension = true;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (File.Exists(saveFileDialog.FileName))
                                File.Delete(saveFileDialog.FileName);

                            File.WriteAllText(saveFileDialog.FileName, g.text);
                            int num2 = (int)MessageBox.Show("Sauvegarde Réussie !");
                            Maj_Stat_Geneation(++g.nombre_Generation);

                        }
                        break;
                    }
                    break;
                case DialogResult.No:
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = g.repertoire;
                    saveFileDialog1.FileName = "Nouvelle playlist";
                    saveFileDialog1.Title = "Enregistrement de la playlist";
                    saveFileDialog1.DefaultExt = ".m3u";
                    saveFileDialog1.AddExtension = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(saveFileDialog1.FileName))
                            File.Delete(saveFileDialog1.FileName);

                        File.WriteAllText(saveFileDialog1.FileName, g.text);
                        int num2 = (int)MessageBox.Show("Sauvegarde Réussie !");
                        Maj_Stat_Geneation(++g.nombre_Generation);
                    }
                    break;
            }*/
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {/*
            if (MessageBox.Show("Etes-vous sure de vouloir supprimer la playlist ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.listW_Danse_List.Items.Clear();
            this.list_Musiques.Items.Clear();
            g.Musique_playlist.Clear();
            g.Musique_Added.Clear();
            this.btn_reset.Visible = false;
            this.btn_save.Visible = false;*/
        }

        private void Nup_Min_ValueChanged(object sender, EventArgs e)
        {
            if (!(this.Nup_Min.Value > this.Nup_Max.Value))
                return;
            int num = (int)this.Nup_Min.Value;
            this.Nup_Min.Value = this.Nup_Max.Value;
            this.Nup_Max.Value = (Decimal)num;
        }

        private void Nup_Max_ValueChanged(object sender, EventArgs e)
        {
            if (!(this.Nup_Min.Value > this.Nup_Max.Value))
                return;
            int num = (int)this.Nup_Min.Value;
            this.Nup_Min.Value = this.Nup_Max.Value;
            this.Nup_Max.Value = (Decimal)num;
        }

        private void Nup_Nb_ValueChanged(object sender, EventArgs e)
        {
            if (!(this.Nup_Nb.Value.ToString() == ""))
                return;
            this.Nup_Nb.Value = new Decimal(3);
        }

        private void btn_change_danse_Click(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedItems.Count <= 0)
                return;
            int min;
            int max;
            if (this.listW_Danse_List.SelectedItems[0].SubItems[3].Text == "ND")
            {
                min = 50;
                max = 150;
            }
            else
            {
                min = int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[2].Text);
                max = int.Parse(this.listW_Danse_List.SelectedItems[0].SubItems[3].Text);
            }
            new Selection_param((Form)this, min, max).Show();
        }

        private void listW_Danse_List_Leave(object sender, EventArgs e)
        {
        }

        private void listW_Danse_List_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                if (this.gListView1LostFocusItem == e.Item.Index)
                {
                    e.Item.BackColor = SystemColors.Highlight;
                    this.gListView1LostFocusItem = -1;
                }
                else if (this.listW_Danse_List.Focused)
                    e.Item.BackColor = SystemColors.Highlight;
            }
            else
                e.Item.BackColor = this.listW_Danse_List.BackColor;
            e.DrawBackground();
        }

        private void listW_Danse_List_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                if (this.gListView1LostFocusItem == e.Item.Index)
                {
                    e.SubItem.ForeColor = Color.White;
                    this.gListView1LostFocusItem = -1;
                }
                else
                    e.SubItem.ForeColor = Color.White;
            }
            else
                e.SubItem.ForeColor = Color.Black;
            e.DrawText();
        }

        private void listW_Danse_List_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btn_selection_manuelle_Click(object sender, EventArgs e)
        {/*
            List<string> List_Danse = new List<string>();
            for (int index = 0; index < this.listW_Danse_List.Items.Count; ++index)
                List_Danse.Add(this.listW_Danse_List.Items[index].SubItems[1].Text);
            int num = (int)new Selection_Manuelle(this, g.Type_Musique, g.Musique_Founded, 1, List_Danse).ShowDialog();*/
        }

        private void btn_load_rout_Click(object sender, EventArgs e)
        {/*
            
            List<string> routine = new List<string>();
            connect.Open();

            OleDbCommand cmd = new OleDbCommand(SQL_Command.Get_Routine(), connect);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                routine.Add(reader[0].ToString());
            }

            reader.Close();
            connect.Close();

            Routine_Loader fen = new Routine_Loader(this,routine);
            fen.ShowDialog();*/

        }

        private void pic_Apperçu_Click(object sender, EventArgs e)
        {/*
            if(this.listW_Danse_List.Items.Count > 0)
            {
                string text = g.Playlist_Length.Hours + " H " + g.Playlist_Length.Minutes + " M " + g.Playlist_Length.Seconds + " S \n";
                for (int index = 0; index < this.listW_Danse_List.Items.Count; ++index)
                {
                    text += "\n" + this.listW_Danse_List.Items[index].SubItems[1].Text + "\n";
                    foreach (string str in g.Musique_playlist[index])
                    {
                        text += str + "\n";
                    }
                }

                Apperçu fen = new Apperçu(text, false);
                fen.ShowDialog();
            }*/
            
        }

        // ============== Routine ============== //

        List<List<string>> Musique_Manuelle_Routine = new List<List<string>>();

        public string routine_name = "";

        public bool En_modification = false;

        // -------------- Fonctions -------------- //

        public void Ajout_Manuel_Rout(string style, List<string> Musique)
        {
            Musique_Manuelle_Routine.Add(Musique);

            dataGridView_Routine.Rows.Add(0, style, Musique.Count.ToString(), "ND", "ND", "ND");

            En_modification = true;

        }

        public void Load_Routine_Data(string name)
        {/*
            Musique_Manuelle_Routine.Clear();

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(SQL_Command.Get_Danse(name), connect);

            OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
            int i = 0;
            int auto;
            while (reader.Read())
            {
                if ((bool)reader[8] == false)
                {
                    auto = 0;
                    OleDbCommand cmd2 = new OleDbCommand(SQL_Command.Get_Musique(name, i.ToString()), connect);

                    OleDbDataReader reader2 = cmd2.ExecuteReader();

                    List<string> l = new List<string>();
                    while (reader2.Read())
                    {
                        l.Add((string)reader2[0]);
                    }
                    Musique_Manuelle_Routine.Add(l);

                    reader2.Close();
                }
                else
                    auto = 1;

                string ordre = "";

                switch ((int)reader[6])
                {
                    case 1:
                        ordre = "Croissant";
                        break;
                    case -1:
                        ordre = "Descoissant";
                        break;
                    default:
                        ordre = "Aléatoire";
                        break;
                }
                
                dataGridView_Routine.Rows.Add(auto, (string)reader[2], reader[3].ToString(), (string)reader[4].ToString(), (string)reader[5].ToString(), ordre);

                i++;
            }

            reader.Close();
            
            connect.Close();*/
        }

        public int Save_Routine()
        {/*
            connect.Open();

            OleDbCommand cmd;
            if (routine_name == "new")
            {
                string nom = Interaction.InputBox("Quel nom voulez-vous donner à la routine?", "Nouvelle routine", "");

                bool ok = false;
                while (!ok)
                {
                    string err = "";

                    if (nom == "")
                    {

                        MessageBox.Show("La routine n'a pas été enregistré pour cause d'abscence de nom ou d'annulation.");

                        return -1;
                    }


                    else if (cmb_Danses_r.Items.Contains(nom))
                        err = "Erreur : Ce nom de routine est déjà utilisé.\n\n";
                    else
                        ok = true;

                    if (!ok)
                    {
                        nom = Interaction.InputBox(err + "Quel nom voulez-vous donner à la routine?", "Nouvelle routine", "");
                    }

                }

                routine_name = nom;

                cmb_routine.Items.Add(routine_name);

                OleDbCommand cmd2 = new OleDbCommand(SQL_Command.Insert_Routine(routine_name, ""), connect);
                cmd2.ExecuteNonQuery();



            }
            else
            {
                cmd = new OleDbCommand(SQL_Command.Delete_Musique(routine_name), connect);
                cmd.ExecuteNonQuery();
            }


            int counter = 0;
            for (int i = 0; i < dataGridView_Routine.Rows.Count; i++)
            {
                if ((int)dataGridView_Routine.Rows[i].Cells[0].Value == 1)
                {
                    int ordre;
                    switch ((string)dataGridView_Routine.Rows[i].Cells[5].Value)
                    {
                        case "Alétoire":
                            ordre = 0;
                            break;
                        case "Croissant":
                            ordre = 1;
                            break;
                        case "Descroissant":
                            ordre = -1;
                            break;
                        default:
                            ordre = 0;
                            break;
                    }

                    cmd = new OleDbCommand(SQL_Command.Insert_Danse(routine_name, // routine
                        i, // id_danse
                        dataGridView_Routine.Rows[i].Cells[1].Value.ToString(), // type danse
                        dataGridView_Routine.Rows[i].Cells[2].Value.ToString(), // Nombre musique
                        i, // Position 
                        dataGridView_Routine.Rows[i].Cells[3].Value.ToString(), // Min
                        dataGridView_Routine.Rows[i].Cells[4].Value.ToString(), // Max
                        ordre, // Ordre
                        "1" // Type de sélection
                        ), connect);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new OleDbCommand(SQL_Command.Insert_Danse(routine_name.Replace("'", "''"), // routine
                        i, // id_danse
                        (string)dataGridView_Routine.Rows[i].Cells[1].Value, // type danse
                        dataGridView_Routine.Rows[i].Cells[2].Value.ToString(), // Nombre musique
                        i, // Position 
                        "-1", // Min
                        "-1", // Max
                        0, // Ordre
                        "0" // Type de sélection
                        ), connect);

                    cmd.ExecuteNonQuery();

                    for (int j = 0; j < Musique_Manuelle_Routine[counter].Count; j++)
                    {
                        cmd = new OleDbCommand(SQL_Command.Insert_Musique(routine_name.Replace("'", "''"),
                            i,
                            j,
                            Musique_Manuelle_Routine[counter][j].Replace("'", "''"),
                            j)
                            , connect);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(routine_name + i.ToString()+j.ToString());
                    }

                    counter++;
                }

            }
            connect.Close();

            routine_name = "";

            MessageBox.Show("Routine enregistré.");

            return 1;*/
            return 0;
        }

        public void afficher_modif_rout(bool b)
        {
            grp_aj_d_r.Visible = b;
            grp_opt_r.Visible = b;
            btn_Save_Rout.Visible = b;
            btn_Fermer.Visible = b;
            lbl_selec.Visible = b;
            lst_Musique_Manuelle_View.Visible = b;

        }

        public void modif_danse(string nb,string min, string max,string tri)
        {
            dataGridView_Routine.SelectedRows[0].Cells[2].Value = nb;
            dataGridView_Routine.SelectedRows[0].Cells[3].Value = min;
            dataGridView_Routine.SelectedRows[0].Cells[4].Value = max;
            dataGridView_Routine.SelectedRows[0].Cells[5].Value = tri;
        }

        // -------------- Events -------------- //

        private void btn_ajouter_danse_r_Click(object sender, EventArgs e)
        {
            if (cmb_Danses_r.SelectedIndex != -1)
            {
                En_modification = true;

                string tri;

                if (rdb_Aleatoire.Checked)
                    tri = "Aléatoire";
                else if (rdb_Croissant.Checked)
                    tri = "Croissant";
                else
                    tri = "Descroissant";

                dataGridView_Routine.Rows.Add(1, cmb_Danses_r.Text, Nup_Nb_r.Value.ToString(), Nup_Min_Rout.Value.ToString(), Nup_Max_Rout.Value.ToString(), tri);
               
            }
        }

        private void button3_Click(object sender, EventArgs e) // selection manuelle
        {/*
            Selection_Manuelle fen = new Selection_Manuelle(this, g.Type_Musique, g.Musique_Founded, 2, null);
            fen.ShowDialog();*/
        }

        private void btn_Danse_Up_r_Click(object sender, EventArgs e)
        {
            if ((dataGridView_Routine.SelectedRows.Count > 0) && (dataGridView_Routine.SelectedRows[0].Index > 0))
            {
                En_modification = true;

                int index = dataGridView_Routine.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView_Routine.Rows[index];
                DataGridViewRow row_ = dataGridView_Routine.Rows[index-1];

                if ((int)row.Cells[0].Value == 0 && (int)row_.Cells[0].Value == 0)
                {
                    int counter = 0;
                    for (int i = 0; i < index; i++)
                    {
                        if ((int)dataGridView_Routine.Rows[i].Cells[0].Value == 0)
                            counter++;

                    }
                    List<string> buffer = Musique_Manuelle_Routine[counter];
                    Musique_Manuelle_Routine.RemoveAt(counter);
                    Musique_Manuelle_Routine.Insert(counter - 1, buffer);

                }

                dataGridView_Routine.Rows.RemoveAt(index);
                dataGridView_Routine.Rows.Insert(index - 1, row);
                
                dataGridView_Routine.Rows[index - 1].Selected = true;
                
            }
        }

        private void btn_Danse_Down_r_Click(object sender, EventArgs e)
        {
            if ((dataGridView_Routine.SelectedRows.Count > 0) && ( dataGridView_Routine.SelectedRows[0].Index < dataGridView_Routine.Rows.Count - 1) )
            {
                En_modification = true;

                int index = dataGridView_Routine.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView_Routine.Rows[index];
                DataGridViewRow row_ = dataGridView_Routine.Rows[index+1];

                if ((int)row.Cells[0].Value == 0 && (int)row_.Cells[0].Value == 0)
                {
                    int counter = 0;
                    for (int i = 0; i < index; i++)
                    {
                        if ((int)dataGridView_Routine.Rows[i].Cells[0].Value == 0)
                            counter++;

                    }
                    List<string> buffer = Musique_Manuelle_Routine[counter];
                    Musique_Manuelle_Routine.RemoveAt(counter);
                    Musique_Manuelle_Routine.Insert(counter + 1, buffer);

                }

                dataGridView_Routine.Rows.RemoveAt(index);
                dataGridView_Routine.Rows.Insert(index + 1, row);
                
                dataGridView_Routine.Rows[index + 1].Selected = true;
                
            }
        }

        private void button5_Click(object sender, EventArgs e) // Delete row 
        {
            if (dataGridView_Routine.SelectedRows.Count > 0)
            {
                En_modification = true;

                int index = dataGridView_Routine.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView_Routine.Rows[index];

                if ((int)row.Cells[0].Value == 0)
                {
                    int counter = 0;
                    for (int i = 0; i < index; i++)
                    {
                        if ((int)dataGridView_Routine.Rows[i].Cells[0].Value == 0)
                            counter++;

                    }

                    Musique_Manuelle_Routine.RemoveAt(counter);

                }

                dataGridView_Routine.Rows.RemoveAt(index);

            }

        }

        private void dataGridView_Routine_SelectionChanged(object sender, EventArgs e)
        {
            lst_Musique_Manuelle_View.Items.Clear();

            if (dataGridView_Routine.SelectedRows.Count > 0 && dataGridView_Routine.RowCount > 0)
            {
                int index = dataGridView_Routine.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView_Routine.Rows[index];

                if ((int)row.Cells[0].Value == 0)
                {
                    int counter = 0;
                    for (int i = 0; i < index; i++)
                    {
                        if ((int)dataGridView_Routine.Rows[i].Cells[0].Value == 0)
                            counter++;

                    }

                    foreach(string m in Musique_Manuelle_Routine[counter])
                    {
                        lst_Musique_Manuelle_View.Items.Add(m);
                    }
                    

                }
                else
                {
                    lst_Musique_Manuelle_View.Items.Add(row.Cells[2].Value.ToString() + " " + row.Cells[1].Value.ToString() + " aléatoires");
                }
                
            }
        }

        private void cmb_routine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (routine_name != "new" || !En_modification)
                dataGridView_Routine.Rows.Clear();
            else
            {
                DialogResult res = MessageBox.Show("Voulez-vous enregistrer la playlist en cour ?", "", MessageBoxButtons.YesNoCancel);

                switch (res)
                {
                    case DialogResult.Yes:
                        if (Save_Routine() != 1)
                            return;
                        dataGridView_Routine.Rows.Clear();
                        break;
                    case DialogResult.No:
                        dataGridView_Routine.Rows.Clear();
                        break;
                    case DialogResult.Cancel:
                        if (routine_name != "new")
                            cmb_routine.SelectedItem = routine_name;
                        return;
                    default:
                        return;
                }
            }

            if(cmb_routine.SelectedIndex != -1)
            {
                Load_Routine_Data(cmb_routine.Text);

                routine_name = cmb_routine.Text;

                En_modification = false;

                afficher_modif_rout(true);
                btn_Suppr_Routine.Visible = true;
                lbl_ou.Visible = false;
                btn_nouvelle_routine.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Nouvelle routine
        {
            routine_name = "new";
            afficher_modif_rout(true);
            grp_selec_rout.Enabled = false;
            
        }

        private void btn_Save_Rout_Click(object sender, EventArgs e)
        {
            if (Save_Routine() == 1)
            {
                dataGridView_Routine.Rows.Clear();
                routine_name = "";
                afficher_modif_rout(false);
                grp_selec_rout.Enabled = true;
                btn_Suppr_Routine.Visible = false;
                lbl_ou.Visible = true;
                btn_nouvelle_routine.Visible = true;
                En_modification = false;
                cmb_routine.SelectedIndex = -1;

                Load_Stats();
            }
            
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            if (!En_modification)
                dataGridView_Routine.Rows.Clear();
            else
            {
                DialogResult res = MessageBox.Show("Voulez-vous enregistrer la playlist en cour ?", "", MessageBoxButtons.YesNoCancel);

                switch (res)
                {
                    case DialogResult.Yes:
                        if (Save_Routine() != 1)
                            return;
                        dataGridView_Routine.Rows.Clear();
                        En_modification = false;
                        break;
                    case DialogResult.No:
                        dataGridView_Routine.Rows.Clear();
                        En_modification = false;
                        break;
                    case DialogResult.Cancel:
                        if(routine_name != "new")
                            cmb_routine.SelectedItem = routine_name;
                        return;
                    default:
                        return;
                }
            }

            routine_name = "";
            afficher_modif_rout(false);
            grp_selec_rout.Enabled = true;
            btn_Suppr_Routine.Visible = false;
            lbl_ou.Visible = true;
            btn_nouvelle_routine.Visible = true;
            En_modification = false;
            cmb_routine.SelectedIndex = -1;
        }

        private void btn_Suppr_Routine_Click(object sender, EventArgs e)
        {/*
            connect.Open();
            switch (MessageBox.Show("Etes-vous sure de vouloir supprimer la routine : " + routine_name + " ?", "", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    OleDbCommand cmd = new OleDbCommand(SQL_Command.Delete_Musique(routine_name), connect);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand(SQL_Command.Delete_Danse(routine_name), connect);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand(SQL_Command.Delete_Routine(routine_name), connect);
                    cmd.ExecuteNonQuery();
                    cmb_routine.Items.Remove(routine_name);
                    MessageBox.Show("La routine (" + routine_name + ") a été supprimée.");
                    break;
                case DialogResult.No:
                    return;
            
            }
            connect.Close();
            routine_name = "";
            afficher_modif_rout(false);
            grp_selec_rout.Enabled = true;
            btn_Suppr_Routine.Visible = false;
            lbl_ou.Visible = true;
            btn_nouvelle_routine.Visible = true;
            En_modification = false;
            cmb_routine.SelectedIndex = -1;
            cmb_routine.Text = "";

            dataGridView_Routine.Rows.Clear();
            
            Load_Stats();*/

        }

        // ============== OPTION ============== //

        // -------------- Fonctions -------------- //

        private void Write_Parametres()
        {
            string str = "";
            char ch = !this.rad_backslash.Checked ? '/' : '\\';
            if (this.rdb_bpm.Checked)
                str = "BPM";
            else if (this.rdb_mpm.Checked)
                str = "MPM";
            using (StreamWriter streamWriter = new StreamWriter("." + Path.DirectorySeparatorChar + "Application.config", false))
            {
                streamWriter.WriteLine("Path=" + this.txt_Rep_Recherche2.Text);
                streamWriter.WriteLine("Sep=" + ch.ToString());
                streamWriter.WriteLine("Unit=" + str);
            }
        }

        private void Write_Parametres(string file)
        {
            string str = "";
            char ch = !this.rad_backslash.Checked ? '/' : '\\';
            if (this.rdb_bpm.Checked)
                str = "BPM";
            else if (this.rdb_mpm.Checked)
                str = "MPM";
            File.Create("." + Path.DirectorySeparatorChar + "Application.config");
            using (StreamWriter streamWriter = new StreamWriter("." + Path.DirectorySeparatorChar + "Application.config", false))
            {
                streamWriter.WriteLine("Path=" + file);
                streamWriter.WriteLine("Sep=" + ch.ToString());
                streamWriter.WriteLine("Unit=" + str);
            }
        }

        private void status_modif(bool activated)
        {
            this.btn_modifier.Visible = !activated;
            this.btn_modif_False.Visible = activated;
            this.btn_modif_Ok.Visible = activated;
            this.btn_modif_Ok.Enabled = activated;
            this.rad_backslash.Enabled = activated;
            this.rad_slash.Enabled = activated;
            this.rdb_bpm.Enabled = activated;
            this.rdb_mpm.Enabled = activated;
            this.rdb_Aucune.Enabled = activated;
            this.pic_folder.Visible = activated;
        }


        // -------------- Events -------------- //
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            this.status_modif(true);
        }

        private void btn_modif_False_Click(object sender, EventArgs e)
        {
            this.Read_Parametres();
            this.status_modif(false);
        }

        private void btn_modif_Ok_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (this.txt_Rep_Recherche2.Text != g.repertoire)
                flag = true;
            this.Write_Parametres();
            this.Read_Parametres();
            this.status_modif(false);

            if (flag)
            {
                this.Enabled = false;

                Chargement fen = new Chargement("Mise à jour des données");
                fen.Show();

                DoWork();

                fen.Close();

                this.Enabled = true;

            }
            else
                this.Load_Stats();
        }

        private void txt_Rep_Recherche2_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_Rep_Recherche2.Text != "")
                this.btn_modif_Ok.Enabled = true;
            else
                this.btn_modif_Ok.Enabled = false;
        }

        private void pic_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txt_Rep_Recherche2.Text = folderBrowserDialog.SelectedPath;
        }

        private void pic_folder_MouseHover(object sender, EventArgs e)
        {
            this.pic_folder.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pic_folder_MouseLeave(object sender, EventArgs e)
        {
            this.pic_folder.BorderStyle = BorderStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView_Routine.SelectedRows.Count > 0)
            {
                Selection_Danse fen = new Selection_Danse(this,Int32.Parse(dataGridView_Routine.SelectedRows[0].Cells[2].Value.ToString()),
                     Int32.Parse(dataGridView_Routine.SelectedRows[0].Cells[3].Value.ToString()),
                    Int32.Parse(dataGridView_Routine.SelectedRows[0].Cells[4].Value.ToString()),
                    dataGridView_Routine.SelectedRows[0].Cells[5].Value.ToString());
                fen.ShowDialog();
            }
        }
    }
}
