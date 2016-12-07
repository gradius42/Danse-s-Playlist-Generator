using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Danse_s_Playlist_Generator
{
    public partial class Application_Fen : Form
    {
        public Application_Fen()
        {
            InitializeComponent();
        }
        
        // Globals

        public static Globals g = new Globals();
        public static SQL_Command SQL = new SQL_Command();
        public int gListView1LostFocusItem = -1;
        public OleDbConnection connect;

        // Global Classe

        public class MusiqueComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                int bpm1 = Find_BPM(x, g.Speed_Unit);
                int bpm2 = Find_BPM(y, g.Speed_Unit);
                if (bpm1 < bpm2)
                    return -1;
                return bpm1 > bpm2 ? 1 : 0;
            }
        }

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

        // Global Functions
        
        public static bool IsNumeric(object Expression)
        {
            int result;
            return int.TryParse(Convert.ToString(Expression), NumberStyles.Any, (IFormatProvider)NumberFormatInfo.InvariantInfo, out result);
        }

        public static int Find_BPM(string music, string unit)
        {
            if (unit == "")
                return -1;

            string[] strArray = music.Split(' ');

            string s = strArray[0];

            string upper = strArray[1].ToUpper();

            for (int index = 1; !upper.Equals(unit) && index < strArray.Length - 2; upper = strArray[index].ToUpper())
            {
                s = strArray[index];
                ++index;
            }

            if (upper == unit && IsNumeric((object)s))
                return int.Parse(s);

            return -1;
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

        // ============== ACCUEIL ============== //

        // -------------- Fonctions -------------- //

        private void Open_Connection()
        {
            this.connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\PlayListGenerator.MDB");
            try
            {
                this.connect.Open();
                this.connect.Close();
            }
            catch
            {
                int num = (int)MessageBox.Show("Base de donnée introuvable.");
                this.Close();
            }
        }

        private void Load_Os_Type()
        {
            if (Directory.GetCurrentDirectory().Contains("/"))
                g.sep = '/';
            else
                g.sep = '\\';
        }

        private void Read_Parametres()
        {
            if (!File.Exists("." + g.sep.ToString() + "Application.config"))
                return;

            using (StreamReader streamReader = new StreamReader("." + g.sep.ToString() + "Application.config"))
            {

                string str1;

                while ((str1 = streamReader.ReadLine()) != null)
                {

                    switch (str1.Split('=')[0])
                    {
                        case "Path":

                            g.repertoire = str1.Split('=')[1];
                            this.txt_Rep_Recherche.Text = str1.Split('=')[1];
                            this.txt_Rep_Recherche2.Text = str1.Split('=')[1];

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

            string path = path_files;

            g.repertoire = path;
            g.Musique_playlist.Clear();
            g.Musique_Added.Clear();
            this.cmb_Danses.Items.Clear();
            this.cmb_Danses_r.Items.Clear();
            g.Type_Musique.Clear();
            g.Musique_Founded.Clear();
            
            this.txt_Rep_Recherche.Text = path;

            string[] directories = Directory.GetDirectories(path, "*");

            try
            {
                int num = 0;

                foreach (string str1 in directories)
                {
                    char chArray = g.sep;

                    string name = ((IEnumerable<string>)str1.Split(chArray)).Last<string>();

                    g.Type_Musique.Add(name);
                    this.cmb_Danses.Items.Add(new Item(name, num));
                    this.cmb_Danses_r.Items.Add(new Item(name, num));
                    ++num;

                    List<string> list = ((IEnumerable<string>)Directory.GetFiles(g.repertoire + g.sep.ToString() + name + g.sep.ToString())).ToList<string>();

                    List<string> stringList = new List<string>();

                    foreach (string str2 in list)
                        stringList.Add(((IEnumerable<string>)str2.Split(g.sep)).Last<string>());

                    g.Musique_Founded.Add(stringList);
                }
            }
            catch
            {
                int num = (int)MessageBox.Show("Mauvais répertoire");
            }

            this.Load_Stats();
            this.Fill_three_view();

        }

        private void Fill_three_view()
        {
            this.treeView1.Nodes.Clear();

            for (int index = 0; index < g.Type_Musique.Count; ++index)
            {

                this.treeView1.PathSeparator = g.sep.ToString();
                this.treeView1.Nodes.Add(g.Type_Musique[index] + " (" + (object)g.Musique_Founded[index].Count + ")");

                foreach (string text in g.Musique_Founded[index])
                    this.treeView1.Nodes[index].Nodes.Add(text);

            }
        }

        private void Load_Stats()
        {
            if (g.Type_Musique.Count == 0)
                this.lbl_danse_f.Text = "Aucun style de danse referencée.";
            else if (g.Type_Musique.Count == 1)
                this.lbl_danse_f.Text = g.Type_Musique.Count.ToString() + " style de danse referencée.";
            else
                this.lbl_danse_f.Text = g.Type_Musique.Count.ToString() + " styles de danse referencées.";

            int num1 = 0;
            int num2 = 0;

            for (int index = 0; index < g.Musique_Founded.Count; ++index)
            {

                num1 += g.Musique_Founded[index].Count;

                foreach (string music in g.Musique_Founded[index])
                {
                    if (Find_BPM(music, g.Speed_Unit) != -1)
                        ++num2;
                }

            }

            if (num1 == 0)
                this.lbl_music_f.Text = "Aucune musique trouvée.";
            else if (num1 == 1)
                this.lbl_music_f.Text = num1.ToString() + " musique trouvée.";
            else
                this.lbl_music_f.Text = num1.ToString() + " musiques trouvées.";

            if (num2 == 0)
                this.lbl_music_f_r.Text = "Aucune musique, avec rythme, trouvée.";
            else if (num2 == 1)
                this.lbl_music_f_r.Text = num2.ToString() + " musique, avec rythme, trouvée.";
            else
                this.lbl_music_f_r.Text = num2.ToString() + " musiques avec rythme trouvées.";

            this.connect.Open();

            int num3 = (int)new OleDbCommand(SQL.Count_Routine(), this.connect).ExecuteScalar();
            switch (num3)
            {
                case 0:
                    this.lbl_routine_f.Text = "Aucune routine de danse disponible.";
                    break;
                case 1:
                    this.lbl_routine_f.Text = num3.ToString() + " routine de danse disponible.";
                    break;
                default:
                    this.lbl_routine_f.Text = num3.ToString() + " routines de danse disponibles.";
                    break;
            }

            if ((int)new OleDbCommand(SQL.Count_Stats(), this.connect).ExecuteScalar() == 0)
            {
                new OleDbCommand(SQL.Insert_Number_Playlist(), this.connect).ExecuteNonQuery();
                this.lbl_playlist.Text = "Aucune playlist générée.";
            }
            else
            {
                int num4 = (int)new OleDbCommand(SQL.Get_Number_Playlist(), this.connect).ExecuteScalar();
                switch (num4)
                {
                    case 0:
                        this.lbl_playlist.Text = "Aucune playlist générée.";
                        break;
                    case 1:
                        this.lbl_playlist.Text = num4.ToString() + " playlist générée.";
                        break;
                    default:
                        this.lbl_playlist.Text = num4.ToString() + " playlists générées.";
                        break;
                }
            }
            this.connect.Close();
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
            connect.Open();

            OleDbCommand cmd = new OleDbCommand(SQL.Get_Routine(),connect);

            OleDbDataReader reader = cmd.ExecuteReader() ;

            while (reader.Read())
            {
                cmb_routine.Items.Add(reader[0].ToString());
            }

            reader.Close();
            connect.Close();

            //Col_Data_Danse.DataSource = g.Type_Musique;
            //Col_Data_Tri.DataSource = new List<string> { "Aléatoire","Croissant","Descroissant"};
        }

        // -------------- Events -------------- //

        private void Application_Load(object sender, EventArgs e)
        {
            this.Load_Os_Type();

            this.Open_Connection();

            this.Read_Parametres();

            if (g.repertoire != "")
                this.Load_Files(g.repertoire);
            else
                this.Load_Stats();

            this.status_modif(false);

            Load_Routine();
        }

        private void btn_folder_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            this.Load_Files(folderBrowserDialog.SelectedPath);
        }

        // ============== Playlist ============== //

        // -------------- Fonctions -------------- //

        public void Generate_music_list(int Min, int Max, string danse_file, int number)
        {
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
                    int bpm = Find_BPM(music, g.Speed_Unit);
                    if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                        stringList1.Add(music);
                }
                catch
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
                    g.Musique_Added.Add(stringList1[index2]);
                    stringList1.RemoveAt(index2);
                }

                if (stringList1.Count == 0 && num3 < number)
                {
                    int num4 = (int)MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist./n Seulement " + (object)num3 + " musique(s) ont été ajoutée(s).");
                }
                g.Musique_playlist.Add(stringList2);

            }
            else
            {
                int num5 = (int)MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist.");
            }
        }

        public void Add_Music_to_Selection(int Min, int Max)
        {
            if (this.listW_Danse_List.SelectedItems.Count > 0)
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
                    try
                    {
                        int bpm = Find_BPM(music, g.Speed_Unit);
                        if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                            stringList1.Add(music);
                    }
                    catch
                    {
                    }
                }
                if (stringList1.Count > 0)
                {
                    List<string> stringList2 = g.Musique_playlist[index1];
                    int num3 = 0;
                    if (stringList1.Count > 0)
                    {
                        int index3 = random.Next(0, stringList1.Count - 1);
                        stringList2.Add(stringList1[index3]);
                        g.Musique_Added.Add(stringList1[index3]);
                        stringList1.RemoveAt(index3);
                        int num4 = num3 + 1;
                    }
                    else
                    {
                        int num5 = (int)MessageBox.Show("Toutes les musiques de ce style et dans cette porté sont déjà dans la playlist./n Seulement " + (object)num3 + " musique(s) ont été ajoutée(s).");
                    }
                    g.Musique_playlist[index1] = stringList2;
                }
            }
            else
            {
                int num = (int)MessageBox.Show("Tout les musiques de ce style et dans cette porté sont déjà dans la playlist.");
            }
            this.Maj_Liste_Musique();
        }

        public void Modify_Music_Selected(int Min, int Max)
        {
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
            List<int> intList = new List<int>();
            for (int index3 = 0; index3 < this.list_Musiques.SelectedItems.Count; ++index3)
            {
                intList.Add(this.list_Musiques.SelectedIndices[index3]);
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
                    int bpm = Find_BPM(music, g.Speed_Unit);
                    if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                        stringList1.Add(music);
                }
                catch
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
                    g.Musique_Added.Add(stringList1[index4]);
                    stringList1.RemoveAt(index4);
                }
            }
            g.Musique_playlist[index1] = stringList2;
            this.Maj_Liste_Musique();
            foreach (int index3 in intList)
                this.list_Musiques.SetSelected(index3, true);
        }

        public void Modify_All_Music(int Min, int Max)
        {
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
                g.Musique_Added.Remove(str);
            foreach (string str in g.Musique_Founded[index2])
            {
                char[] chArray = new char[1]
                {
          g.sep
                };
                string music = ((IEnumerable<string>)str.Split(chArray)).Last<string>();
                try
                {
                    int bpm = Find_BPM(music, g.Speed_Unit);
                    if (!g.Musique_Added.Contains(music) && (num1 <= bpm && num2 >= bpm || bpm == -1))
                        stringList1.Add(music);
                }
                catch
                {
                }
            }
            if (stringList1.Count > 0)
            {
                for (int index3 = 0; index3 < stringList2.Count; ++index3)
                {
                    int index4 = random.Next(0, stringList1.Count - 1);
                    stringList2[index3] = stringList1[index4];
                    g.Musique_Added.Add(stringList1[index4]);
                    stringList1.RemoveAt(index4);
                }
            }
            this.Maj_Liste_Musique();
            g.Musique_playlist[index1] = stringList2;
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
            this.list_Musiques.Items.Clear();
            if (this.listW_Danse_List.SelectedIndices.Count <= 0)
                return;
            foreach (object obj in g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]])
                this.list_Musiques.Items.Add(obj);
        }

        public void Ajout_Manuel(int position, string style, List<string> Musique)
        {
            if (position == -1)
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
                    g.Musique_Added.Add(str);
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
                                stringList.Add(str);
                            g.Musique_playlist[index] = stringList;
                            index = this.listW_Danse_List.Items.Count;
                        }
                    }
                }
            }
            this.btn_save.Visible = true;
            this.btn_reset.Visible = true;
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
        {
            int index = this.listW_Danse_List.SelectedIndices[0];
            if (index != -1)
            {
                this.listW_Danse_List.Items.RemoveAt(index);
                foreach (string str in g.Musique_playlist[index])
                    g.Musique_Added.Remove(str);
                g.Musique_playlist.RemoveAt(index);
                this.Maj_Liste_Musique();
            }
            if (this.listW_Danse_List.Items.Count != 0)
                return;
            this.btn_save.Visible = false;
            this.btn_reset.Visible = false;
        }

        private void btn_delete_selection_Click(object sender, EventArgs e)
        {
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
            this.Maj_Liste_Musique();
        }

        private void btn_music_up_Click(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedIndices[0] <= 0)
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
            this.listW_Danse_List.Focus();
        }

        private void btn_music_down_Click(object sender, EventArgs e)
        {
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
            this.listW_Danse_List.Focus();
        }

        private void btn_selection_up_Click(object sender, EventArgs e)
        {
            if (this.list_Musiques.SelectedIndex <= 0)
                return;
            List<string> stringList = g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]];
            string str = stringList[this.list_Musiques.SelectedIndex];
            stringList[this.list_Musiques.SelectedIndex] = stringList[this.list_Musiques.SelectedIndex - 1];
            stringList[this.list_Musiques.SelectedIndex - 1] = str;
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]] = stringList;
            int selectedIndex = this.list_Musiques.SelectedIndex;
            this.Maj_Liste_Musique();
            this.list_Musiques.SelectedIndex = selectedIndex - 1;
        }

        private void btn_selection_down_Click(object sender, EventArgs e)
        {
            if (this.list_Musiques.SelectedIndex == -1 || this.list_Musiques.SelectedIndex >= this.list_Musiques.Items.Count - 1)
                return;
            List<string> stringList = g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]];
            string str = stringList[this.list_Musiques.SelectedIndex];
            stringList[this.list_Musiques.SelectedIndex] = stringList[this.list_Musiques.SelectedIndex + 1];
            stringList[this.list_Musiques.SelectedIndex + 1] = str;
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]] = stringList;
            int selectedIndex = this.list_Musiques.SelectedIndex;
            this.Maj_Liste_Musique();
            this.list_Musiques.SelectedIndex = selectedIndex + 1;
        }

        private void btn_musique_asc_Click(object sender, EventArgs e)
        {
            IComparer<string> comparer = (IComparer<string>)new MusiqueComparer();
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]].Sort(comparer);
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]].Reverse();
            this.Maj_Liste_Musique();
        }

        private void btn_music_desc_Click(object sender, EventArgs e)
        {
            IComparer<string> comparer = (IComparer<string>)new MusiqueComparer();
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]].Sort(comparer);
            this.Maj_Liste_Musique();
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            if (this.listW_Danse_List.SelectedItems.Count <= 0)
                return;
            List<string> stringList = g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]];
            this.Shuffle<string>((IList<string>)stringList);
            this.Shuffle<string>((IList<string>)stringList);
            this.Shuffle<string>((IList<string>)stringList);
            g.Musique_playlist[this.listW_Danse_List.SelectedIndices[0]] = stringList;
            this.Maj_Liste_Musique();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
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
                    Apperçu apperçu = new Apperçu(g.text);
                    int num1 = (int)apperçu.ShowDialog();
                    if (apperçu.DialogResult == DialogResult.OK)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog.FileName + ".m3u", g.text);
                            int num2 = (int)MessageBox.Show("Sauvegarde Réussie !");
                        }
                        break;
                    }
                    break;
                case DialogResult.No:
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName + ".m3u", g.text);
                        int num2 = (int)MessageBox.Show("Sauvegarde Réussie !");
                    }
                    break;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sure de vouloir supprimer la playlist ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.listW_Danse_List.Items.Clear();
            this.list_Musiques.Items.Clear();
            g.Musique_playlist.Clear();
            g.Musique_Added.Clear();
            this.btn_reset.Visible = false;
            this.btn_save.Visible = false;
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
        {
            List<string> List_Danse = new List<string>();
            for (int index = 0; index < this.listW_Danse_List.Items.Count; ++index)
                List_Danse.Add(this.listW_Danse_List.Items[index].SubItems[1].Text);
            int num = (int)new Selection_Manuelle(this, g.Type_Musique, g.Musique_Founded, 1, List_Danse).ShowDialog();
        }

        private void btn_new_rout_Click(object sender, EventArgs e)
        {
            int num = (int)new Model_Constructeur((Form)this).ShowDialog();
        }

        private void btn_load_rout_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.rtnPlay)|*.rtnPlay";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string[] strArray1 = File.ReadAllLines(openFileDialog.FileName);
            List<string> stringList1 = new List<string>();
            string str1 = strArray1[0];
            for (int index = 1; index < strArray1.Length; ++index)
            {
                if ((int)strArray1[index][0] == 35)
                    str1 = strArray1[index];
                else if (str1 == "#Danse")
                {
                    string[] strArray2 = strArray1[index].Split(';');
                    this.Generate_music_list(int.Parse(strArray2[2]), int.Parse(strArray2[3]), strArray2[0], int.Parse(strArray2[1]));
                    List<string> stringList2 = g.Musique_playlist.Last<List<string>>();
                    IComparer<string> comparer = (IComparer<string>)new MusiqueComparer();
                    string str2 = strArray2[4];
                    if (!(str2 == "Descroissant"))
                    {
                        if (str2 == "Croissant")
                            stringList2.Sort(comparer);
                    }
                    else
                    {
                        stringList2.Sort(comparer);
                        stringList2.Reverse();
                    }
                }
                else if (str1 == "#Musique")
                {
                    if (strArray1[index - 1] == "#Musique")
                        this.listW_Danse_List.Items.Add(new ListViewItem(new string[4]
                        {
              "",
              strArray1[index],
              "ND",
              "ND"
                        }));
                    else
                        stringList1.Add(strArray1[index]);
                    if ((int)strArray1[index + 1][0] == 35)
                    {
                        g.Musique_playlist.Add(stringList1);
                        stringList1 = new List<string>();
                    }
                }
            }
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
        {
            
        }

        public int Save_Routine()
        {
            connect.Open();

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

                cmb_Danses_r.Items.Add(routine_name);

                OleDbCommand cmd2 = new OleDbCommand(SQL.Insert_Routine(routine_name, ""), connect);
                cmd2.ExecuteNonQuery();

                

            }

            OleDbCommand cmd = new OleDbCommand(SQL.Delete_Musique(routine_name), connect);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand(SQL.Delete_Danse(routine_name), connect);
            cmd.ExecuteNonQuery();

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

                    cmd = new OleDbCommand(SQL.Insert_Danse(routine_name, // routine
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
                    cmd = new OleDbCommand(SQL.Insert_Danse(routine_name, // routine
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
                        cmd = new OleDbCommand(SQL.Insert_Musique(routine_name,
                            i,
                            j,
                            Musique_Manuelle_Routine[counter][j],
                            j)
                            , connect);
                        cmd.ExecuteNonQuery();
                    }

                    counter++;
                }

            }
            connect.Close();

            routine_name = "";

            MessageBox.Show("Routine enregistré.");

            return 1;
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
        {
            Selection_Manuelle fen = new Selection_Manuelle(this, g.Type_Musique, g.Musique_Founded, 2, null);
            fen.ShowDialog();
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
                grp_selec_rout.Enabled = false;
                btn_Suppr_Routine.Visible = false;
                lbl_ou.Visible = true;
                btn_nouvelle_routine.Visible = true;
                En_modification = false;
                cmb_routine.SelectedIndex = -1;
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
            grp_selec_rout.Enabled = false;
            btn_Suppr_Routine.Visible = false;
            lbl_ou.Visible = true;
            btn_nouvelle_routine.Visible = true;
            En_modification = false;
            cmb_routine.SelectedIndex = -1;
        }

        private void btn_Suppr_Routine_Click(object sender, EventArgs e)
        {
            connect.Open();
            switch (MessageBox.Show("Etes-vous sure de vouloir supprimer la routine : " + routine_name + " ?", "", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    OleDbCommand cmd = new OleDbCommand(SQL.Delete_Musique(routine_name), connect);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand(SQL.Delete_Danse(routine_name), connect);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand(SQL.Delete_Routine(routine_name), connect);
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

        }

        // ============== ACCUEIL ============== //

        // -------------- Fonctions -------------- //

        private void Write_Parametres()
        {
            string str = "";
            char ch = !this.rad_backslash.Checked ? '/' : '\\';
            if (this.rdb_bpm.Checked)
                str = "BPM";
            else if (this.rdb_mpm.Checked)
                str = "MPM";
            using (StreamWriter streamWriter = new StreamWriter("." + g.sep.ToString() + "Application.config", false))
            {
                streamWriter.WriteLine("Path=" + this.txt_Rep_Recherche2.Text);
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
                this.Load_Files(this.txt_Rep_Recherche2.Text);
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

        
    }
}
