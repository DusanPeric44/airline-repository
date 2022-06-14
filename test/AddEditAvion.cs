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
    public partial class AddEditAvion : Form
    {
        private string connStr = "server=localhost;database=aviokompanija;uid=root;pwd=;";
        private string[] properties;
        private bool isUpdate = false;
        private int id;
        public AddEditAvion()
        {
            InitializeComponent();
            this.Text = "Dodaj avion";
            this.isUpdate = false;
        }
        public AddEditAvion(string[] properties)
        {
            InitializeComponent();
            this.Text = "Izmijeni avion";
            this.isUpdate = true;
            this.properties = properties;
            this.id = int.Parse(properties[0]);
            TextBox[] textBoxes = { tb_serBr, tb_regBr, tb_vlasnik, tb_brSjedista,
                    tb_kapRezervoara, tb_nosivost };
            for (int i = 1; i < textBoxes.Length + 1; i++)
            {
                int j = i - 1;
                textBoxes[j].Text = properties[i];
            }
        }

        private void label1_Click(object sender, EventArgs e){}

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_serBr.Text) || string.IsNullOrEmpty(tb_regBr.Text)
                || string.IsNullOrEmpty(tb_vlasnik.Text) || string.IsNullOrEmpty(tb_brSjedista.Text)
                || string.IsNullOrEmpty(tb_kapRezervoara.Text) || string.IsNullOrEmpty(tb_nosivost.Text))
            {
                #region Validacija
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                if (string.IsNullOrEmpty(tb_serBr.Text))
                {
                    tb_serBr.Focus();
                    errorProvider1.SetError(tb_serBr, "Molimo vas upisite serijski broj aviona!");
                }
                if (string.IsNullOrEmpty(tb_regBr.Text))
                {
                    tb_regBr.Focus();
                    errorProvider2.SetError(tb_regBr, "Molimo vas upisite registracioni broj aviona!");
                }
                if (string.IsNullOrEmpty(tb_vlasnik.Text))
                {
                    tb_vlasnik.Focus();
                    errorProvider3.SetError(tb_vlasnik, "Molimo vas upisite vlasnika aviona!");
                }
                if (string.IsNullOrEmpty(tb_brSjedista.Text))
                {
                    tb_brSjedista.Focus();
                    errorProvider4.SetError(tb_brSjedista, "Molimo vas upisite broj sjedista u avionu!");
                }
                if (string.IsNullOrEmpty(tb_kapRezervoara.Text))
                {
                    tb_kapRezervoara.Focus();
                    errorProvider5.SetError(tb_kapRezervoara, "Molimo vas kapacitet rezervoara u litrima!");
                }
                if (string.IsNullOrEmpty(tb_nosivost.Text))
                {
                    tb_nosivost.Focus();
                    errorProvider6.SetError(tb_nosivost, "Molimo vas upisite nosivost u kilogramima!");
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
                    commStr = string.Format("UPDATE avion SET serijski_broj = '{0}', " +
                        "registracioni_broj = '{1}', vlasnik = '{2}', broj_sjedista = '{3}'" +
                        ", kapacitet_rezervoara= '{4}', " +
                        "nosivost= '{5}' WHERE id_avion = {6};",
                    tb_serBr.Text, tb_regBr.Text, tb_vlasnik.Text, tb_brSjedista.Text,
                    tb_kapRezervoara.Text, tb_nosivost.Text, this.id);
                }
                else
                {
                    commStr = string.Format("INSERT INTO avion(serijski_broj, registracioni_broj, vlasnik, broj_sjedista, kapacitet_rezervoara, nosivost) VALUES('{0}','{1}','{2}','{3}','{4}','{5}');",
                    tb_serBr.Text, tb_regBr.Text, tb_vlasnik.Text, tb_brSjedista.Text,
                    tb_kapRezervoara.Text, tb_nosivost.Text);
                }
                MySqlCommand command = new MySqlCommand(commStr, conn);

                var add = command.ExecuteScalar();
                conn.Close();
                this.Close();
            }
        }
    }
}
