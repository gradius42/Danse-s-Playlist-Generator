using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danse_s_Playlist_Generator
{
    public partial class Model_Constructeur : Form
    {
        public Menu mainForm;

        int gListView1LostFocusItem = -1;

        List<List<string>> Musique_Manuelle = new List<List<string>>();
        
        public Model_Constructeur(Form callingForm)
        {/*
            InitializeComponent();

            mainForm = (Menu)callingForm;

            mainForm.Visible = false;

            foreach(string s in mainForm.g.Type_Musique)
            {
                cmb_Danses.Items.Add(s);
            }*/
            
        }

        public void Ajout_Manuel(int position, string style, List<string> Musique)
        {
            // ajoute la nouvelle danse
            string[] arr = new string[6];
            ListViewItem itm;
            arr[0] = "";
            arr[1] = style;
            arr[2] = Musique.Count.ToString();
            arr[3] = "ND";
            arr[4] = "ND";
            arr[5] = "ND";

            itm = new ListViewItem(arr);
            listW_Danse_List2.Items.Add(itm);

            Musique_Manuelle.Add(Musique);
        }

        private void btn_ajouter_danse_Click(object sender, EventArgs e)
        {
            if (cmb_Danses.SelectedIndex != -1)
            {
                // ajoute la nouvelle danse
                string[] arr = new string[6]; ListViewItem itm;
                arr[0] = "";
                arr[1] = cmb_Danses.Text;
                arr[2] = Nup_Nb.Value.ToString();
                arr[3] = Nup_Min.Value.ToString();
                arr[4] = Nup_Max.Value.ToString();

                if (rdb_Aleatoire.Checked)
                    arr[5] = "Aléatoire";
                else if (rdb_Croissant.Checked)
                    arr[5] = "Croissant";
                else
                    arr[5] = "Descroissant";

                itm = new ListViewItem(arr);
                listW_Danse_List2.Items.Add(itm);

            }
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
                else if (listW_Danse_List2.Focused)  // If the selected item has focus
                {
                    // Set the colors to the normal colors for a selected item
                    e.Item.BackColor = SystemColors.Highlight;
                }
            }
            else
            {
                // Set the normal colors for items that are not selected
                e.Item.BackColor = listW_Danse_List2.BackColor;
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
        
        private void btn_music_up_Click(object sender, EventArgs e)
        {
            if (listW_Danse_List2.SelectedIndices[0] > 0)
            {
                int index = listW_Danse_List2.SelectedIndices[0];
                int index_ = index - 1;
                
                //Buffers 
                string[] ligne = { "", listW_Danse_List2.Items[index].SubItems[1].Text, listW_Danse_List2.Items[index].SubItems[2].Text, listW_Danse_List2.Items[index].SubItems[3].Text, listW_Danse_List2.Items[index].SubItems[4].Text, listW_Danse_List2.Items[index].SubItems[5].Text };
                string[] ligne_ = { "", listW_Danse_List2.Items[index_].SubItems[1].Text, listW_Danse_List2.Items[index_].SubItems[2].Text, listW_Danse_List2.Items[index_].SubItems[3].Text, listW_Danse_List2.Items[index_].SubItems[4].Text, listW_Danse_List2.Items[index_].SubItems[5].Text };

                ListViewItem item = listW_Danse_List2.Items[index];
                item.SubItems[0].Text = "";
                item.SubItems[1].Text = ligne_[1];
                item.SubItems[2].Text = ligne_[2];
                item.SubItems[3].Text = ligne_[3];
                item.SubItems[4].Text = ligne_[4];
                item.SubItems[5].Text = ligne_[5];

                listW_Danse_List2.Items[index] = item;
                listW_Danse_List2.Items[index].Selected = false;

                ListViewItem item_ = listW_Danse_List2.Items[index_];
                item_.SubItems[0].Text = "";
                item_.SubItems[1].Text = ligne[1];
                item_.SubItems[2].Text = ligne[2];
                item_.SubItems[3].Text = ligne[3];
                item_.SubItems[4].Text = ligne[4];
                item_.SubItems[5].Text = ligne[5];

                listW_Danse_List2.Items[index_] = item_;
                listW_Danse_List2.Items[index_].Selected = true;

                listW_Danse_List2.Focus();
            }
        }

        private void btn_music_down_Click(object sender, EventArgs e)
        {
            if ((listW_Danse_List2.SelectedItems.Count > 0) && (listW_Danse_List2.SelectedIndices[0] < listW_Danse_List2.Items.Count - 1))
            {
                int index = listW_Danse_List2.SelectedIndices[0];
                int index_ = index + 1;

                //Buffers 
                string[] ligne = { "", listW_Danse_List2.Items[index].SubItems[1].Text, listW_Danse_List2.Items[index].SubItems[2].Text, listW_Danse_List2.Items[index].SubItems[3].Text, listW_Danse_List2.Items[index].SubItems[4].Text, listW_Danse_List2.Items[index].SubItems[5].Text };
                string[] ligne_ = { "", listW_Danse_List2.Items[index_].SubItems[1].Text, listW_Danse_List2.Items[index_].SubItems[2].Text, listW_Danse_List2.Items[index_].SubItems[3].Text, listW_Danse_List2.Items[index_].SubItems[4].Text, listW_Danse_List2.Items[index_].SubItems[5].Text };

                ListViewItem item = listW_Danse_List2.Items[index];
                item.SubItems[0].Text = "";
                item.SubItems[1].Text = ligne_[1];
                item.SubItems[2].Text = ligne_[2];
                item.SubItems[3].Text = ligne_[3];
                item.SubItems[4].Text = ligne_[4];
                item.SubItems[5].Text = ligne_[5];

                listW_Danse_List2.Items[index] = item;
                listW_Danse_List2.Items[index].Selected = false;

                ListViewItem item_ = listW_Danse_List2.Items[index_];
                item_.SubItems[0].Text = "";
                item_.SubItems[1].Text = ligne[1];
                item_.SubItems[2].Text = ligne[2];
                item_.SubItems[3].Text = ligne[3];
                item_.SubItems[4].Text = ligne[4];
                item_.SubItems[5].Text = ligne[5];

                listW_Danse_List2.Items[index_] = item_;
                listW_Danse_List2.Items[index_].Selected = true;

                listW_Danse_List2.Focus();
            }
        }

        private void btn_delete_danse_Click(object sender, EventArgs e)
        {
            int index_danse_selected = listW_Danse_List2.SelectedIndices[0];
            if (index_danse_selected != -1)
            {
                if(listW_Danse_List2.Items[index_danse_selected].SubItems[3].Text == "ND")
                {
                    int counter = 0;
                    for(int i = 0; i < index_danse_selected - 1; i++)
                    {
                        if(listW_Danse_List2.Items[i].SubItems[3].Text == "ND")
                            counter++;
                        
                    }

                    Musique_Manuelle.RemoveAt(counter);
                }

                listW_Danse_List2.Items.RemoveAt(index_danse_selected);
            }
        }

        private void Model_Constructeur_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listW_Danse_List2.Items.Count > 0)
            {
                // génère le texte de la playlist
                string text = "";
                int counter = 0;
                for(int i = 0; i < listW_Danse_List2.Items.Count; i++)
                {

                    if(listW_Danse_List2.Items[i].SubItems[3].Text != "ND")
                    {
                        text += "#Danse\n" +
                            listW_Danse_List2.Items[i].SubItems[1].Text + ";" +
                            listW_Danse_List2.Items[i].SubItems[2].Text + ";" +
                            listW_Danse_List2.Items[i].SubItems[3].Text + ";" +
                            listW_Danse_List2.Items[i].SubItems[4].Text + ";" +
                            listW_Danse_List2.Items[i].SubItems[5].Text + "\n";
                    }
                    else
                    {
                        text += "#Musique\n" +
                            listW_Danse_List2.Items[i].SubItems[1].Text + "\n";

                        foreach (string m in Musique_Manuelle[counter])
                        {
                            text += m + "\n";
                        }

                        counter++;
                    }

                    text += "#Fin\n";

                }
                
                SaveFileDialog save = new SaveFileDialog();
                DialogResult result1 = save.ShowDialog();
                
                if (result1 == DialogResult.OK)
                {
                    // chemin
                    string file = save.FileName + ".rtnPlay";
                    
                    File.WriteAllText(file, text);

                    MessageBox.Show("Sauvegarde Réussie !");

                    this.Close();

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Selection_Manuelle fen = new Selection_Manuelle(this, mainForm.g.Type_Musique, mainForm.g.Musique_Founded, 2, null);
            //fen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
