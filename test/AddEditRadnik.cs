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
    public partial class AddEditRadnik : Form
    {
        private string connStr = "server=localhost;database=aviokompanija;uid=root;pwd=;";
        private string[] properties;
        private bool isUpdate = false;
        private int id;
        public AddEditRadnik()
        {
            InitializeComponent();
            this.Text = "Dodaj radnika";
            this.isUpdate = false;
        }

        public AddEditRadnik(string[] properties)
        {
            InitializeComponent();
            this.Text = "Izmijeni radnika";
            this.properties = properties;
            this.id = int.Parse(properties[0]);
            this.isUpdate = true;
            TextBox[] textBoxes = { tb_ime, tb_prezime, tb_maticni, tb_strucna,
                tb_zanimanje,tb_adresa, tb_grad, tb_telefon };
            for (int i = 1, j = 0; i < textBoxes.Length+1; i++, j++)
            {
                if (i == 6)
                {
                    dt_pick.Value = DateTime.Parse(properties[i], null);
                    textBoxes[j].Text = properties[i+1];
                    continue;
                }
                else if(i > 6)
                {
                    textBoxes[j].Text = properties[i + 1];
                    continue;
                }
                textBoxes[j].Text = properties[i];
            }
            if(properties[textBoxes.Length + 2] == "Musko")
            {
                rb_musko.Checked = true;
            }
            else
            {
                rb_zensko.Checked = true;
            }
            if(properties[textBoxes.Length + 3] == "Da")
            {
                cb_pilot.Checked = true;
            }
            
        }
        private short pol()
        {
            if (rb_zensko.Checked)
                return 0;
            if (rb_musko.Checked)
                return 1;
            return 0;
        }
        private void AddEditRadnik_Load(object sender, EventArgs e) { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ime.Text) || string.IsNullOrEmpty(tb_prezime.Text)
                || string.IsNullOrEmpty(tb_maticni.Text) || string.IsNullOrEmpty(tb_strucna.Text)
                || string.IsNullOrEmpty(tb_zanimanje.Text) || string.IsNullOrEmpty(tb_adresa.Text)
                || string.IsNullOrEmpty(tb_grad.Text) || string.IsNullOrEmpty(tb_telefon.Text))
            {
                #region Validacija
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
                errorProvider8.Clear();
                errorProvider9.Clear();
                errorProvider10.Clear();
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
                if (string.IsNullOrEmpty(tb_maticni.Text))
                {
                    tb_maticni.Focus();
                    errorProvider3.SetError(tb_maticni, "Molimo vas upisite maticni broj!");
                }
                if (string.IsNullOrEmpty(tb_strucna.Text))
                {
                    tb_strucna.Focus();
                    errorProvider4.SetError(tb_strucna, "Molimo vas upisite strucnu spremu!");
                }
                if (string.IsNullOrEmpty(tb_zanimanje.Text))
                {
                    tb_zanimanje.Focus();
                    errorProvider5.SetError(tb_zanimanje, "Molimo vas upisite zanimanje!");
                }
                if (string.IsNullOrEmpty(tb_adresa.Text))
                {
                    tb_adresa.Focus();
                    errorProvider7.SetError(tb_adresa, "Molimo vas upisite adresu!");
                }
                if (string.IsNullOrEmpty(tb_grad.Text))
                {
                    tb_grad.Focus();
                    errorProvider8.SetError(tb_grad, "Molimo vas upisite grad!");
                }
                if (string.IsNullOrEmpty(tb_telefon.Text))
                {
                    tb_telefon.Focus();
                    errorProvider9.SetError(tb_telefon, "Molimo vas upisite broj telefona!");
                }
                if (rb_musko.Checked || rb_zensko.Checked)
                {
                    tb_maticni.Focus();
                    errorProvider10.SetError(tb_maticni, "Molimo vas odaberite pol!");
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
                    commStr = string.Format("UPDATE radnik SET ime = '{0}', " +
                        "prezime = '{1}', maticni_broj = '{2}', strucna_sprema = '{3}', " +
                        "zanimanje = '{4}', datum_zaposlenja = '{5}', " +
                        "adresa = '{6}', grad = '{7}', telefon = '{8}', pol = {9}, isPilot = {10} WHERE id_radnik = {11};",
                    tb_ime.Text, tb_prezime.Text, tb_maticni.Text, tb_strucna.Text,
                    tb_zanimanje.Text, dt_pick.Value.ToString("yyyy-MM-dd")
                    , tb_adresa.Text, tb_grad.Text, tb_telefon.Text, pol(),
                    cb_pilot.Checked, this.id);
                }
                else
                {
                    commStr = string.Format("INSERT INTO radnik(ime, prezime, maticni_broj," +
                        " strucna_sprema, zanimanje, " +
                        "datum_zaposlenja, adresa, grad, telefon, " +
                        "pol, isPilot) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                        "'{7}','{8}',{9},{10})",
                    tb_ime.Text, tb_prezime.Text, tb_maticni.Text, tb_strucna.Text,
                    tb_zanimanje.Text, dt_pick.Value.ToString("yyyy-MM-dd")
                    , tb_adresa.Text, tb_grad.Text, tb_telefon.Text, pol(),
                    cb_pilot.Checked);
                }
                MySqlCommand command = new MySqlCommand(commStr, conn);

                var add = command.ExecuteScalar();
                conn.Close();
                this.Close();
            }
        }
    }
}
