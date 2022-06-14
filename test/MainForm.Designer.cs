using System.Windows.Forms;

namespace test
{
    partial class MainForm
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
            this.btn_letovi = new System.Windows.Forms.Button();
            this.btn_radnici = new System.Windows.Forms.Button();
            this.btn_putnici = new System.Windows.Forms.Button();
            this.chk_pilot = new System.Windows.Forms.CheckBox();
            this.gb_kontrole = new System.Windows.Forms.GroupBox();
            this.btn_aeorodromi = new System.Windows.Forms.Button();
            this.btn_avioni = new System.Windows.Forms.Button();
            this.rb_putnik = new System.Windows.Forms.RadioButton();
            this.rb_radnik = new System.Windows.Forms.RadioButton();
            this.rb_let = new System.Windows.Forms.RadioButton();
            this.rb_avion = new System.Windows.Forms.RadioButton();
            this.rb_aerodrom = new System.Windows.Forms.RadioButton();
            this.lv_prikaz = new System.Windows.Forms.ListView();
            this.gb_modify = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.gb_kontrole.SuspendLayout();
            this.gb_modify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_letovi
            // 
            this.btn_letovi.Location = new System.Drawing.Point(21, 40);
            this.btn_letovi.Name = "btn_letovi";
            this.btn_letovi.Size = new System.Drawing.Size(75, 23);
            this.btn_letovi.TabIndex = 1;
            this.btn_letovi.Text = "Letovi";
            this.btn_letovi.UseVisualStyleBackColor = true;
            this.btn_letovi.Click += new System.EventHandler(this.btn_letovi_Click);
            // 
            // btn_radnici
            // 
            this.btn_radnici.Location = new System.Drawing.Point(371, 309);
            this.btn_radnici.Name = "btn_radnici";
            this.btn_radnici.Size = new System.Drawing.Size(75, 23);
            this.btn_radnici.TabIndex = 2;
            this.btn_radnici.Text = "Radnici";
            this.btn_radnici.UseVisualStyleBackColor = true;
            this.btn_radnici.Click += new System.EventHandler(this.btn_radnici_Click);
            // 
            // btn_putnici
            // 
            this.btn_putnici.Location = new System.Drawing.Point(511, 309);
            this.btn_putnici.Name = "btn_putnici";
            this.btn_putnici.Size = new System.Drawing.Size(75, 23);
            this.btn_putnici.TabIndex = 3;
            this.btn_putnici.Text = "Putnici";
            this.btn_putnici.UseVisualStyleBackColor = true;
            this.btn_putnici.Click += new System.EventHandler(this.btn_putnici_Click);
            // 
            // chk_pilot
            // 
            this.chk_pilot.AutoSize = true;
            this.chk_pilot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_pilot.Location = new System.Drawing.Point(371, 286);
            this.chk_pilot.Name = "chk_pilot";
            this.chk_pilot.Size = new System.Drawing.Size(77, 17);
            this.chk_pilot.TabIndex = 4;
            this.chk_pilot.Text = "Samo piloti";
            this.chk_pilot.UseVisualStyleBackColor = true;
            // 
            // gb_kontrole
            // 
            this.gb_kontrole.Controls.Add(this.btn_aeorodromi);
            this.gb_kontrole.Controls.Add(this.btn_avioni);
            this.gb_kontrole.Controls.Add(this.btn_letovi);
            this.gb_kontrole.Controls.Add(this.rb_putnik);
            this.gb_kontrole.Controls.Add(this.rb_radnik);
            this.gb_kontrole.Controls.Add(this.rb_let);
            this.gb_kontrole.Controls.Add(this.rb_avion);
            this.gb_kontrole.Controls.Add(this.rb_aerodrom);
            this.gb_kontrole.Location = new System.Drawing.Point(199, 269);
            this.gb_kontrole.Name = "gb_kontrole";
            this.gb_kontrole.Size = new System.Drawing.Size(406, 133);
            this.gb_kontrole.TabIndex = 5;
            this.gb_kontrole.TabStop = false;
            this.gb_kontrole.Text = "Kontrole";
            this.gb_kontrole.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_aeorodromi
            // 
            this.btn_aeorodromi.Location = new System.Drawing.Point(244, 89);
            this.btn_aeorodromi.Name = "btn_aeorodromi";
            this.btn_aeorodromi.Size = new System.Drawing.Size(75, 23);
            this.btn_aeorodromi.TabIndex = 1;
            this.btn_aeorodromi.Text = "Aerodromi";
            this.btn_aeorodromi.UseVisualStyleBackColor = true;
            this.btn_aeorodromi.Click += new System.EventHandler(this.btn_aeorodromi_Click);
            // 
            // btn_avioni
            // 
            this.btn_avioni.Location = new System.Drawing.Point(99, 89);
            this.btn_avioni.Name = "btn_avioni";
            this.btn_avioni.Size = new System.Drawing.Size(75, 23);
            this.btn_avioni.TabIndex = 0;
            this.btn_avioni.Text = "Avioni";
            this.btn_avioni.UseVisualStyleBackColor = true;
            this.btn_avioni.Click += new System.EventHandler(this.btn_avioni_Click);
            // 
            // rb_putnik
            // 
            this.rb_putnik.AutoSize = true;
            this.rb_putnik.Location = new System.Drawing.Point(342, 44);
            this.rb_putnik.Name = "rb_putnik";
            this.rb_putnik.Size = new System.Drawing.Size(14, 13);
            this.rb_putnik.TabIndex = 4;
            this.rb_putnik.TabStop = true;
            this.rb_putnik.UseVisualStyleBackColor = true;
            // 
            // rb_radnik
            // 
            this.rb_radnik.AutoSize = true;
            this.rb_radnik.Location = new System.Drawing.Point(199, 44);
            this.rb_radnik.Name = "rb_radnik";
            this.rb_radnik.Size = new System.Drawing.Size(14, 13);
            this.rb_radnik.TabIndex = 3;
            this.rb_radnik.TabStop = true;
            this.rb_radnik.UseVisualStyleBackColor = true;
            // 
            // rb_let
            // 
            this.rb_let.AutoSize = true;
            this.rb_let.Location = new System.Drawing.Point(48, 50);
            this.rb_let.Name = "rb_let";
            this.rb_let.Size = new System.Drawing.Size(14, 13);
            this.rb_let.TabIndex = 2;
            this.rb_let.TabStop = true;
            this.rb_let.UseVisualStyleBackColor = true;
            // 
            // rb_avion
            // 
            this.rb_avion.AutoSize = true;
            this.rb_avion.Location = new System.Drawing.Point(127, 95);
            this.rb_avion.Name = "rb_avion";
            this.rb_avion.Size = new System.Drawing.Size(14, 13);
            this.rb_avion.TabIndex = 5;
            this.rb_avion.TabStop = true;
            this.rb_avion.UseVisualStyleBackColor = true;
            // 
            // rb_aerodrom
            // 
            this.rb_aerodrom.AutoSize = true;
            this.rb_aerodrom.Location = new System.Drawing.Point(272, 94);
            this.rb_aerodrom.Name = "rb_aerodrom";
            this.rb_aerodrom.Size = new System.Drawing.Size(14, 13);
            this.rb_aerodrom.TabIndex = 6;
            this.rb_aerodrom.TabStop = true;
            this.rb_aerodrom.UseVisualStyleBackColor = true;
            // 
            // lv_prikaz
            // 
            this.lv_prikaz.FullRowSelect = true;
            this.lv_prikaz.GridLines = true;
            this.lv_prikaz.HideSelection = false;
            this.lv_prikaz.Location = new System.Drawing.Point(220, 12);
            this.lv_prikaz.MultiSelect = false;
            this.lv_prikaz.Name = "lv_prikaz";
            this.lv_prikaz.Size = new System.Drawing.Size(366, 251);
            this.lv_prikaz.TabIndex = 6;
            this.lv_prikaz.UseCompatibleStateImageBehavior = false;
            this.lv_prikaz.View = System.Windows.Forms.View.Details;
            this.lv_prikaz.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_prikaz_ItemSelectionChanged);
            // 
            // gb_modify
            // 
            this.gb_modify.Controls.Add(this.btn_add);
            this.gb_modify.Controls.Add(this.btn_delete);
            this.gb_modify.Controls.Add(this.btn_edit);
            this.gb_modify.Location = new System.Drawing.Point(29, 38);
            this.gb_modify.Name = "gb_modify";
            this.gb_modify.Size = new System.Drawing.Size(133, 208);
            this.gb_modify.TabIndex = 7;
            this.gb_modify.TabStop = false;
            this.gb_modify.Text = "Modifikacija";
            this.gb_modify.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(28, 44);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Dodaj";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(28, 151);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Obriši";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(28, 97);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Izmjena";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_prikaz);
            this.Controls.Add(this.chk_pilot);
            this.Controls.Add(this.btn_putnici);
            this.Controls.Add(this.btn_radnici);
            this.Controls.Add(this.gb_kontrole);
            this.Controls.Add(this.gb_modify);
            this.Name = "MainForm";
            this.Text = "Aviokompanija";
            this.gb_kontrole.ResumeLayout(false);
            this.gb_kontrole.PerformLayout();
            this.gb_modify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_letovi;
        private System.Windows.Forms.Button btn_radnici;
        private System.Windows.Forms.Button btn_putnici;
        private System.Windows.Forms.CheckBox chk_pilot;
        private System.Windows.Forms.GroupBox gb_kontrole;
        private System.Windows.Forms.ListView lv_prikaz;
        private Button btn_aeorodromi;
        private Button btn_avioni;
        private GroupBox gb_modify;
        private Button btn_delete;
        private Button btn_edit;
        private RadioButton rb_let;
        private RadioButton rb_putnik;
        private RadioButton rb_radnik;
        private RadioButton rb_avion;
        private RadioButton rb_aerodrom;
        private Button btn_add;
    }
}

