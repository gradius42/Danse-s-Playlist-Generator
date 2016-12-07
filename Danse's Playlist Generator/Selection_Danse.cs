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
    public partial class Selection_Danse : Form
    {
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

        private Application_Fen mainForm;
        
        public Selection_Danse( Form callingForm,int nb, int min, int max, string tri)
        {
            InitializeComponent();

            mainForm = callingForm as Application_Fen;

            txt_number.Text = nb.ToString();
            txt_bpm_min.Text = min.ToString();
            txt_bpm_max.Text = max.ToString();

            switch (tri)
            {
                case "Croissant":
                    rdb_Croissant.Checked = true;
                    break;
                case "Descroissant":
                     rdb_Descroissant.Checked = true;
                    break;
                default :
                    rdb_Aleatoire.Checked = true;
                    break;
            }
            
                      
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if(txt_bpm_min.Text != "" && txt_bpm_max.Text != ""  && txt_number.Text != "")
            {
                string tri = "Aléatoire";

                if (rdb_Croissant.Checked)
                    tri = "Croissant";
                else if (rdb_Descroissant.Checked)
                    tri = "Descroissant";


                mainForm.modif_danse(txt_number.Text, txt_bpm_min.Text, txt_bpm_max.Text, tri);
                this.Close();
            }
            
        }

        private void txt_number_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
