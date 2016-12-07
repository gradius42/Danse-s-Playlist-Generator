namespace Danse_s_Playlist_Generator
{
    partial class Selection_Danse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection_Danse));
            this.btn_valider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rdb_Aleatoire = new System.Windows.Forms.RadioButton();
            this.rdb_Descroissant = new System.Windows.Forms.RadioButton();
            this.rdb_Croissant = new System.Windows.Forms.RadioButton();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bpm_max = new System.Windows.Forms.TextBox();
            this.txt_bpm_min = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(304, 255);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(127, 44);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.txt_number);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rdb_Aleatoire);
            this.groupBox10.Controls.Add(this.rdb_Descroissant);
            this.groupBox10.Controls.Add(this.rdb_Croissant);
            this.groupBox10.Location = new System.Drawing.Point(20, 166);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(379, 49);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Organisation des musiques";
            // 
            // rdb_Aleatoire
            // 
            this.rdb_Aleatoire.AutoSize = true;
            this.rdb_Aleatoire.Checked = true;
            this.rdb_Aleatoire.Location = new System.Drawing.Point(9, 21);
            this.rdb_Aleatoire.Name = "rdb_Aleatoire";
            this.rdb_Aleatoire.Size = new System.Drawing.Size(96, 24);
            this.rdb_Aleatoire.TabIndex = 2;
            this.rdb_Aleatoire.TabStop = true;
            this.rdb_Aleatoire.Text = "Aléatoire";
            this.rdb_Aleatoire.UseVisualStyleBackColor = true;
            // 
            // rdb_Descroissant
            // 
            this.rdb_Descroissant.AutoSize = true;
            this.rdb_Descroissant.Location = new System.Drawing.Point(243, 21);
            this.rdb_Descroissant.Name = "rdb_Descroissant";
            this.rdb_Descroissant.Size = new System.Drawing.Size(130, 24);
            this.rdb_Descroissant.TabIndex = 0;
            this.rdb_Descroissant.Text = "Descroissant";
            this.rdb_Descroissant.UseVisualStyleBackColor = true;
            // 
            // rdb_Croissant
            // 
            this.rdb_Croissant.AutoSize = true;
            this.rdb_Croissant.Location = new System.Drawing.Point(123, 21);
            this.rdb_Croissant.Name = "rdb_Croissant";
            this.rdb_Croissant.Size = new System.Drawing.Size(102, 24);
            this.rdb_Croissant.TabIndex = 1;
            this.rdb_Croissant.Text = "Croissant";
            this.rdb_Croissant.UseVisualStyleBackColor = true;
            // 
            // txt_number
            // 
            this.txt_number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_number.Location = new System.Drawing.Point(241, 29);
            this.txt_number.MaxLength = 3;
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(66, 26);
            this.txt_number.TabIndex = 4;
            this.txt_number.Text = "3";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de musique :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_bpm_max);
            this.groupBox2.Controls.Add(this.txt_bpm_min);
            this.groupBox2.Location = new System.Drawing.Point(17, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum :";
            // 
            // txt_bpm_max
            // 
            this.txt_bpm_max.Location = new System.Drawing.Point(224, 49);
            this.txt_bpm_max.MaxLength = 4;
            this.txt_bpm_max.Name = "txt_bpm_max";
            this.txt_bpm_max.Size = new System.Drawing.Size(66, 26);
            this.txt_bpm_max.TabIndex = 1;
            this.txt_bpm_max.Text = "300";
            this.txt_bpm_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bpm_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress_1);
            // 
            // txt_bpm_min
            // 
            this.txt_bpm_min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_bpm_min.Location = new System.Drawing.Point(224, 21);
            this.txt_bpm_min.MaxLength = 4;
            this.txt_bpm_min.Name = "txt_bpm_min";
            this.txt_bpm_min.Size = new System.Drawing.Size(66, 26);
            this.txt_bpm_min.TabIndex = 0;
            this.txt_bpm_min.Text = "0";
            this.txt_bpm_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bpm_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress_1);
            // 
            // Selection_Danse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selection_Danse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une danse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bpm_max;
        private System.Windows.Forms.TextBox txt_bpm_min;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rdb_Aleatoire;
        private System.Windows.Forms.RadioButton rdb_Descroissant;
        private System.Windows.Forms.RadioButton rdb_Croissant;
    }
}