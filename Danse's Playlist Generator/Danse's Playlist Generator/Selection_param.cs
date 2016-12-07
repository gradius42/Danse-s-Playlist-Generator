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
    public partial class Selection_param : Form
    {
        private Menu mainForm;

        public Selection_param(Form callingForm, int min , int max)
        {
            InitializeComponent();

            mainForm = callingForm as Menu;

            txt_bpm_min.Text = min.ToString() ;
            txt_bpm_max.Text = max.ToString() ;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(txt_bpm_min.Text);
            int max = Int32.Parse(txt_bpm_max.Text);

            if(min > max)
            {
                int buffer = min;
                min = max;
                max = min;
            }

            mainForm.Change_Min_Max(min, max);

            this.Close();
            
        }

        private void txt_bpm_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
