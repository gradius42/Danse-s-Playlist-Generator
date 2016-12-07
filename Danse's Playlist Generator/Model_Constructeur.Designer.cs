namespace Danse_s_Playlist_Generator
{
    partial class Model_Constructeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model_Constructeur));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Aleatoire = new System.Windows.Forms.RadioButton();
            this.rdb_Descroissant = new System.Windows.Forms.RadioButton();
            this.rdb_Croissant = new System.Windows.Forms.RadioButton();
            this.btn_ajouter_danse_r = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nup_Min = new System.Windows.Forms.NumericUpDown();
            this.Nup_Max = new System.Windows.Forms.NumericUpDown();
            this.Nup_Nb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Danses = new System.Windows.Forms.ComboBox();
            this.listW_Danse_List2 = new System.Windows.Forms.ListView();
            this.Col_Null = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Danse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Max2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Tri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete_danse = new System.Windows.Forms.Button();
            this.btn_music_down = new System.Windows.Forms.Button();
            this.btn_music_up = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Nb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btn_ajouter_danse_r);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.Nup_Nb);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmb_Danses);
            this.groupBox4.Location = new System.Drawing.Point(11, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 123);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajouter une partie";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(529, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 48);
            this.button3.TabIndex = 15;
            this.button3.Text = "≡";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Aleatoire);
            this.groupBox1.Controls.Add(this.rdb_Descroissant);
            this.groupBox1.Controls.Add(this.rdb_Croissant);
            this.groupBox1.Location = new System.Drawing.Point(196, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organisation des musiques";
            // 
            // rdb_Aleatoire
            // 
            this.rdb_Aleatoire.AutoSize = true;
            this.rdb_Aleatoire.Checked = true;
            this.rdb_Aleatoire.Location = new System.Drawing.Point(9, 21);
            this.rdb_Aleatoire.Name = "rdb_Aleatoire";
            this.rdb_Aleatoire.Size = new System.Drawing.Size(85, 21);
            this.rdb_Aleatoire.TabIndex = 2;
            this.rdb_Aleatoire.TabStop = true;
            this.rdb_Aleatoire.Text = "Aléatoire";
            this.rdb_Aleatoire.UseVisualStyleBackColor = true;
            // 
            // rdb_Descroissant
            // 
            this.rdb_Descroissant.AutoSize = true;
            this.rdb_Descroissant.Location = new System.Drawing.Point(210, 21);
            this.rdb_Descroissant.Name = "rdb_Descroissant";
            this.rdb_Descroissant.Size = new System.Drawing.Size(111, 21);
            this.rdb_Descroissant.TabIndex = 0;
            this.rdb_Descroissant.Text = "Descroissant";
            this.rdb_Descroissant.UseVisualStyleBackColor = true;
            // 
            // rdb_Croissant
            // 
            this.rdb_Croissant.AutoSize = true;
            this.rdb_Croissant.Location = new System.Drawing.Point(108, 21);
            this.rdb_Croissant.Name = "rdb_Croissant";
            this.rdb_Croissant.Size = new System.Drawing.Size(88, 21);
            this.rdb_Croissant.TabIndex = 1;
            this.rdb_Croissant.Text = "Croissant";
            this.rdb_Croissant.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter_danse_r
            // 
            this.btn_ajouter_danse_r.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ajouter_danse_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_danse_r.Location = new System.Drawing.Point(529, 16);
            this.btn_ajouter_danse_r.Name = "btn_ajouter_danse_r";
            this.btn_ajouter_danse_r.Size = new System.Drawing.Size(58, 48);
            this.btn_ajouter_danse_r.TabIndex = 11;
            this.btn_ajouter_danse_r.Text = "+";
            this.btn_ajouter_danse_r.UseVisualStyleBackColor = false;
            this.btn_ajouter_danse_r.Click += new System.EventHandler(this.btn_ajouter_danse_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Nup_Min);
            this.groupBox5.Controls.Add(this.Nup_Max);
            this.groupBox5.Location = new System.Drawing.Point(196, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(327, 54);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rythme (bpm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Maximum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Minimum";
            // 
            // Nup_Min
            // 
            this.Nup_Min.Location = new System.Drawing.Point(89, 24);
            this.Nup_Min.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Nup_Min.Name = "Nup_Min";
            this.Nup_Min.Size = new System.Drawing.Size(77, 22);
            this.Nup_Min.TabIndex = 11;
            this.Nup_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nup_Min.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Nup_Max
            // 
            this.Nup_Max.Location = new System.Drawing.Point(244, 24);
            this.Nup_Max.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Nup_Max.Name = "Nup_Max";
            this.Nup_Max.Size = new System.Drawing.Size(77, 22);
            this.Nup_Max.TabIndex = 12;
            this.Nup_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nup_Max.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Nup_Nb
            // 
            this.Nup_Nb.Location = new System.Drawing.Point(60, 90);
            this.Nup_Nb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nup_Nb.Name = "Nup_Nb";
            this.Nup_Nb.Size = new System.Drawing.Size(77, 22);
            this.Nup_Nb.TabIndex = 9;
            this.Nup_Nb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nup_Nb.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre de musique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Style de danse";
            // 
            // cmb_Danses
            // 
            this.cmb_Danses.FormattingEnabled = true;
            this.cmb_Danses.Location = new System.Drawing.Point(6, 41);
            this.cmb_Danses.Name = "cmb_Danses";
            this.cmb_Danses.Size = new System.Drawing.Size(184, 24);
            this.cmb_Danses.TabIndex = 6;
            // 
            // listW_Danse_List2
            // 
            this.listW_Danse_List2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Null,
            this.Col_Danse,
            this.Col_Quantité,
            this.Col_Min,
            this.Col_Max2,
            this.Col_Tri});
            this.listW_Danse_List2.FullRowSelect = true;
            this.listW_Danse_List2.HideSelection = false;
            this.listW_Danse_List2.Location = new System.Drawing.Point(11, 158);
            this.listW_Danse_List2.MultiSelect = false;
            this.listW_Danse_List2.Name = "listW_Danse_List2";
            this.listW_Danse_List2.OwnerDraw = true;
            this.listW_Danse_List2.Size = new System.Drawing.Size(523, 449);
            this.listW_Danse_List2.TabIndex = 10;
            this.listW_Danse_List2.UseCompatibleStateImageBehavior = false;
            this.listW_Danse_List2.View = System.Windows.Forms.View.Details;
            this.listW_Danse_List2.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listW_Danse_List_DrawColumnHeader);
            this.listW_Danse_List2.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listW_Danse_List_DrawItem);
            this.listW_Danse_List2.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listW_Danse_List_DrawSubItem);
            // 
            // Col_Null
            // 
            this.Col_Null.Width = 1;
            // 
            // Col_Danse
            // 
            this.Col_Danse.Text = "Danse";
            this.Col_Danse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Danse.Width = 110;
            // 
            // Col_Quantité
            // 
            this.Col_Quantité.Text = "Quantité";
            this.Col_Quantité.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Quantité.Width = 80;
            // 
            // Col_Min
            // 
            this.Col_Min.Text = "Min";
            this.Col_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Max2
            // 
            this.Col_Max2.Text = "Max";
            this.Col_Max2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Col_Tri
            // 
            this.Col_Tri.Text = "Tri";
            this.Col_Tri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Tri.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Liste des danses :";
            // 
            // btn_delete_danse
            // 
            this.btn_delete_danse.BackColor = System.Drawing.Color.Coral;
            this.btn_delete_danse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_danse.Location = new System.Drawing.Point(549, 158);
            this.btn_delete_danse.Name = "btn_delete_danse";
            this.btn_delete_danse.Size = new System.Drawing.Size(58, 48);
            this.btn_delete_danse.TabIndex = 14;
            this.btn_delete_danse.Text = "-";
            this.btn_delete_danse.UseVisualStyleBackColor = false;
            this.btn_delete_danse.Click += new System.EventHandler(this.btn_delete_danse_Click);
            // 
            // btn_music_down
            // 
            this.btn_music_down.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_music_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_down.Location = new System.Drawing.Point(549, 286);
            this.btn_music_down.Name = "btn_music_down";
            this.btn_music_down.Size = new System.Drawing.Size(58, 48);
            this.btn_music_down.TabIndex = 13;
            this.btn_music_down.Text = "▼";
            this.btn_music_down.UseVisualStyleBackColor = false;
            this.btn_music_down.Click += new System.EventHandler(this.btn_music_down_Click);
            // 
            // btn_music_up
            // 
            this.btn_music_up.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_music_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_up.Location = new System.Drawing.Point(549, 222);
            this.btn_music_up.Name = "btn_music_up";
            this.btn_music_up.Size = new System.Drawing.Size(58, 48);
            this.btn_music_up.TabIndex = 12;
            this.btn_music_up.Text = "▲";
            this.btn_music_up.UseVisualStyleBackColor = false;
            this.btn_music_up.Click += new System.EventHandler(this.btn_music_up_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(549, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(549, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "√ ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Model_Constructeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_delete_danse);
            this.Controls.Add(this.btn_music_down);
            this.Controls.Add(this.btn_music_up);
            this.Controls.Add(this.listW_Danse_List2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Model_Constructeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Model_Constructeur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Model_Constructeur_FormClosed);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Nb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ajouter_danse_r;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Nup_Min;
        private System.Windows.Forms.NumericUpDown Nup_Max;
        private System.Windows.Forms.NumericUpDown Nup_Nb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Danses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_Aleatoire;
        private System.Windows.Forms.RadioButton rdb_Croissant;
        private System.Windows.Forms.RadioButton rdb_Descroissant;
        private System.Windows.Forms.ListView listW_Danse_List2;
        private System.Windows.Forms.ColumnHeader Col_Null;
        private System.Windows.Forms.ColumnHeader Col_Danse;
        private System.Windows.Forms.ColumnHeader Col_Quantité;
        private System.Windows.Forms.ColumnHeader Col_Min;
        private System.Windows.Forms.ColumnHeader Col_Max2;
        private System.Windows.Forms.ColumnHeader Col_Tri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete_danse;
        private System.Windows.Forms.Button btn_music_down;
        private System.Windows.Forms.Button btn_music_up;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}