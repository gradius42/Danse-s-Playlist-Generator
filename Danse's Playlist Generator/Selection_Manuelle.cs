using System;
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
    public partial class Selection_Manuelle : Form
    {
        Application_Fen mainForm;

        private List<List<string>> Musiques_List;

        private List<string> Danse_List;

        private int Mode_Ouverture;

        public Selection_Manuelle(Application_Fen callingForm, List<string> Musique_type, List<List<string>> Musiques,int Mode_ouverture,List<string> List_Danse)
        {
            InitializeComponent();

            Mode_Ouverture = Mode_ouverture;

            mainForm = callingForm;

            if (Mode_Ouverture == 1)
            {                
                Danse_List = List_Danse;
            }
            else if (Mode_Ouverture == 2)
            {
                label1.Visible = false;
                cmb_list_Ajout.Visible = false;
            }

            Musiques_List = Musiques;

            foreach(string s in Musique_type)
            {
                cmb_Danses.Items.Add(s);
            }
            
        }
   
        private void cmb_Danses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cmb_list_Ajout.Items.Clear();

            int index = cmb_Danses.SelectedIndex;

            foreach(string m in Musiques_List[index])
            {
                listBox1.Items.Add(m);
            }
            
            
            if( Mode_Ouverture == 1)
            {
                int i = 1;
                string danse = cmb_Danses.Text;
                foreach (string d in Danse_List)
                {
                    if (d == danse)
                    {
                        cmb_list_Ajout.Items.Add("N°" + i);
                        i++;
                    }

                }
                cmb_list_Ajout.Items.Add("Nouvelle");
                cmb_list_Ajout.SelectedIndex = cmb_list_Ajout.Items.Count - 1;
            }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                List<string> Musiques = new List<string>();

                foreach (int i in listBox1.SelectedIndices)
                {
                    Musiques.Add(listBox1.Items[i].ToString());
                }

                if (Mode_Ouverture == 1)
                {
                    int pos;
                    if (cmb_list_Ajout.Text == "Nouvelle")
                        pos = -1;
                    else
                        pos = Int32.Parse(cmb_list_Ajout.Text.Substring(2));

                    mainForm.Ajout_Manuel(pos, cmb_Danses.SelectedItem.ToString(), Musiques);

                    
                }
                else if (Mode_Ouverture == 2)
                {
                    mainForm.Ajout_Manuel_Rout(cmb_Danses.SelectedItem.ToString(), Musiques);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de sélectionner au moins une musique à ajouter");
            }
           
        }

        
    }
}
