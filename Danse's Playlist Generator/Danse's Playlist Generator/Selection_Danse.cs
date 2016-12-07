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

        private Menu mainForm;
        
        public Selection_Danse( List<string> Styles , Form callingForm)
        {
            InitializeComponent();

            mainForm = callingForm as Menu;

            int numb = 1;

            foreach( string danse in Styles)
            {
                cmb_Danses.Items.Add(new Item(danse, numb));

                numb++;
            }
                      
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if(txt_bpm_min.Text != "" && txt_bpm_max.Text != "" && cmb_Danses.Text != "" && txt_number.Text != "")
            {
                mainForm.Generate_music_list(Int32.Parse(txt_bpm_min.Text), Int32.Parse(txt_bpm_max.Text), cmb_Danses.Text, Int32.Parse(txt_number.Text));

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

        private void Selection_Danse_Load(object sender, EventArgs e)
        {

        }
    }
}
