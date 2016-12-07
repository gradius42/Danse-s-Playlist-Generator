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
        public Apperçu(string text)
        {
            InitializeComponent();

            richTextBox1.Text = text;
        }

      
    }
}
