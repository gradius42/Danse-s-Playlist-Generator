namespace Danse_s_Playlist_Generator
{
    partial class Routine_Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Routine_Loader));
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_routine = new System.Windows.Forms.ComboBox();
            this.btn_ajouter_danse_r = new System.Windows.Forms.Button();
            this.list_Musiques = new System.Windows.Forms.ListBox();
            this.btn_delete_danse = new System.Windows.Forms.Button();
            this.btn_music_down = new System.Windows.Forms.Button();
            this.btn_music_up = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nup_nombre = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nup_m = new System.Windows.Forms.NumericUpDown();
            this.nup_s = new System.Windows.Forms.NumericUpDown();
            this.nup_h = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_valider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_h)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Vos routines :";
            // 
            // cmb_routine
            // 
            this.cmb_routine.FormattingEnabled = true;
            this.cmb_routine.Location = new System.Drawing.Point(105, 35);
            this.cmb_routine.Name = "cmb_routine";
            this.cmb_routine.Size = new System.Drawing.Size(184, 24);
            this.cmb_routine.TabIndex = 17;
            this.cmb_routine.SelectedIndexChanged += new System.EventHandler(this.cmb_routine_SelectedIndexChanged);
            // 
            // btn_ajouter_danse_r
            // 
            this.btn_ajouter_danse_r.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ajouter_danse_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_danse_r.Location = new System.Drawing.Point(295, 11);
            this.btn_ajouter_danse_r.Name = "btn_ajouter_danse_r";
            this.btn_ajouter_danse_r.Size = new System.Drawing.Size(58, 48);
            this.btn_ajouter_danse_r.TabIndex = 19;
            this.btn_ajouter_danse_r.Text = "+";
            this.btn_ajouter_danse_r.UseVisualStyleBackColor = false;
            this.btn_ajouter_danse_r.Visible = false;
            this.btn_ajouter_danse_r.Click += new System.EventHandler(this.btn_ajouter_danse_r_Click);
            // 
            // list_Musiques
            // 
            this.list_Musiques.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Musiques.FormattingEnabled = true;
            this.list_Musiques.ItemHeight = 17;
            this.list_Musiques.Location = new System.Drawing.Point(12, 75);
            this.list_Musiques.Name = "list_Musiques";
            this.list_Musiques.Size = new System.Drawing.Size(298, 310);
            this.list_Musiques.TabIndex = 20;
            // 
            // btn_delete_danse
            // 
            this.btn_delete_danse.BackColor = System.Drawing.Color.Coral;
            this.btn_delete_danse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_danse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_danse.Location = new System.Drawing.Point(325, 104);
            this.btn_delete_danse.Name = "btn_delete_danse";
            this.btn_delete_danse.Size = new System.Drawing.Size(58, 48);
            this.btn_delete_danse.TabIndex = 23;
            this.btn_delete_danse.Text = "-";
            this.btn_delete_danse.UseVisualStyleBackColor = false;
            this.btn_delete_danse.Click += new System.EventHandler(this.btn_delete_danse_Click);
            // 
            // btn_music_down
            // 
            this.btn_music_down.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_music_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_down.Location = new System.Drawing.Point(325, 212);
            this.btn_music_down.Name = "btn_music_down";
            this.btn_music_down.Size = new System.Drawing.Size(58, 48);
            this.btn_music_down.TabIndex = 22;
            this.btn_music_down.Text = "▼";
            this.btn_music_down.UseVisualStyleBackColor = false;
            this.btn_music_down.Click += new System.EventHandler(this.btn_music_down_Click);
            // 
            // btn_music_up
            // 
            this.btn_music_up.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_music_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_up.Location = new System.Drawing.Point(325, 158);
            this.btn_music_up.Name = "btn_music_up";
            this.btn_music_up.Size = new System.Drawing.Size(58, 48);
            this.btn_music_up.TabIndex = 21;
            this.btn_music_up.Text = "▲";
            this.btn_music_up.UseVisualStyleBackColor = false;
            this.btn_music_up.Click += new System.EventHandler(this.btn_music_up_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nup_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nup_m);
            this.groupBox1.Controls.Add(this.nup_s);
            this.groupBox1.Controls.Add(this.nup_h);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 102);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode d\'ajout :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // nup_nombre
            // 
            this.nup_nombre.Location = new System.Drawing.Point(155, 28);
            this.nup_nombre.Name = "nup_nombre";
            this.nup_nombre.Size = new System.Drawing.Size(72, 25);
            this.nup_nombre.TabIndex = 8;
            this.nup_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_nombre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "H";
            // 
            // nup_m
            // 
            this.nup_m.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_m.Location = new System.Drawing.Point(213, 66);
            this.nup_m.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nup_m.Name = "nup_m";
            this.nup_m.Size = new System.Drawing.Size(48, 25);
            this.nup_m.TabIndex = 4;
            this.nup_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nup_s
            // 
            this.nup_s.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_s.Location = new System.Drawing.Point(284, 66);
            this.nup_s.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nup_s.Name = "nup_s";
            this.nup_s.Size = new System.Drawing.Size(48, 25);
            this.nup_s.TabIndex = 3;
            this.nup_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nup_h
            // 
            this.nup_h.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_h.Location = new System.Drawing.Point(143, 66);
            this.nup_h.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nup_h.Name = "nup_h";
            this.nup_h.Size = new System.Drawing.Size(48, 25);
            this.nup_h.TabIndex = 2;
            this.nup_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_h.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(14, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Durée d\'ajout :";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(14, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre d\'ajout :";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_valider.Location = new System.Drawing.Point(279, 516);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(103, 51);
            this.btn_valider.TabIndex = 25;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // Routine_Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 575);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete_danse);
            this.Controls.Add(this.btn_music_down);
            this.Controls.Add(this.btn_music_up);
            this.Controls.Add(this.list_Musiques);
            this.Controls.Add(this.btn_ajouter_danse_r);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_routine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Routine_Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Routine_Loader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_h)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_routine;
        private System.Windows.Forms.Button btn_ajouter_danse_r;
        private System.Windows.Forms.ListBox list_Musiques;
        private System.Windows.Forms.Button btn_delete_danse;
        private System.Windows.Forms.Button btn_music_down;
        private System.Windows.Forms.Button btn_music_up;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nup_m;
        private System.Windows.Forms.NumericUpDown nup_s;
        private System.Windows.Forms.NumericUpDown nup_h;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nup_nombre;
        private System.Windows.Forms.Button btn_valider;
    }
}