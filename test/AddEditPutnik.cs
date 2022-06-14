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
    public partial class AddEditPutnik : Form
    {
        private string connStr = "server=localhost;database=aviokompanija;uid=root;pwd=;";
        private string[] properties;
        private bool isUpdate = false;
        private int id;

        private string[] getSerijski()
        {
            MySqlConnection cn = new MySqlConnection(connStr);
            cn.Open();
            MySqlCommand command = new MySqlCommand("SELECT sifra_leta FROM let", cn);
            List<string> brojevi = new List<string>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    brojevi.Add(reader.GetString(0));
                }
            }
            cn.Close();
            return brojevi.ToArray<string>();
        }
        private int getID(string sifra)
        {
            MySqlConnection cn = new MySqlConnection(connStr);
            cn.Open();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT id_let FROM let WHERE sifra_leta = '{0}'", sifra), cn);
            List<string> id = new List<string>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    id.Add(reader.GetString(0));
                }
            }
            cn.Close();
            //vracamo prvi clan jer je sifra_leta unique, pa moze biti samo jedan
            return int.Parse(id[0]);
        }
        private short pol()
        {
            if (rb_zensko.Checked)
                return 0;
            if (rb_musko.Checked)
                return 1;
            return 0;
        }
        public AddEditPutnik()
        {
            InitializeComponent();
            this.isUpdate = false;
            this.Text = "Dodaj putnika";
            combo_sifra.Items.AddRange(getSerijski());
        }
        public AddEditPutnik(string[] properties)
        {
            InitializeComponent();
            this.Text = "Izmijeni putnika";
            this.isUpdate = true;
            this.properties = properties;
            this.id = int.Parse(properties[0]);
            combo_sifra.Items.AddRange(getSerijski());

            TextBox[] textBoxes = { tb_ime, tb_prezime, tb_adresa, tb_grad, tb_telefon };
            for (int i = 1, j = 0; i < textBoxes.Length + 1; i++, j++)
            {
                if (i == 3)
                {
                    if (properties[i] == "Musko")
                    {
                        rb_musko.Checked = true;
                    }
                    else
                    {
                        rb_zensko.Checked = true;
                    }
                    textBoxes[j].Text = properties[i + 1];
                    continue;
                }
                else if (i > 3)
                {
                    textBoxes[j].Text = properties[i + 1];
                    continue;
                }
                textBoxes[j].Text = properties[i];
            }
            combo_sifra.SelectedItem = properties[properties.Length - 1];
            
        }
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ime.Text) || string.IsNullOrEmpty(tb_prezime.Text)
                || string.IsNullOrEmpty(tb_adresa.Text)
                || string.IsNullOrEmpty(tb_grad.Text) ||
                string.IsNullOrEmpty(tb_telefon.Text) || !(rb_musko.Checked || rb_zensko.Checked)
                || (combo_sifra.SelectedIndex == -1)) 
            {
                #region Validacija
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
                if (string.IsNullOrEmpty(tb_ime.Text))
                {
                    tb_ime.Focus();
                    errorProvider1.SetError(tb_ime, "Molimo vas upisite ime!");
                }
                if (string.IsNullOrEmpty(tb_prezime.Text))
                {
                    tb_prezime.Focus();
                    errorProvider2.SetError(tb_prezime, "Molimo vas upisite prezime!");
                }
                if (string.IsNullOrEmpty(tb_adresa.Text))
                {
                    tb_adresa.Focus();
                    errorProvider3.SetError(tb_adresa, "Molimo vas upisite adresu!");
                }
                if (string.IsNullOrEmpty(tb_grad.Text))
                {
                    tb_grad.Focus();
                    errorProvider4.SetError(tb_grad, "Molimo vas upisite grad!");
                }
                if (string.IsNullOrEmpty(tb_telefon.Text))
                {
                    tb_telefon.Focus();
                    errorProvider5.SetError(tb_telefon, "Molimo vas upisite broj telefona!");
                }
                if (rb_musko.Checked || rb_zensko.Checked)
                {
                    errorProvider6.SetError(rb_musko, "Molimo vas odaberite pol!");
                }
                if(combo_sifra.SelectedIndex == -1)
                {
                    errorProvider6.SetError(combo_sifra, "Molimo vas odaberite let!");
                }
                #endregion
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string commStr = "";
                if (isUpdate)
                {
                    commStr = string.Format("UPDATE putnik SET ime = '{0}', " +
                        "prezime = '{1}', pol = {2}, adresa = '{3}', " +
                        "grad = '{4}', telefon = '{5}', " +
                        "id_let = {6} WHERE id_putnik = {7};",
                    tb_ime.Text, tb_prezime.Text, pol(), tb_adresa.Text, tb_grad.Text, tb_telefon.Text,
                    getID(combo_sifra.SelectedItem.ToString()), this.id);
                }
                else
                {
                    commStr = string.Format("INSERT INTO putnik(ime, prezime, pol, " +
                        "adresa, grad, telefon, id_let) VALUES ('{0}', '{1}', {2}, " +
                        "'{3}', '{4}', '{5}', {6});",
                    tb_ime.Text, tb_prezime.Text, pol(), tb_adresa.Text, 
                    tb_grad.Text, tb_telefon.Text, getID(combo_sifra.SelectedItem.ToString()));
                }
                MySqlCommand command = new MySqlCommand(commStr, conn);

                var add = command.ExecuteScalar();
                conn.Close();
                this.Close();
            }
        }
    }
}
