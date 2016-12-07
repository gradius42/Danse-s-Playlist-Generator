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
    public partial class Apperçu : Form
    {
        public Apperçu(string text,bool enregistrement)
        {
            InitializeComponent();

            richTextBox1.Text = text;

            if (!enregistrement)
            {
                btn_reset.Text = "Fermer";
                btn_save.Visible = false;
                richTextBox1.Text = text.Replace(".mp3","");
            }


        }

        
    }
}
