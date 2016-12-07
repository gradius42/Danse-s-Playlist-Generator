using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danse_s_Playlist_Generator
{
    public partial class Initialisation : Form
    {
        private char Sep;

        public Initialisation(char sep )
        {
            InitializeComponent();

            Sep = sep;

            if (sep == '/')
                rad_slash.Checked = true;
            else
                rad_backslash.Checked = true;
        }

        private void pic_folder_Click(object sender, EventArgs e)
        {
            //Lecture du repertoire de musique
            FolderBrowserDialog Folder = new FolderBrowserDialog();
            DialogResult result1 = Folder.ShowDialog();
            
            if (result1 == DialogResult.OK)
            {
                txt_Rep_Recherche.Text = Folder.SelectedPath;
            }

        }

        private void pic_folder_MouseHover(object sender, EventArgs e)
        {
            pic_folder.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pic_folder_MouseLeave(object sender, EventArgs e)
        {
            pic_folder.BorderStyle = BorderStyle.None;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Unit = "";
            char s;

            if (rad_backslash.Checked)
            {
                s = '\\';
            }
            else
                s = '/';

            if (rdb_bpm.Checked)
                Unit = "BPM";
            else if (rdb_mpm.Checked)
                Unit = "MPM";

            using (StreamWriter sw = File.CreateText("."+Sep+ "Application.config"))
            {
                sw.WriteLine("Path=" + txt_Rep_Recherche.Text);
                sw.WriteLine("Sep="+s);
                sw.WriteLine("Unit="+Unit);
            }

            Application_Fen fen = new Application_Fen();

            //fen.Show();
            this.Close();
        }

        private void txt_Rep_Recherche_TextChanged(object sender, EventArgs e)
        {
            if (txt_Rep_Recherche.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
                btn_save.Enabled = false;
        }
    }
}
