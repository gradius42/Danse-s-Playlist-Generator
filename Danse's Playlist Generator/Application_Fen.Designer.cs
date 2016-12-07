using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Danse_s_Playlist_Generator
{
    partial class Application_Fen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application_Fen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_durée_musique = new System.Windows.Forms.Label();
            this.lbl_playlist = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_routine_f = new System.Windows.Forms.Label();
            this.lbl_danse_f = new System.Windows.Forms.Label();
            this.lbl_music_f_r = new System.Windows.Forms.Label();
            this.lbl_music_f = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Rep_Recherche = new System.Windows.Forms.TextBox();
            this.btn_folder_select = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_playlist = new System.Windows.Forms.GroupBox();
            this.pic_Apperçu = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.listW_Danse_List = new System.Windows.Forms.ListView();
            this.Col_Null = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Danse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Max2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_load_rout = new System.Windows.Forms.Button();
            this.btn_ajouter_danse = new System.Windows.Forms.Button();
            this.btn_selection_manuelle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nup_Min = new System.Windows.Forms.NumericUpDown();
            this.Nup_Max = new System.Windows.Forms.NumericUpDown();
            this.Nup_Nb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Danses = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete_selection = new System.Windows.Forms.Button();
            this.btn_add_to_danse = new System.Windows.Forms.Button();
            this.btn_music_desc = new System.Windows.Forms.Button();
            this.btn_musique_asc = new System.Windows.Forms.Button();
            this.btn_reload_select = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.btn_selection_down = new System.Windows.Forms.Button();
            this.btn_selection_up = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_change_danse = new System.Windows.Forms.Button();
            this.btn_delete_danse = new System.Windows.Forms.Button();
            this.btn_music_down = new System.Windows.Forms.Button();
            this.btn_music_up = new System.Windows.Forms.Button();
            this.btn_reload_all = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.list_Musiques = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_selec = new System.Windows.Forms.Label();
            this.grp_opt_r = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Danse_Down_r = new System.Windows.Forms.Button();
            this.btn_Danse_Up_r = new System.Windows.Forms.Button();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Save_Rout = new System.Windows.Forms.Button();
            this.grp_aj_d_r = new System.Windows.Forms.GroupBox();
            this.btn_selection_manuelle_r = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rdb_Aleatoire = new System.Windows.Forms.RadioButton();
            this.rdb_Descroissant = new System.Windows.Forms.RadioButton();
            this.rdb_Croissant = new System.Windows.Forms.RadioButton();
            this.btn_ajouter_danse_r = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Nup_Min_Rout = new System.Windows.Forms.NumericUpDown();
            this.Nup_Max_Rout = new System.Windows.Forms.NumericUpDown();
            this.Nup_Nb_r = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb_Danses_r = new System.Windows.Forms.ComboBox();
            this.lst_Musique_Manuelle_View = new System.Windows.Forms.ListBox();
            this.grp_selec_rout = new System.Windows.Forms.GroupBox();
            this.btn_Suppr_Routine = new System.Windows.Forms.Button();
            this.lbl_ou = new System.Windows.Forms.Label();
            this.btn_nouvelle_routine = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_routine = new System.Windows.Forms.ComboBox();
            this.dataGridView_Routine = new System.Windows.Forms.DataGridView();
            this.Col_Auto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Data_Danse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Data_Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Data_Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Data_Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Data_Tri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_modif_False = new System.Windows.Forms.Button();
            this.btn_modif_Ok = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.grp_rep = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Rep_Recherche2 = new System.Windows.Forms.TextBox();
            this.pic_folder = new System.Windows.Forms.PictureBox();
            this.grp_tri = new System.Windows.Forms.GroupBox();
            this.rdb_Aucune = new System.Windows.Forms.RadioButton();
            this.rdb_mpm = new System.Windows.Forms.RadioButton();
            this.rdb_bpm = new System.Windows.Forms.RadioButton();
            this.grp_file_sep = new System.Windows.Forms.GroupBox();
            this.rad_slash = new System.Windows.Forms.RadioButton();
            this.rad_backslash = new System.Windows.Forms.RadioButton();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grp_playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Apperçu)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Nb)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grp_opt_r.SuspendLayout();
            this.grp_aj_d_r.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Min_Rout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Max_Rout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Nb_r)).BeginInit();
            this.grp_selec_rout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Routine)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grp_rep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_folder)).BeginInit();
            this.grp_tri.SuspendLayout();
            this.grp_file_sep.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Location = new System.Drawing.Point(2, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1061, 603);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_Rep_Recherche);
            this.tabPage1.Controls.Add(this.btn_folder_select);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accueil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(563, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Structure de fichier :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_durée_musique);
            this.groupBox3.Controls.Add(this.lbl_playlist);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbl_routine_f);
            this.groupBox3.Controls.Add(this.lbl_danse_f);
            this.groupBox3.Controls.Add(this.lbl_music_f_r);
            this.groupBox3.Controls.Add(this.lbl_music_f);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 483);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations :";
            // 
            // lbl_durée_musique
            // 
            this.lbl_durée_musique.AutoSize = true;
            this.lbl_durée_musique.Location = new System.Drawing.Point(117, 205);
            this.lbl_durée_musique.Name = "lbl_durée_musique";
            this.lbl_durée_musique.Size = new System.Drawing.Size(95, 17);
            this.lbl_durée_musique.TabIndex = 8;
            this.lbl_durée_musique.Text = "Durée totale :";
            // 
            // lbl_playlist
            // 
            this.lbl_playlist.AutoSize = true;
            this.lbl_playlist.Location = new System.Drawing.Point(117, 399);
            this.lbl_playlist.Name = "lbl_playlist";
            this.lbl_playlist.Size = new System.Drawing.Size(149, 17);
            this.lbl_playlist.TabIndex = 7;
            this.lbl_playlist.Text = "playlist(s) générée(s).";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Playlist :";
            // 
            // lbl_routine_f
            // 
            this.lbl_routine_f.AutoSize = true;
            this.lbl_routine_f.Location = new System.Drawing.Point(117, 297);
            this.lbl_routine_f.Name = "lbl_routine_f";
            this.lbl_routine_f.Size = new System.Drawing.Size(225, 17);
            this.lbl_routine_f.TabIndex = 5;
            this.lbl_routine_f.Text = "routine(s) de danse disponible(s).";
            // 
            // lbl_danse_f
            // 
            this.lbl_danse_f.AutoSize = true;
            this.lbl_danse_f.Location = new System.Drawing.Point(117, 162);
            this.lbl_danse_f.Name = "lbl_danse_f";
            this.lbl_danse_f.Size = new System.Drawing.Size(216, 17);
            this.lbl_danse_f.TabIndex = 4;
            this.lbl_danse_f.Text = "style(s) de danse referencée(s).";
            // 
            // lbl_music_f_r
            // 
            this.lbl_music_f_r.AutoSize = true;
            this.lbl_music_f_r.Location = new System.Drawing.Point(117, 119);
            this.lbl_music_f_r.Name = "lbl_music_f_r";
            this.lbl_music_f_r.Size = new System.Drawing.Size(240, 17);
            this.lbl_music_f_r.TabIndex = 3;
            this.lbl_music_f_r.Text = "musique(s) avec rythme trouvée(s).";
            // 
            // lbl_music_f
            // 
            this.lbl_music_f.AutoSize = true;
            this.lbl_music_f.Location = new System.Drawing.Point(117, 76);
            this.lbl_music_f.Name = "lbl_music_f";
            this.lbl_music_f.Size = new System.Drawing.Size(156, 17);
            this.lbl_music_f.TabIndex = 2;
            this.lbl_music_f.Text = "musique(s) trouvée(s).";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Routine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Musique :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repertoire de recherche :";
            // 
            // txt_Rep_Recherche
            // 
            this.txt_Rep_Recherche.Enabled = false;
            this.txt_Rep_Recherche.Location = new System.Drawing.Point(9, 41);
            this.txt_Rep_Recherche.Name = "txt_Rep_Recherche";
            this.txt_Rep_Recherche.ReadOnly = true;
            this.txt_Rep_Recherche.Size = new System.Drawing.Size(384, 22);
            this.txt_Rep_Recherche.TabIndex = 8;
            // 
            // btn_folder_select
            // 
            this.btn_folder_select.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_folder_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_folder_select.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_folder_select.Location = new System.Drawing.Point(419, 13);
            this.btn_folder_select.Name = "btn_folder_select";
            this.btn_folder_select.Size = new System.Drawing.Size(119, 51);
            this.btn_folder_select.TabIndex = 7;
            this.btn_folder_select.Text = "Sélectionner";
            this.btn_folder_select.UseVisualStyleBackColor = false;
            this.btn_folder_select.Click += new System.EventHandler(this.btn_folder_select_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(563, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(484, 535);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grp_playlist);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ma playlist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grp_playlist
            // 
            this.grp_playlist.Controls.Add(this.pic_Apperçu);
            this.grp_playlist.Controls.Add(this.btn_reset);
            this.grp_playlist.Controls.Add(this.btn_save);
            this.grp_playlist.Controls.Add(this.listW_Danse_List);
            this.grp_playlist.Controls.Add(this.groupBox4);
            this.grp_playlist.Controls.Add(this.groupBox2);
            this.grp_playlist.Controls.Add(this.groupBox1);
            this.grp_playlist.Controls.Add(this.label4);
            this.grp_playlist.Controls.Add(this.list_Musiques);
            this.grp_playlist.Controls.Add(this.label3);
            this.grp_playlist.Font = new System.Drawing.Font("Arimo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_playlist.Location = new System.Drawing.Point(2, 3);
            this.grp_playlist.Name = "grp_playlist";
            this.grp_playlist.Size = new System.Drawing.Size(1045, 561);
            this.grp_playlist.TabIndex = 1;
            this.grp_playlist.TabStop = false;
            this.grp_playlist.Text = "Play List";
            // 
            // pic_Apperçu
            // 
            this.pic_Apperçu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_Apperçu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Apperçu.Image = ((System.Drawing.Image)(resources.GetObject("pic_Apperçu.Image")));
            this.pic_Apperçu.InitialImage = null;
            this.pic_Apperçu.Location = new System.Drawing.Point(232, 105);
            this.pic_Apperçu.Name = "pic_Apperçu";
            this.pic_Apperçu.Size = new System.Drawing.Size(36, 34);
            this.pic_Apperçu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Apperçu.TabIndex = 16;
            this.pic_Apperçu.TabStop = false;
            this.pic_Apperçu.Click += new System.EventHandler(this.pic_Apperçu_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Red;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_reset.Location = new System.Drawing.Point(928, 75);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 51);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Remise à zéro";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_save.Location = new System.Drawing.Point(928, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 51);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // listW_Danse_List
            // 
            this.listW_Danse_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Null,
            this.Col_Danse,
            this.Col_Min,
            this.Col_Max2});
            this.listW_Danse_List.FullRowSelect = true;
            this.listW_Danse_List.HideSelection = false;
            this.listW_Danse_List.Location = new System.Drawing.Point(15, 139);
            this.listW_Danse_List.MultiSelect = false;
            this.listW_Danse_List.Name = "listW_Danse_List";
            this.listW_Danse_List.OwnerDraw = true;
            this.listW_Danse_List.Size = new System.Drawing.Size(256, 404);
            this.listW_Danse_List.TabIndex = 8;
            this.listW_Danse_List.UseCompatibleStateImageBehavior = false;
            this.listW_Danse_List.View = System.Windows.Forms.View.Details;
            this.listW_Danse_List.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listW_Danse_List_DrawColumnHeader);
            this.listW_Danse_List.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listW_Danse_List_DrawItem);
            this.listW_Danse_List.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listW_Danse_List_DrawSubItem);
            this.listW_Danse_List.SelectedIndexChanged += new System.EventHandler(this.listW_Danse_List_SelectedIndexChanged);
            this.listW_Danse_List.Leave += new System.EventHandler(this.listW_Danse_List_Leave);
            // 
            // Col_Null
            // 
            this.Col_Null.Width = 1;
            // 
            // Col_Danse
            // 
            this.Col_Danse.Text = "Danse";
            this.Col_Danse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Danse.Width = 100;
            // 
            // Col_Min
            // 
            this.Col_Min.Text = "Min";
            this.Col_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Min.Width = 40;
            // 
            // Col_Max2
            // 
            this.Col_Max2.Text = "Max";
            this.Col_Max2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Max2.Width = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_load_rout);
            this.groupBox4.Controls.Add(this.btn_ajouter_danse);
            this.groupBox4.Controls.Add(this.btn_selection_manuelle);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.Nup_Nb);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmb_Danses);
            this.groupBox4.Location = new System.Drawing.Point(15, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(907, 77);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajouter des musiques";
            // 
            // btn_load_rout
            // 
            this.btn_load_rout.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_load_rout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_rout.Location = new System.Drawing.Point(839, 19);
            this.btn_load_rout.Name = "btn_load_rout";
            this.btn_load_rout.Size = new System.Drawing.Size(58, 48);
            this.btn_load_rout.TabIndex = 14;
            this.btn_load_rout.Text = "▼♪";
            this.btn_load_rout.UseVisualStyleBackColor = false;
            this.btn_load_rout.Click += new System.EventHandler(this.btn_load_rout_Click);
            // 
            // btn_ajouter_danse
            // 
            this.btn_ajouter_danse.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ajouter_danse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter_danse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_danse.Location = new System.Drawing.Point(687, 19);
            this.btn_ajouter_danse.Name = "btn_ajouter_danse";
            this.btn_ajouter_danse.Size = new System.Drawing.Size(58, 48);
            this.btn_ajouter_danse.TabIndex = 11;
            this.btn_ajouter_danse.Text = "+";
            this.btn_ajouter_danse.UseVisualStyleBackColor = false;
            this.btn_ajouter_danse.Click += new System.EventHandler(this.btn_ajouter_danse_Click);
            // 
            // btn_selection_manuelle
            // 
            this.btn_selection_manuelle.BackColor = System.Drawing.Color.Turquoise;
            this.btn_selection_manuelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selection_manuelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selection_manuelle.Location = new System.Drawing.Point(763, 19);
            this.btn_selection_manuelle.Name = "btn_selection_manuelle";
            this.btn_selection_manuelle.Size = new System.Drawing.Size(58, 48);
            this.btn_selection_manuelle.TabIndex = 13;
            this.btn_selection_manuelle.Text = "≡";
            this.btn_selection_manuelle.UseVisualStyleBackColor = false;
            this.btn_selection_manuelle.Click += new System.EventHandler(this.btn_selection_manuelle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Nup_Min);
            this.groupBox5.Controls.Add(this.Nup_Max);
            this.groupBox5.Location = new System.Drawing.Point(348, 17);
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
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Maximum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
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
            this.Nup_Min.ValueChanged += new System.EventHandler(this.Nup_Min_ValueChanged);
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
            this.Nup_Max.ValueChanged += new System.EventHandler(this.Nup_Max_ValueChanged);
            // 
            // Nup_Nb
            // 
            this.Nup_Nb.Location = new System.Drawing.Point(237, 42);
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
            this.Nup_Nb.ValueChanged += new System.EventHandler(this.Nup_Nb_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre de musique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete_selection);
            this.groupBox2.Controls.Add(this.btn_add_to_danse);
            this.groupBox2.Controls.Add(this.btn_music_desc);
            this.groupBox2.Controls.Add(this.btn_musique_asc);
            this.groupBox2.Controls.Add(this.btn_reload_select);
            this.groupBox2.Controls.Add(this.btn_Shuffle);
            this.groupBox2.Controls.Add(this.btn_selection_down);
            this.groupBox2.Controls.Add(this.btn_selection_up);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(599, 339);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 205);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option : Musiques";
            // 
            // btn_delete_selection
            // 
            this.btn_delete_selection.BackColor = System.Drawing.Color.Coral;
            this.btn_delete_selection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_selection.Location = new System.Drawing.Point(359, 42);
            this.btn_delete_selection.Name = "btn_delete_selection";
            this.btn_delete_selection.Size = new System.Drawing.Size(58, 48);
            this.btn_delete_selection.TabIndex = 10;
            this.btn_delete_selection.Text = "-";
            this.btn_delete_selection.UseVisualStyleBackColor = false;
            this.btn_delete_selection.Click += new System.EventHandler(this.btn_delete_selection_Click);
            // 
            // btn_add_to_danse
            // 
            this.btn_add_to_danse.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add_to_danse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_to_danse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_to_danse.Location = new System.Drawing.Point(274, 42);
            this.btn_add_to_danse.Name = "btn_add_to_danse";
            this.btn_add_to_danse.Size = new System.Drawing.Size(58, 48);
            this.btn_add_to_danse.TabIndex = 9;
            this.btn_add_to_danse.Text = "+";
            this.btn_add_to_danse.UseVisualStyleBackColor = false;
            this.btn_add_to_danse.Click += new System.EventHandler(this.btn_add_to_danse_Click);
            // 
            // btn_music_desc
            // 
            this.btn_music_desc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_music_desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_desc.Location = new System.Drawing.Point(107, 123);
            this.btn_music_desc.Name = "btn_music_desc";
            this.btn_music_desc.Size = new System.Drawing.Size(58, 48);
            this.btn_music_desc.TabIndex = 8;
            this.btn_music_desc.Text = "↓";
            this.btn_music_desc.UseVisualStyleBackColor = false;
            this.btn_music_desc.Click += new System.EventHandler(this.btn_music_desc_Click);
            // 
            // btn_musique_asc
            // 
            this.btn_musique_asc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_musique_asc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_musique_asc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_musique_asc.Location = new System.Drawing.Point(107, 42);
            this.btn_musique_asc.Name = "btn_musique_asc";
            this.btn_musique_asc.Size = new System.Drawing.Size(58, 48);
            this.btn_musique_asc.TabIndex = 7;
            this.btn_musique_asc.Text = "↑";
            this.btn_musique_asc.UseVisualStyleBackColor = false;
            this.btn_musique_asc.Click += new System.EventHandler(this.btn_musique_asc_Click);
            // 
            // btn_reload_select
            // 
            this.btn_reload_select.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_reload_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload_select.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_reload_select.Location = new System.Drawing.Point(274, 123);
            this.btn_reload_select.Name = "btn_reload_select";
            this.btn_reload_select.Size = new System.Drawing.Size(143, 48);
            this.btn_reload_select.TabIndex = 4;
            this.btn_reload_select.Text = "Recharger la sélection";
            this.btn_reload_select.UseVisualStyleBackColor = false;
            this.btn_reload_select.Click += new System.EventHandler(this.btn_reload_select_Click);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Shuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Shuffle.BackgroundImage")));
            this.btn_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shuffle.Location = new System.Drawing.Point(190, 68);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(58, 78);
            this.btn_Shuffle.TabIndex = 5;
            this.btn_Shuffle.UseVisualStyleBackColor = false;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            // 
            // btn_selection_down
            // 
            this.btn_selection_down.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_selection_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selection_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selection_down.Location = new System.Drawing.Point(33, 123);
            this.btn_selection_down.Name = "btn_selection_down";
            this.btn_selection_down.Size = new System.Drawing.Size(58, 48);
            this.btn_selection_down.TabIndex = 4;
            this.btn_selection_down.Text = "▼";
            this.btn_selection_down.UseVisualStyleBackColor = false;
            this.btn_selection_down.Click += new System.EventHandler(this.btn_selection_down_Click);
            // 
            // btn_selection_up
            // 
            this.btn_selection_up.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_selection_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selection_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selection_up.Location = new System.Drawing.Point(33, 42);
            this.btn_selection_up.Name = "btn_selection_up";
            this.btn_selection_up.Size = new System.Drawing.Size(58, 48);
            this.btn_selection_up.TabIndex = 3;
            this.btn_selection_up.Text = "▲";
            this.btn_selection_up.UseVisualStyleBackColor = false;
            this.btn_selection_up.Click += new System.EventHandler(this.btn_selection_up_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_change_danse);
            this.groupBox1.Controls.Add(this.btn_delete_danse);
            this.groupBox1.Controls.Add(this.btn_music_down);
            this.groupBox1.Controls.Add(this.btn_music_up);
            this.groupBox1.Controls.Add(this.btn_reload_all);
            this.groupBox1.Location = new System.Drawing.Point(599, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option : Danses";
            // 
            // btn_change_danse
            // 
            this.btn_change_danse.BackColor = System.Drawing.Color.Khaki;
            this.btn_change_danse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change_danse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_danse.Location = new System.Drawing.Point(274, 42);
            this.btn_change_danse.Name = "btn_change_danse";
            this.btn_change_danse.Size = new System.Drawing.Size(58, 48);
            this.btn_change_danse.TabIndex = 11;
            this.btn_change_danse.Text = "☼";
            this.btn_change_danse.UseVisualStyleBackColor = false;
            this.btn_change_danse.Click += new System.EventHandler(this.btn_change_danse_Click);
            // 
            // btn_delete_danse
            // 
            this.btn_delete_danse.BackColor = System.Drawing.Color.Coral;
            this.btn_delete_danse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_danse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_danse.Location = new System.Drawing.Point(359, 42);
            this.btn_delete_danse.Name = "btn_delete_danse";
            this.btn_delete_danse.Size = new System.Drawing.Size(58, 48);
            this.btn_delete_danse.TabIndex = 11;
            this.btn_delete_danse.Text = "-";
            this.btn_delete_danse.UseVisualStyleBackColor = false;
            this.btn_delete_danse.Click += new System.EventHandler(this.btn_delete_danse_Click);
            // 
            // btn_music_down
            // 
            this.btn_music_down.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_music_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_down.Location = new System.Drawing.Point(33, 117);
            this.btn_music_down.Name = "btn_music_down";
            this.btn_music_down.Size = new System.Drawing.Size(58, 48);
            this.btn_music_down.TabIndex = 3;
            this.btn_music_down.Text = "▼";
            this.btn_music_down.UseVisualStyleBackColor = false;
            this.btn_music_down.Click += new System.EventHandler(this.btn_music_down_Click);
            // 
            // btn_music_up
            // 
            this.btn_music_up.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_music_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_up.Location = new System.Drawing.Point(33, 42);
            this.btn_music_up.Name = "btn_music_up";
            this.btn_music_up.Size = new System.Drawing.Size(58, 48);
            this.btn_music_up.TabIndex = 2;
            this.btn_music_up.Text = "▲";
            this.btn_music_up.UseVisualStyleBackColor = false;
            this.btn_music_up.Click += new System.EventHandler(this.btn_music_up_Click);
            // 
            // btn_reload_all
            // 
            this.btn_reload_all.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_reload_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload_all.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_reload_all.Location = new System.Drawing.Point(274, 117);
            this.btn_reload_all.Name = "btn_reload_all";
            this.btn_reload_all.Size = new System.Drawing.Size(143, 48);
            this.btn_reload_all.TabIndex = 1;
            this.btn_reload_all.Text = "Recharger les musiques";
            this.btn_reload_all.UseVisualStyleBackColor = false;
            this.btn_reload_all.Click += new System.EventHandler(this.btn_reload_all_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Les musiques";
            // 
            // list_Musiques
            // 
            this.list_Musiques.FormattingEnabled = true;
            this.list_Musiques.ItemHeight = 16;
            this.list_Musiques.Location = new System.Drawing.Point(277, 139);
            this.list_Musiques.Name = "list_Musiques";
            this.list_Musiques.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_Musiques.Size = new System.Drawing.Size(316, 404);
            this.list_Musiques.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liste des danses";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_selec);
            this.tabPage3.Controls.Add(this.grp_opt_r);
            this.tabPage3.Controls.Add(this.btn_Fermer);
            this.tabPage3.Controls.Add(this.btn_Save_Rout);
            this.tabPage3.Controls.Add(this.grp_aj_d_r);
            this.tabPage3.Controls.Add(this.lst_Musique_Manuelle_View);
            this.tabPage3.Controls.Add(this.grp_selec_rout);
            this.tabPage3.Controls.Add(this.dataGridView_Routine);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1053, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mes Routines";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_selec
            // 
            this.lbl_selec.AutoSize = true;
            this.lbl_selec.Location = new System.Drawing.Point(739, 129);
            this.lbl_selec.Name = "lbl_selec";
            this.lbl_selec.Size = new System.Drawing.Size(74, 17);
            this.lbl_selec.TabIndex = 16;
            this.lbl_selec.Text = "Selection :";
            this.lbl_selec.Visible = false;
            // 
            // grp_opt_r
            // 
            this.grp_opt_r.Controls.Add(this.button4);
            this.grp_opt_r.Controls.Add(this.button5);
            this.grp_opt_r.Controls.Add(this.btn_Danse_Down_r);
            this.grp_opt_r.Controls.Add(this.btn_Danse_Up_r);
            this.grp_opt_r.Location = new System.Drawing.Point(736, 352);
            this.grp_opt_r.Name = "grp_opt_r";
            this.grp_opt_r.Size = new System.Drawing.Size(311, 159);
            this.grp_opt_r.TabIndex = 19;
            this.grp_opt_r.TabStop = false;
            this.grp_opt_r.Text = "Option : ";
            this.grp_opt_r.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(217, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 48);
            this.button4.TabIndex = 12;
            this.button4.Text = "☼";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Coral;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(217, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 48);
            this.button5.TabIndex = 11;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Danse_Down_r
            // 
            this.btn_Danse_Down_r.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Danse_Down_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Danse_Down_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Danse_Down_r.Location = new System.Drawing.Point(65, 96);
            this.btn_Danse_Down_r.Name = "btn_Danse_Down_r";
            this.btn_Danse_Down_r.Size = new System.Drawing.Size(58, 48);
            this.btn_Danse_Down_r.TabIndex = 3;
            this.btn_Danse_Down_r.Text = "▼";
            this.btn_Danse_Down_r.UseVisualStyleBackColor = false;
            this.btn_Danse_Down_r.Click += new System.EventHandler(this.btn_Danse_Down_r_Click);
            // 
            // btn_Danse_Up_r
            // 
            this.btn_Danse_Up_r.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Danse_Up_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Danse_Up_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Danse_Up_r.Location = new System.Drawing.Point(65, 30);
            this.btn_Danse_Up_r.Name = "btn_Danse_Up_r";
            this.btn_Danse_Up_r.Size = new System.Drawing.Size(58, 48);
            this.btn_Danse_Up_r.TabIndex = 2;
            this.btn_Danse_Up_r.Text = "▲";
            this.btn_Danse_Up_r.UseVisualStyleBackColor = false;
            this.btn_Danse_Up_r.Click += new System.EventHandler(this.btn_Danse_Up_r_Click);
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.BackColor = System.Drawing.Color.Red;
            this.btn_Fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fermer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Fermer.Location = new System.Drawing.Point(935, 517);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(103, 51);
            this.btn_Fermer.TabIndex = 18;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = false;
            this.btn_Fermer.Visible = false;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Save_Rout
            // 
            this.btn_Save_Rout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save_Rout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_Rout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Rout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Save_Rout.Location = new System.Drawing.Point(782, 517);
            this.btn_Save_Rout.Name = "btn_Save_Rout";
            this.btn_Save_Rout.Size = new System.Drawing.Size(103, 51);
            this.btn_Save_Rout.TabIndex = 17;
            this.btn_Save_Rout.Text = "Enregistrer";
            this.btn_Save_Rout.UseVisualStyleBackColor = false;
            this.btn_Save_Rout.Visible = false;
            this.btn_Save_Rout.Click += new System.EventHandler(this.btn_Save_Rout_Click);
            // 
            // grp_aj_d_r
            // 
            this.grp_aj_d_r.Controls.Add(this.btn_selection_manuelle_r);
            this.grp_aj_d_r.Controls.Add(this.groupBox10);
            this.grp_aj_d_r.Controls.Add(this.btn_ajouter_danse_r);
            this.grp_aj_d_r.Controls.Add(this.groupBox11);
            this.grp_aj_d_r.Controls.Add(this.Nup_Nb_r);
            this.grp_aj_d_r.Controls.Add(this.label17);
            this.grp_aj_d_r.Controls.Add(this.label18);
            this.grp_aj_d_r.Controls.Add(this.cmb_Danses_r);
            this.grp_aj_d_r.Font = new System.Drawing.Font("Arimo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_aj_d_r.Location = new System.Drawing.Point(451, 6);
            this.grp_aj_d_r.Name = "grp_aj_d_r";
            this.grp_aj_d_r.Size = new System.Drawing.Size(596, 123);
            this.grp_aj_d_r.TabIndex = 16;
            this.grp_aj_d_r.TabStop = false;
            this.grp_aj_d_r.Text = "Ajouter une partie";
            this.grp_aj_d_r.Visible = false;
            // 
            // btn_selection_manuelle_r
            // 
            this.btn_selection_manuelle_r.BackColor = System.Drawing.Color.Turquoise;
            this.btn_selection_manuelle_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selection_manuelle_r.Location = new System.Drawing.Point(529, 69);
            this.btn_selection_manuelle_r.Name = "btn_selection_manuelle_r";
            this.btn_selection_manuelle_r.Size = new System.Drawing.Size(58, 48);
            this.btn_selection_manuelle_r.TabIndex = 15;
            this.btn_selection_manuelle_r.Text = "≡";
            this.btn_selection_manuelle_r.UseVisualStyleBackColor = false;
            this.btn_selection_manuelle_r.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rdb_Aleatoire);
            this.groupBox10.Controls.Add(this.rdb_Descroissant);
            this.groupBox10.Controls.Add(this.rdb_Croissant);
            this.groupBox10.Location = new System.Drawing.Point(196, 68);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(327, 49);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Organisation des musiques";
            // 
            // rdb_Aleatoire
            // 
            this.rdb_Aleatoire.AutoSize = true;
            this.rdb_Aleatoire.Checked = true;
            this.rdb_Aleatoire.Location = new System.Drawing.Point(9, 21);
            this.rdb_Aleatoire.Name = "rdb_Aleatoire";
            this.rdb_Aleatoire.Size = new System.Drawing.Size(85, 20);
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
            this.rdb_Descroissant.Size = new System.Drawing.Size(111, 20);
            this.rdb_Descroissant.TabIndex = 0;
            this.rdb_Descroissant.Text = "Descroissant";
            this.rdb_Descroissant.UseVisualStyleBackColor = true;
            // 
            // rdb_Croissant
            // 
            this.rdb_Croissant.AutoSize = true;
            this.rdb_Croissant.Location = new System.Drawing.Point(108, 21);
            this.rdb_Croissant.Name = "rdb_Croissant";
            this.rdb_Croissant.Size = new System.Drawing.Size(89, 20);
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
            this.btn_ajouter_danse_r.Click += new System.EventHandler(this.btn_ajouter_danse_r_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.Nup_Min_Rout);
            this.groupBox11.Controls.Add(this.Nup_Max_Rout);
            this.groupBox11.Location = new System.Drawing.Point(196, 11);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(327, 54);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Rythme (bpm)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Maximum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Minimum";
            // 
            // Nup_Min_Rout
            // 
            this.Nup_Min_Rout.Location = new System.Drawing.Point(89, 24);
            this.Nup_Min_Rout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Nup_Min_Rout.Name = "Nup_Min_Rout";
            this.Nup_Min_Rout.Size = new System.Drawing.Size(77, 23);
            this.Nup_Min_Rout.TabIndex = 11;
            this.Nup_Min_Rout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nup_Min_Rout.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Nup_Max_Rout
            // 
            this.Nup_Max_Rout.Location = new System.Drawing.Point(244, 24);
            this.Nup_Max_Rout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Nup_Max_Rout.Name = "Nup_Max_Rout";
            this.Nup_Max_Rout.Size = new System.Drawing.Size(77, 23);
            this.Nup_Max_Rout.TabIndex = 12;
            this.Nup_Max_Rout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nup_Max_Rout.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Nup_Nb_r
            // 
            this.Nup_Nb_r.Location = new System.Drawing.Point(60, 90);
            this.Nup_Nb_r.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nup_Nb_r.Name = "Nup_Nb_r";
            this.Nup_Nb_r.Size = new System.Drawing.Size(77, 23);
            this.Nup_Nb_r.TabIndex = 9;
            this.Nup_Nb_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nup_Nb_r.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Nombre de musique";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "Style de danse";
            // 
            // cmb_Danses_r
            // 
            this.cmb_Danses_r.FormattingEnabled = true;
            this.cmb_Danses_r.Location = new System.Drawing.Point(6, 41);
            this.cmb_Danses_r.Name = "cmb_Danses_r";
            this.cmb_Danses_r.Size = new System.Drawing.Size(184, 24);
            this.cmb_Danses_r.TabIndex = 6;
            // 
            // lst_Musique_Manuelle_View
            // 
            this.lst_Musique_Manuelle_View.Font = new System.Drawing.Font("Arimo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Musique_Manuelle_View.FormattingEnabled = true;
            this.lst_Musique_Manuelle_View.HorizontalScrollbar = true;
            this.lst_Musique_Manuelle_View.ItemHeight = 16;
            this.lst_Musique_Manuelle_View.Location = new System.Drawing.Point(736, 147);
            this.lst_Musique_Manuelle_View.Name = "lst_Musique_Manuelle_View";
            this.lst_Musique_Manuelle_View.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Musique_Manuelle_View.Size = new System.Drawing.Size(311, 180);
            this.lst_Musique_Manuelle_View.TabIndex = 15;
            this.lst_Musique_Manuelle_View.Visible = false;
            // 
            // grp_selec_rout
            // 
            this.grp_selec_rout.Controls.Add(this.btn_Suppr_Routine);
            this.grp_selec_rout.Controls.Add(this.lbl_ou);
            this.grp_selec_rout.Controls.Add(this.btn_nouvelle_routine);
            this.grp_selec_rout.Controls.Add(this.label11);
            this.grp_selec_rout.Controls.Add(this.cmb_routine);
            this.grp_selec_rout.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_selec_rout.Location = new System.Drawing.Point(9, 6);
            this.grp_selec_rout.Name = "grp_selec_rout";
            this.grp_selec_rout.Size = new System.Drawing.Size(432, 103);
            this.grp_selec_rout.TabIndex = 14;
            this.grp_selec_rout.TabStop = false;
            this.grp_selec_rout.Text = "Les routines";
            // 
            // btn_Suppr_Routine
            // 
            this.btn_Suppr_Routine.BackColor = System.Drawing.Color.Red;
            this.btn_Suppr_Routine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Suppr_Routine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppr_Routine.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Suppr_Routine.Location = new System.Drawing.Point(267, 32);
            this.btn_Suppr_Routine.Name = "btn_Suppr_Routine";
            this.btn_Suppr_Routine.Size = new System.Drawing.Size(153, 51);
            this.btn_Suppr_Routine.TabIndex = 20;
            this.btn_Suppr_Routine.Text = "Supprimer";
            this.btn_Suppr_Routine.UseVisualStyleBackColor = false;
            this.btn_Suppr_Routine.Visible = false;
            this.btn_Suppr_Routine.Click += new System.EventHandler(this.btn_Suppr_Routine_Click);
            // 
            // lbl_ou
            // 
            this.lbl_ou.AutoSize = true;
            this.lbl_ou.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ou.Location = new System.Drawing.Point(220, 48);
            this.lbl_ou.Name = "lbl_ou";
            this.lbl_ou.Size = new System.Drawing.Size(28, 17);
            this.lbl_ou.TabIndex = 18;
            this.lbl_ou.Text = "Ou";
            // 
            // btn_nouvelle_routine
            // 
            this.btn_nouvelle_routine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_nouvelle_routine.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nouvelle_routine.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_nouvelle_routine.Location = new System.Drawing.Point(267, 32);
            this.btn_nouvelle_routine.Name = "btn_nouvelle_routine";
            this.btn_nouvelle_routine.Size = new System.Drawing.Size(153, 51);
            this.btn_nouvelle_routine.TabIndex = 17;
            this.btn_nouvelle_routine.Text = "Nouvelle routine";
            this.btn_nouvelle_routine.UseVisualStyleBackColor = false;
            this.btn_nouvelle_routine.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Vos routines :";
            // 
            // cmb_routine
            // 
            this.cmb_routine.FormattingEnabled = true;
            this.cmb_routine.Location = new System.Drawing.Point(17, 58);
            this.cmb_routine.Name = "cmb_routine";
            this.cmb_routine.Size = new System.Drawing.Size(184, 25);
            this.cmb_routine.TabIndex = 15;
            this.cmb_routine.SelectedIndexChanged += new System.EventHandler(this.cmb_routine_SelectedIndexChanged);
            // 
            // dataGridView_Routine
            // 
            this.dataGridView_Routine.AllowUserToAddRows = false;
            this.dataGridView_Routine.AllowUserToDeleteRows = false;
            this.dataGridView_Routine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Routine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_Routine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Routine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Auto,
            this.Col_Data_Danse,
            this.Col_Data_Quantite,
            this.Col_Data_Min,
            this.Col_Data_Max,
            this.Col_Data_Tri});
            this.dataGridView_Routine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Routine.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_Routine.Location = new System.Drawing.Point(9, 132);
            this.dataGridView_Routine.MultiSelect = false;
            this.dataGridView_Routine.Name = "dataGridView_Routine";
            this.dataGridView_Routine.ReadOnly = true;
            this.dataGridView_Routine.RowHeadersVisible = false;
            this.dataGridView_Routine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Routine.RowTemplate.Height = 24;
            this.dataGridView_Routine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Routine.Size = new System.Drawing.Size(721, 436);
            this.dataGridView_Routine.TabIndex = 13;
            this.dataGridView_Routine.SelectionChanged += new System.EventHandler(this.dataGridView_Routine_SelectionChanged);
            // 
            // Col_Auto
            // 
            this.Col_Auto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Col_Auto.Frozen = true;
            this.Col_Auto.HeaderText = "Automatique";
            this.Col_Auto.Name = "Col_Auto";
            this.Col_Auto.ReadOnly = true;
            this.Col_Auto.Width = 93;
            // 
            // Col_Data_Danse
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Data_Danse.DefaultCellStyle = dataGridViewCellStyle14;
            this.Col_Data_Danse.HeaderText = "Danse";
            this.Col_Data_Danse.Name = "Col_Data_Danse";
            this.Col_Data_Danse.ReadOnly = true;
            this.Col_Data_Danse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Data_Danse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Data_Quantite
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Data_Quantite.DefaultCellStyle = dataGridViewCellStyle15;
            this.Col_Data_Quantite.HeaderText = "Quantité";
            this.Col_Data_Quantite.Name = "Col_Data_Quantite";
            this.Col_Data_Quantite.ReadOnly = true;
            this.Col_Data_Quantite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Data_Quantite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Data_Min
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Data_Min.DefaultCellStyle = dataGridViewCellStyle16;
            this.Col_Data_Min.HeaderText = "Min";
            this.Col_Data_Min.Name = "Col_Data_Min";
            this.Col_Data_Min.ReadOnly = true;
            this.Col_Data_Min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Data_Max
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Data_Max.DefaultCellStyle = dataGridViewCellStyle17;
            this.Col_Data_Max.HeaderText = "Max";
            this.Col_Data_Max.Name = "Col_Data_Max";
            this.Col_Data_Max.ReadOnly = true;
            this.Col_Data_Max.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Data_Tri
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Data_Tri.DefaultCellStyle = dataGridViewCellStyle18;
            this.Col_Data_Tri.HeaderText = "Tri";
            this.Col_Data_Tri.Name = "Col_Data_Tri";
            this.Col_Data_Tri.ReadOnly = true;
            this.Col_Data_Tri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Data_Tri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Liste des danses :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_modif_False);
            this.tabPage4.Controls.Add(this.btn_modif_Ok);
            this.tabPage4.Controls.Add(this.btn_modifier);
            this.tabPage4.Controls.Add(this.grp_rep);
            this.tabPage4.Controls.Add(this.grp_tri);
            this.tabPage4.Controls.Add(this.grp_file_sep);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1053, 574);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_modif_False
            // 
            this.btn_modif_False.BackColor = System.Drawing.Color.Red;
            this.btn_modif_False.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif_False.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_modif_False.Location = new System.Drawing.Point(588, 333);
            this.btn_modif_False.Name = "btn_modif_False";
            this.btn_modif_False.Size = new System.Drawing.Size(103, 51);
            this.btn_modif_False.TabIndex = 18;
            this.btn_modif_False.Text = "Annuler";
            this.btn_modif_False.UseVisualStyleBackColor = false;
            this.btn_modif_False.Visible = false;
            this.btn_modif_False.Click += new System.EventHandler(this.btn_modif_False_Click);
            // 
            // btn_modif_Ok
            // 
            this.btn_modif_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_modif_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif_Ok.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_modif_Ok.Location = new System.Drawing.Point(447, 333);
            this.btn_modif_Ok.Name = "btn_modif_Ok";
            this.btn_modif_Ok.Size = new System.Drawing.Size(119, 51);
            this.btn_modif_Ok.TabIndex = 17;
            this.btn_modif_Ok.Text = "Enregistrer";
            this.btn_modif_Ok.UseVisualStyleBackColor = false;
            this.btn_modif_Ok.Visible = false;
            this.btn_modif_Ok.Click += new System.EventHandler(this.btn_modif_Ok_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_modifier.Location = new System.Drawing.Point(447, 333);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(119, 51);
            this.btn_modifier.TabIndex = 16;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // grp_rep
            // 
            this.grp_rep.Controls.Add(this.label19);
            this.grp_rep.Controls.Add(this.txt_Rep_Recherche2);
            this.grp_rep.Controls.Add(this.pic_folder);
            this.grp_rep.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_rep.Location = new System.Drawing.Point(17, 26);
            this.grp_rep.Name = "grp_rep";
            this.grp_rep.Size = new System.Drawing.Size(674, 123);
            this.grp_rep.TabIndex = 15;
            this.grp_rep.TabStop = false;
            this.grp_rep.Text = "Recherche par défaut :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(33, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(243, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "Repertoire de recherche par défaut :";
            // 
            // txt_Rep_Recherche2
            // 
            this.txt_Rep_Recherche2.Enabled = false;
            this.txt_Rep_Recherche2.Location = new System.Drawing.Point(36, 65);
            this.txt_Rep_Recherche2.Name = "txt_Rep_Recherche2";
            this.txt_Rep_Recherche2.ReadOnly = true;
            this.txt_Rep_Recherche2.Size = new System.Drawing.Size(483, 25);
            this.txt_Rep_Recherche2.TabIndex = 10;
            this.txt_Rep_Recherche2.TextChanged += new System.EventHandler(this.txt_Rep_Recherche2_TextChanged);
            // 
            // pic_folder
            // 
            this.pic_folder.Image = ((System.Drawing.Image)(resources.GetObject("pic_folder.Image")));
            this.pic_folder.Location = new System.Drawing.Point(543, 51);
            this.pic_folder.Name = "pic_folder";
            this.pic_folder.Size = new System.Drawing.Size(45, 39);
            this.pic_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_folder.TabIndex = 12;
            this.pic_folder.TabStop = false;
            this.pic_folder.Visible = false;
            this.pic_folder.Click += new System.EventHandler(this.pic_folder_Click);
            this.pic_folder.MouseLeave += new System.EventHandler(this.pic_folder_MouseLeave);
            this.pic_folder.MouseHover += new System.EventHandler(this.pic_folder_MouseHover);
            // 
            // grp_tri
            // 
            this.grp_tri.Controls.Add(this.rdb_Aucune);
            this.grp_tri.Controls.Add(this.rdb_mpm);
            this.grp_tri.Controls.Add(this.rdb_bpm);
            this.grp_tri.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_tri.Location = new System.Drawing.Point(352, 178);
            this.grp_tri.Name = "grp_tri";
            this.grp_tri.Size = new System.Drawing.Size(339, 149);
            this.grp_tri.TabIndex = 10;
            this.grp_tri.TabStop = false;
            this.grp_tri.Text = "Unité de tri :";
            // 
            // rdb_Aucune
            // 
            this.rdb_Aucune.AutoSize = true;
            this.rdb_Aucune.Location = new System.Drawing.Point(39, 106);
            this.rdb_Aucune.Name = "rdb_Aucune";
            this.rdb_Aucune.Size = new System.Drawing.Size(148, 21);
            this.rdb_Aucune.TabIndex = 5;
            this.rdb_Aucune.Text = "Aucune (Aléatoire)";
            this.rdb_Aucune.UseVisualStyleBackColor = true;
            // 
            // rdb_mpm
            // 
            this.rdb_mpm.AutoSize = true;
            this.rdb_mpm.Location = new System.Drawing.Point(39, 70);
            this.rdb_mpm.Name = "rdb_mpm";
            this.rdb_mpm.Size = new System.Drawing.Size(196, 21);
            this.rdb_mpm.TabIndex = 4;
            this.rdb_mpm.Text = "Mesure par minute (MPM)";
            this.rdb_mpm.UseVisualStyleBackColor = true;
            // 
            // rdb_bpm
            // 
            this.rdb_bpm.AutoSize = true;
            this.rdb_bpm.Checked = true;
            this.rdb_bpm.Location = new System.Drawing.Point(39, 34);
            this.rdb_bpm.Name = "rdb_bpm";
            this.rdb_bpm.Size = new System.Drawing.Size(214, 21);
            this.rdb_bpm.TabIndex = 3;
            this.rdb_bpm.TabStop = true;
            this.rdb_bpm.Text = "Battement par minute (BPM)";
            this.rdb_bpm.UseVisualStyleBackColor = true;
            // 
            // grp_file_sep
            // 
            this.grp_file_sep.Controls.Add(this.rad_slash);
            this.grp_file_sep.Controls.Add(this.rad_backslash);
            this.grp_file_sep.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_file_sep.Location = new System.Drawing.Point(17, 178);
            this.grp_file_sep.Name = "grp_file_sep";
            this.grp_file_sep.Size = new System.Drawing.Size(308, 149);
            this.grp_file_sep.TabIndex = 9;
            this.grp_file_sep.TabStop = false;
            this.grp_file_sep.Text = "Système d\'exploitation du lecteur :";
            // 
            // rad_slash
            // 
            this.rad_slash.AutoSize = true;
            this.rad_slash.Location = new System.Drawing.Point(42, 92);
            this.rad_slash.Name = "rad_slash";
            this.rad_slash.Size = new System.Drawing.Size(234, 21);
            this.rad_slash.TabIndex = 1;
            this.rad_slash.TabStop = true;
            this.rad_slash.Text = "Système Androïd, Apple ou Unix";
            this.rad_slash.UseVisualStyleBackColor = true;
            // 
            // rad_backslash
            // 
            this.rad_backslash.AutoSize = true;
            this.rad_backslash.Location = new System.Drawing.Point(42, 44);
            this.rad_backslash.Name = "rad_backslash";
            this.rad_backslash.Size = new System.Drawing.Size(152, 21);
            this.rad_backslash.TabIndex = 0;
            this.rad_backslash.TabStop = true;
            this.rad_backslash.Text = "Système Windows";
            this.rad_backslash.UseVisualStyleBackColor = true;
            // 
            // Application_Fen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 610);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Application_Fen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Application_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grp_playlist.ResumeLayout(false);
            this.grp_playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Apperçu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Nb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grp_opt_r.ResumeLayout(false);
            this.grp_aj_d_r.ResumeLayout(false);
            this.grp_aj_d_r.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Min_Rout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Max_Rout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Nb_r)).EndInit();
            this.grp_selec_rout.ResumeLayout(false);
            this.grp_selec_rout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Routine)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grp_rep.ResumeLayout(false);
            this.grp_rep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_folder)).EndInit();
            this.grp_tri.ResumeLayout(false);
            this.grp_tri.PerformLayout();
            this.grp_file_sep.ResumeLayout(false);
            this.grp_file_sep.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox grp_playlist;
        private ListView listW_Danse_List;
        private ColumnHeader Col_Null;
        private ColumnHeader Col_Danse;
        private ColumnHeader Col_Min;
        private ColumnHeader Col_Max2;
        private GroupBox groupBox4;
        private Button btn_ajouter_danse;
        private Button btn_selection_manuelle;
        private GroupBox groupBox5;
        private Label label8;
        private Label label7;
        private NumericUpDown Nup_Min;
        private NumericUpDown Nup_Max;
        private NumericUpDown Nup_Nb;
        private Label label6;
        private Label label5;
        private ComboBox cmb_Danses;
        private GroupBox groupBox2;
        private Button btn_delete_selection;
        private Button btn_add_to_danse;
        private Button btn_music_desc;
        private Button btn_musique_asc;
        private Button btn_reload_select;
        private Button btn_Shuffle;
        private Button btn_selection_down;
        private Button btn_selection_up;
        private GroupBox groupBox1;
        private Button btn_change_danse;
        private Button btn_delete_danse;
        private Button btn_music_down;
        private Button btn_music_up;
        private Button btn_reload_all;
        private Label label4;
        private ListBox list_Musiques;
        private Label label3;
        private Button btn_save;
        private Button btn_reset;
        private TreeView treeView1;
        private Button btn_folder_select;
        private Label label1;
        private TextBox txt_Rep_Recherche;
        private GroupBox groupBox3;
        private Label label9;
        private Label label2;
        private Label lbl_danse_f;
        private Label lbl_music_f_r;
        private Label lbl_music_f;
        private Label label16;
        private Label lbl_playlist;
        private Label label15;
        private Label lbl_routine_f;
        private Label label10;
        private DataGridView dataGridView_Routine;
        private DataGridViewTextBoxColumn idDanseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDeDanseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vitesseMinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vitesseMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordreTriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDanseDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn selectionManuelleDataGridViewCheckBoxColumn;
        private GroupBox grp_selec_rout;
        private Label label11;
        private ComboBox cmb_routine;
        private Button btn_nouvelle_routine;
        private Label lbl_ou;
        private GroupBox grp_file_sep;
        private RadioButton rad_slash;
        private RadioButton rad_backslash;
        private GroupBox grp_tri;
        private ListBox lst_Musique_Manuelle_View;
        private GroupBox grp_aj_d_r;
        private Button btn_selection_manuelle_r;
        private GroupBox groupBox10;
        private RadioButton rdb_Aleatoire;
        private RadioButton rdb_Descroissant;
        private RadioButton rdb_Croissant;
        private Button btn_ajouter_danse_r;
        private GroupBox groupBox11;
        private Label label13;
        private Label label14;
        private NumericUpDown Nup_Min_Rout;
        private NumericUpDown Nup_Max_Rout;
        private NumericUpDown Nup_Nb_r;
        private Label label17;
        private Label label18;
        private ComboBox cmb_Danses_r;
        private GroupBox grp_rep;
        private Label label19;
        private TextBox txt_Rep_Recherche2;
        private PictureBox pic_folder;
        private RadioButton rdb_Aucune;
        private RadioButton rdb_mpm;
        private RadioButton rdb_bpm;
        private Button btn_modif_False;
        private Button btn_modif_Ok;
        private Button btn_modifier;
        private PictureBox pic_Apperçu;
        private Button btn_Fermer;
        private Button btn_Save_Rout;
        private GroupBox grp_opt_r;
        private Button button5;
        private Button btn_Danse_Down_r;
        private Button btn_Danse_Up_r;
        private Button button4;
        private Label lbl_selec;
        private DataGridViewCheckBoxColumn Col_Auto;
        private DataGridViewTextBoxColumn Col_Data_Danse;
        private DataGridViewTextBoxColumn Col_Data_Quantite;
        private DataGridViewTextBoxColumn Col_Data_Min;
        private DataGridViewTextBoxColumn Col_Data_Max;
        private DataGridViewTextBoxColumn Col_Data_Tri;
        private Button btn_Suppr_Routine;
        private Label lbl_durée_musique;
        private Button btn_load_rout;
    }
}