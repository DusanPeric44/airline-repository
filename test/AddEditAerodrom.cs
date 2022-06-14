using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AddEditAerodrom : Form
    {
        private string connStr = "server=localhost;database=aviokompanija;uid=root;pwd=;";
        private string[] properties;
        private bool isUpdate;
        private int id;
        //konstruktor za dodavanje
        public AddEditAerodrom()
        {
            InitializeComponent();
            this.Text = "Dodaj aerodrom";
            this.isUpdate = false;
        }
        //konstruktor za izmjenu
        public AddEditAerodrom(string[] properties)
        {
            InitializeComponent();
            this.Text = "Izmijeni aerodrom";
            this.isUpdate = true;
            this.properties = properties;
            this.id = int.Parse(properties[0]);
            TextBox[] textBoxes = { tb_ime, tb_grad, tb_zemlja };
            for (int i = 1; i < textBoxes.Length+1; i++)
            {
                int j = i - 1;
                textBoxes[j].Text = properties[i];
            }
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //validacija textbox-ova
            if (string.IsNullOrEmpty(tb_ime.Text) || string.IsNullOrEmpty(tb_grad.Text)
                || string.IsNullOrEmpty(tb_zemlja.Text))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                if (string.IsNullOrEmpty(tb_ime.Text))
                {
                    tb_ime.Focus();
                    errorProvider1.SetError(tb_ime, "Molimo vas upisite ime!");
                }
                if (string.IsNullOrEmpty(tb_grad.Text))
                {
                    tb_grad.Focus();
                    errorProvider2.SetError(tb_grad, "Molimo vas upisite grad!");
                }
                if (string.IsNullOrEmpty(tb_zemlja.Text))
                {
                    tb_zemlja.Focus();
                    errorProvider3.SetError(tb_zemlja, "Molimo vas upisite zemlju!");
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string commStr = "";
                if (isUpdate)
                {
                    commStr = string.Format("UPDATE Aerodrom SET ime = '{0}', grad = '{1}', zemlja = '{2}' WHERE id_aerodrom = {3};",
                    tb_ime.Text, tb_grad.Text, tb_zemlja.Text, this.id);
                }
                else
                {
                    commStr = string.Format("INSERT INTO Aerodrom(ime, grad, zemlja) VALUES('{0}', '{1}', '{2}');",
                    tb_ime.Text, tb_grad.Text, tb_zemlja.Text);
                }
                MySqlCommand command = new MySqlCommand(commStr, conn);

                var add = command.ExecuteScalar();
                conn.Close();
                this.Close();
            }
        }
    }
}
