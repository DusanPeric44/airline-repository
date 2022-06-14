namespace test
{
    partial class AddEditLet
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_cijenaKarte = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_polazniAerodrom = new System.Windows.Forms.ComboBox();
            this.cb_pilot = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_avion = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dt_vrijemePoletanja = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sifra = new System.Windows.Forms.TextBox();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_cijenaKarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cijena karte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Polazni aerodrom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vrijeme poletanja";
            // 
            // num_cijenaKarte
            // 
            this.num_cijenaKarte.DecimalPlaces = 2;
            this.num_cijenaKarte.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_cijenaKarte.Location = new System.Drawing.Point(114, 236);
            this.num_cijenaKarte.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_cijenaKarte.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_cijenaKarte.Name = "num_cijenaKarte";
            this.num_cijenaKarte.Size = new System.Drawing.Size(121, 20);
            this.num_cijenaKarte.TabIndex = 4;
            this.num_cijenaKarte.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pilot";
            // 
            // cb_polazniAerodrom
            // 
            this.cb_polazniAerodrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_polazniAerodrom.FormattingEnabled = true;
            this.cb_polazniAerodrom.Location = new System.Drawing.Point(114, 118);
            this.cb_polazniAerodrom.Name = "cb_polazniAerodrom";
            this.cb_polazniAerodrom.Size = new System.Drawing.Size(121, 21);
            this.cb_polazniAerodrom.TabIndex = 6;
            // 
            // cb_pilot
            // 
            this.cb_pilot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pilot.FormattingEnabled = true;
            this.cb_pilot.Location = new System.Drawing.Point(114, 197);
            this.cb_pilot.Name = "cb_pilot";
            this.cb_pilot.Size = new System.Drawing.Size(121, 21);
            this.cb_pilot.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Avion";
            // 
            // cb_avion
            // 
            this.cb_avion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_avion.FormattingEnabled = true;
            this.cb_avion.Location = new System.Drawing.Point(114, 274);
            this.cb_avion.Name = "cb_avion";
            this.cb_avion.Size = new System.Drawing.Size(121, 21);
            this.cb_avion.TabIndex = 10;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(124, 337);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(115, 23);
            this.btn_ok.TabIndex = 14;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dt_vrijemePoletanja
            // 
            this.dt_vrijemePoletanja.Location = new System.Drawing.Point(114, 161);
            this.dt_vrijemePoletanja.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dt_vrijemePoletanja.Name = "dt_vrijemePoletanja";
            this.dt_vrijemePoletanja.Size = new System.Drawing.Size(139, 20);
            this.dt_vrijemePoletanja.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sifra leta";
            // 
            // tb_sifra
            // 
            this.tb_sifra.Location = new System.Drawing.Point(114, 82);
            this.tb_sifra.Name = "tb_sifra";
            this.tb_sifra.Size = new System.Drawing.Size(139, 20);
            this.tb_sifra.TabIndex = 17;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(259, 79);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(54, 23);
            this.btn_generate.TabIndex = 18;
            this.btn_generate.Text = "Generiši";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // AddEditLet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_sifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_vrijemePoletanja);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cb_avion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_pilot);
            this.Controls.Add(this.cb_polazniAerodrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_cijenaKarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditLet";
            this.Text = "AddEditLet";
            ((System.ComponentModel.ISupportInitialize)(this.num_cijenaKarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_cijenaKarte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_polazniAerodrom;
        private System.Windows.Forms.ComboBox cb_pilot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_avion;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DateTimePicker dt_vrijemePoletanja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.TextBox tb_sifra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button btn_generate;
    }
}