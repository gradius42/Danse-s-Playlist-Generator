using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danse_s_Playlist_Generator
{
    public partial class Chargement : Form
    {
        public Chargement(string text)
        {
            InitializeComponent();
            
        }

        public volatile bool _shouldStop;

        public void fonction(Label label1) {

            while (!this._shouldStop)
            {
                label1.Text = "Chargement ...  \\";

                this.Update();

                Thread.Sleep(250);

                label1.Text = "Chargement .... |";

                this.Update();

                Thread.Sleep(250);

                label1.Text = "Chargement .    /";

                this.Update();

                Thread.Sleep(250);

                label1.Text = "Chargement ..   -";

                this.Update();

                Thread.Sleep(250);
            }

            this.Close();

        }

        public void RequestStop()
        {
            _shouldStop = true;
        }

        private void Chargement_Load(object sender, EventArgs e) { 
        
            //Thread t = new Thread(() => fonction(this.label1));
            //t.Start();
        }
    }
}
