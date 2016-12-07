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
    public partial class Routine_Loader : Form
    {
        Application_Fen mother;

        public Routine_Loader(Application_Fen m ,List<string> Routines)
        {
            InitializeComponent();

            mother = m;

            foreach(string s in Routines)
            {
                cmb_routine.Items.Add(s);
            }
        }

        private void btn_delete_danse_Click(object sender, EventArgs e)
        {
            if( list_Musiques.SelectedIndex != -1)
            {
                int position = list_Musiques.SelectedIndex;
                list_Musiques.Items.RemoveAt(position);

                if (list_Musiques.Items.Count > position)
                    list_Musiques.SelectedIndex = position;
                
            }
        }

        private void btn_music_up_Click(object sender, EventArgs e)
        {
            if (list_Musiques.SelectedIndex != -1)
            {
                string buffer = list_Musiques.SelectedItem.ToString();
                int position = list_Musiques.SelectedIndex;
                list_Musiques.Items.RemoveAt(list_Musiques.SelectedIndex);
                list_Musiques.Items.Insert( position - 1,buffer);
            }
        }

        private void btn_music_down_Click(object sender, EventArgs e)
        {
            if (list_Musiques.SelectedIndex != -1)
            {
                string buffer = list_Musiques.SelectedItem.ToString();
                int position = list_Musiques.SelectedIndex;
                list_Musiques.Items.RemoveAt(list_Musiques.SelectedIndex);
                list_Musiques.Items.Insert(position + 1, buffer);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            List<string> routine = new List<string>();

            foreach (string s in list_Musiques.Items)
                routine.Add(s);
            
            if (radioButton1.Checked)
                mother.Add_Routine_to_Playlist(routine, (int)nup_nombre.Value, new TimeSpan(0, 0, 0));
            else
                mother.Add_Routine_to_Playlist(routine, -1, new TimeSpan((int)nup_h.Value, (int)nup_m.Value, (int)nup_s.Value));

            this.Close();
        }

        private void btn_ajouter_danse_r_Click(object sender, EventArgs e)
        {
            if (cmb_routine.SelectedIndex != -1)
                list_Musiques.Items.Add(cmb_routine.Items[cmb_routine.SelectedIndex].ToString());
        }

        private void cmb_routine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_routine.SelectedIndex != -1)
                list_Musiques.Items.Add(cmb_routine.Items[cmb_routine.SelectedIndex].ToString());
        }
    }
}
