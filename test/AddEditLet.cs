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
    public partial class AddEditLet : Form
    {
        private string connStr = "server=localhost;database=aviokompanija;uid=root;pwd=;";
        private string[] properties;
        private bool isUpdate = false;
        private int id;

        private string generateSifra()
        {
            Random rnd = new Random();
            string sifra = "";
            int value;
            int brojac = rnd.Next(3, 5);
            for (int i = 0; i < brojac; i++)
            {
                value = rnd.Next(0, 9);
                sifra += value.ToString();
            }
            return sifra;
        }
        private string[] getStringArray(string commStr)
        {
            MySqlConnection cn = new MySqlConnection(connStr);
            cn.Open();
            MySqlCommand command = new MySqlCommand(commStr, cn);
            List<string> piloti = new List<string>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    piloti.Add(reader.GetString(0));
                }
            }
            cn.Close();
            return piloti.ToArray<string>();
        }

        private int getIdValue(string commStr, string parametar)
        {
            MySqlConnection cn = new MySqlConnection(connStr);
            cn.Open();
            MySqlCommand command = new MySqlCommand(string.Format(commStr, parametar), cn);
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

        public AddEditLet()
        {
            InitializeComponent();
            this.isUpdate = false;
            this.Text = "Dodaj let";
            tb_sifra.Text = generateSifra();
            dt_vrijemePoletanja.Value = DateTime.Today;
            cb_pilot.Items.AddRange(getStringArray("SELECT CONCAT(ime,' ',prezime) " +
                "FROM radnik WHERE isPilot = true;"));
            cb_avion.Items.AddRange(getStringArray("SELECT serijski_broj FROM avion;"));
            cb_polazniAerodrom.Items.AddRange(getStringArray("SELECT ime FROM aerodrom;"));
        }
        public AddEditLet(string[] properties)
        {
            InitializeComponent();
            this.Text = "Izmijeni let";
            this.isUpdate = true;
            this.properties = properties;
            this.id = int.Parse(properties[0]);
            tb_sifra.Text = properties[1];
            cb_pilot.Items.AddRange(getStringArray("SELECT CONCAT(ime,' ',prezime) " +
                "FROM radnik WHERE isPilot = true;"));
            cb_avion.Items.AddRange(getStringArray("SELECT serijski_broj FROM avion;"));
            cb_polazniAerodrom.Items.AddRange(getStringArray("SELECT ime FROM aerodrom;"));
            dt_vrijemePoletanja.Value = DateTime.Parse(properties[2], null);
            num_cijenaKarte.Value = decimal.Parse(properties[3]);
            cb_pilot.SelectedItem = properties[4];
            cb_avion.SelectedItem = properties[5];
            cb_polazniAerodrom.SelectedItem = properties[6];
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_sifra.Text) || cb_polazniAerodrom.SelectedIndex == -1 || cb_pilot.SelectedIndex == -1
                || string.IsNullOrEmpty(num_cijenaKarte.Value.ToString())
                || cb_avion.SelectedIndex == -1)
            {
                #region Validacija
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                if (string.IsNullOrEmpty(tb_sifra.Text))
                {
                    tb_sifra.Focus();
                    errorProvider4.SetError(tb_sifra, "Molimo vas unesite ili generisite sifru leta!");
                }
                if (cb_polazniAerodrom.SelectedIndex == -1)
                {
                    cb_polazniAerodrom.Focus();
                    errorProvider1.SetError(cb_polazniAerodrom, "Molimo vas odaberite polazni aerodrom!");
                }
                if (cb_pilot.SelectedIndex == -1)
                {
                    cb_pilot.Focus();
                    errorProvider2.SetError(cb_pilot, "Molimo vas odaberite pilota!");
                }
                if (string.IsNullOrEmpty(num_cijenaKarte.Value.ToString()))
                {
                    num_cijenaKarte.Focus();
                    errorProvider3.SetError(num_cijenaKarte, "Molimo vas upisite cijenu karte!");
                }

                if (cb_avion.SelectedIndex == -1)
                {
                    cb_avion.Focus();
                    errorProvider5.SetError(cb_avion, "Molimo vas odaberite avion!");
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
                    commStr = string.Format("UPDATE let SET sifra_leta = '{0}', " +
                        "id_polazni_aerodrom = {1}, vrijeme_poletanja = '{2}', " +
                        "id_prevoznik = {3}, cijena_karte = {4}, id_avion = {5} " +
                        "WHERE id_let = {6};",
                    tb_sifra.Text, getIdValue("SELECT id_aerodrom FROM aerodrom " +
                    "WHERE ime = '{0}';", cb_polazniAerodrom.SelectedItem.ToString()), 
                    dt_vrijemePoletanja.Value.ToString("yyyy-MM-dd"), getIdValue("SELECT id_radnik FROM radnik " +
                    "WHERE CONCAT(ime,' ',prezime) = '{0}';", cb_pilot.SelectedItem.ToString()), num_cijenaKarte.Value,
                    getIdValue("SELECT id_avion FROM avion " +
                    "WHERE serijski_broj = '{0}';", cb_avion.SelectedItem.ToString()), this.id);
                }
                else
                {
                    commStr = string.Format("INSERT INTO let(sifra_leta, " +
                        "id_polazni_aerodrom, vrijeme_poletanja, id_prevoznik, " +
                        "cijena_karte, id_avion) VALUES('{0}',{1},'{2}',{3},{4},{5});",
                    tb_sifra.Text, getIdValue("SELECT id_aerodrom FROM aerodrom " +
                    "WHERE ime = '{0}';", cb_polazniAerodrom.SelectedItem.ToString()),
                    dt_vrijemePoletanja.Value.ToString("yyyy-MM-dd HH:mm:ss"), getIdValue("SELECT id_radnik FROM radnik " +
                    "WHERE CONCAT(ime,' ',prezime) = '{0}';", cb_pilot.SelectedItem.ToString()), num_cijenaKarte.Value,
                    getIdValue("SELECT id_avion FROM avion " +
                    "WHERE serijski_broj = '{0}';", cb_avion.SelectedItem.ToString()));
                }
                MySqlCommand command = new MySqlCommand(commStr, conn);

                var add = command.ExecuteScalar();
                conn.Close();
                this.Close();
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            tb_sifra.Text = generateSifra();
        }
    }
}
