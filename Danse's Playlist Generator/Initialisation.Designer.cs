namespace Danse_s_Playlist_Generator
{
    partial class Initialisation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialisation));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Rep_Recherche = new System.Windows.Forms.TextBox();
            this.pic_folder = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rdb_Aucune = new System.Windows.Forms.RadioButton();
            this.rdb_mpm = new System.Windows.Forms.RadioButton();
            this.rdb_bpm = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rad_slash = new System.Windows.Forms.RadioButton();
            this.rad_backslash = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_folder)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Repertoire de recherche par défaut :";
            // 
            // txt_Rep_Recherche
            // 
            this.txt_Rep_Recherche.Enabled = false;
            this.txt_Rep_Recherche.Location = new System.Drawing.Point(36, 51);
            this.txt_Rep_Recherche.Name = "txt_Rep_Recherche";
            this.txt_Rep_Recherche.ReadOnly = true;
            this.txt_Rep_Recherche.Size = new System.Drawing.Size(316, 25);
            this.txt_Rep_Recherche.TabIndex = 10;
            this.txt_Rep_Recherche.TextChanged += new System.EventHandler(this.txt_Rep_Recherche_TextChanged);
            // 
            // pic_folder
            // 
            this.pic_folder.Image = ((System.Drawing.Image)(resources.GetObject("pic_folder.Image")));
            this.pic_folder.Location = new System.Drawing.Point(375, 37);
            this.pic_folder.Name = "pic_folder";
            this.pic_folder.Size = new System.Drawing.Size(45, 39);
            this.pic_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_folder.TabIndex = 12;
            this.pic_folder.TabStop = false;
            this.pic_folder.Click += new System.EventHandler(this.pic_folder_Click);
            this.pic_folder.MouseLeave += new System.EventHandler(this.pic_folder_MouseLeave);
            this.pic_folder.MouseHover += new System.EventHandler(this.pic_folder_MouseHover);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rdb_Aucune);
            this.groupBox8.Controls.Add(this.rdb_mpm);
            this.groupBox8.Controls.Add(this.rdb_bpm);
            this.groupBox8.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(14, 247);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(440, 145);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Unité de tri :";
            // 
            // rdb_Aucune
            // 
            this.rdb_Aucune.AutoSize = true;
            this.rdb_Aucune.Location = new System.Drawing.Point(42, 108);
            this.rdb_Aucune.Name = "rdb_Aucune";
            this.rdb_Aucune.Size = new System.Drawing.Size(148, 21);
            this.rdb_Aucune.TabIndex = 2;
            this.rdb_Aucune.Text = "Aucune (Aléatoire)";
            this.rdb_Aucune.UseVisualStyleBackColor = true;
            // 
            // rdb_mpm
            // 
            this.rdb_mpm.AutoSize = true;
            this.rdb_mpm.Location = new System.Drawing.Point(42, 72);
            this.rdb_mpm.Name = "rdb_mpm";
            this.rdb_mpm.Size = new System.Drawing.Size(196, 21);
            this.rdb_mpm.TabIndex = 1;
            this.rdb_mpm.Text = "Mesure par minute (MPM)";
            this.rdb_mpm.UseVisualStyleBackColor = true;
            // 
            // rdb_bpm
            // 
            this.rdb_bpm.AutoSize = true;
            this.rdb_bpm.Checked = true;
            this.rdb_bpm.Location = new System.Drawing.Point(42, 36);
            this.rdb_bpm.Name = "rdb_bpm";
            this.rdb_bpm.Size = new System.Drawing.Size(214, 21);
            this.rdb_bpm.TabIndex = 0;
            this.rdb_bpm.TabStop = true;
            this.rdb_bpm.Text = "Battement par minute (BPM)";
            this.rdb_bpm.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rad_slash);
            this.groupBox7.Controls.Add(this.rad_backslash);
            this.groupBox7.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(14, 117);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(440, 124);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Système d\'exploitation du lecteur :";
            // 
            // rad_slash
            // 
            this.rad_slash.AutoSize = true;
            this.rad_slash.Location = new System.Drawing.Point(42, 83);
            this.rad_slash.Name = "rad_slash";
            this.rad_slash.Size = new System.Drawing.Size(218, 21);
            this.rad_slash.TabIndex = 1;
            this.rad_slash.TabStop = true;
            this.rad_slash.Text = "Système Androïd, Apple, Unix";
            this.rad_slash.UseVisualStyleBackColor = true;
            // 
            // rad_backslash
            // 
            this.rad_backslash.AutoSize = true;
            this.rad_backslash.Location = new System.Drawing.Point(42, 38);
            this.rad_backslash.Name = "rad_backslash";
            this.rad_backslash.Size = new System.Drawing.Size(152, 21);
            this.rad_backslash.TabIndex = 0;
            this.rad_backslash.TabStop = true;
            this.rad_backslash.Text = "Système Windows";
            this.rad_backslash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Rep_Recherche);
            this.groupBox1.Controls.Add(this.pic_folder);
            this.groupBox1.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 99);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par défaut :";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_save.Location = new System.Drawing.Point(351, 398);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 51);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Valider";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Initialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 454);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Initialisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initialisation";
            ((System.ComponentModel.ISupportInitialize)(this.pic_folder)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Rep_Recherche;
        private System.Windows.Forms.PictureBox pic_folder;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rdb_Aucune;
        private System.Windows.Forms.RadioButton rdb_mpm;
        private System.Windows.Forms.RadioButton rdb_bpm;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rad_slash;
        private System.Windows.Forms.RadioButton rad_backslash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_save;
    }
}