namespace test
{
    partial class AddEditAerodrom
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
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_grad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_zemlja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(82, 65);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(158, 20);
            this.tb_ime.TabIndex = 1;
            // 
            // tb_grad
            // 
            this.tb_grad.Location = new System.Drawing.Point(82, 105);
            this.tb_grad.Name = "tb_grad";
            this.tb_grad.Size = new System.Drawing.Size(158, 20);
            this.tb_grad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grad";
            // 
            // tb_zemlja
            // 
            this.tb_zemlja.Location = new System.Drawing.Point(82, 148);
            this.tb_zemlja.Name = "tb_zemlja";
            this.tb_zemlja.Size = new System.Drawing.Size(158, 20);
            this.tb_zemlja.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zemlja";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(100, 198);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(115, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
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
            // AddEditAerodrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 355);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_zemlja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_grad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label1);
            this.Name = "AddEditAerodrom";
            this.Text = "Aerodrom";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_grad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_zemlja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}