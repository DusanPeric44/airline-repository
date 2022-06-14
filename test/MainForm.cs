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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string connStr = "server=localhost;database=aviokompanija;uid=root;pwd=;";

        private Tuple<string, string> selectedTable()
        {
            if (rb_aerodrom.Checked)
            {
                return Tuple.Create("aerodrom", "id_aerodrom");
            }
            else if (rb_avion.Checked)
            {
                return Tuple.Create("avion", "id_avion");
            }
            else if (rb_let.Checked)
            {
                return Tuple.Create("let", "id_let"); ;
            }
            else if (rb_putnik.Checked)
            {
                return Tuple.Create("putnik", "id_putnik"); ;
            }
            else
            {
                return Tuple.Create("radnik", "id_radnik");
            }
        }

        private void popuniListView(string command)
        {
            MySqlConnection cn = new MySqlConnection(connStr);
            cn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command, cn);
            da.Fill(dt);
            lv_prikaz.Clear();

            foreach (DataColumn column in dt.Columns)
            {
                lv_prikaz.Columns.Add(column.ColumnName.ToString());
            }
            string[] items = new string[dt.Columns.Count];
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < items.Length; i++)
                    items[i] = row[i].ToString();
                lv_prikaz.Items.Add(new ListViewItem(items));
            }
            for (int i = 0; i < lv_prikaz.Columns.Count; i++)
                lv_prikaz.Columns[i].Width = -2;

            cn.Close();
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = true;
        }


        private void btn_letovi_Click(object sender, EventArgs e)
        {
            popuniListView("SELECT id_let AS 'ID', sifra_leta AS 'Sifra leta', " +
                "vrijeme_poletanja AS 'Vrijeme poletanja', cijena_karte AS 'Cijena karte'," +
                " CONCAT(radnik.ime, ' ', radnik.prezime) AS 'Pilot', avion.serijski_broj AS 'Serijski broj aviona', " +
                "aerodrom.ime AS 'Polazni aerodrom' FROM let, aerodrom, radnik, avion WHERE aerodrom.id_aerodrom = let.id_polazni_aerodrom and let.id_prevoznik = radnik.id_radnik and let.id_avion = avion.id_avion");
            rb_let.Checked = true;
        }

        private void btn_radnici_Click(object sender, EventArgs e)
        {
            if (chk_pilot.Checked)
            {
                popuniListView("SELECT id_radnik as 'ID', ime as 'Ime', " +
                    "prezime as 'Prezime', maticni_broj as 'Maticni broj', " +
                    "strucna_sprema as 'Strucna sprema', zanimanje as 'Zanimanje', " +
                    "datum_zaposlenja as 'Datum zaposlenja', adresa as 'Adresa', " +
                    "grad as 'Grad', telefon as 'Telefon',  " +
                    "Case when pol = 1 then 'Musko' when pol = 0 then 'Zensko' " +
                    "else 'Ostalo' end as 'Pol', Case when isPilot = 1 then 'Da' " +
                    "else 'Ne' end as 'Pilot' FROM aviokompanija.radnik " +
                    "WHERE IsPilot = true;");
            }
            else
            {
                popuniListView("SELECT id_radnik as 'ID', ime as 'Ime', " +
                    "prezime as 'Prezime', maticni_broj as 'Maticni broj', " +
                    "strucna_sprema as 'Strucna sprema', zanimanje as 'Zanimanje', " +
                    "datum_zaposlenja as 'Datum zaposlenja', adresa as 'Adresa', " +
                    "grad as 'Grad', telefon as 'Telefon',  " +
                    "Case when pol = 1 then 'Musko' when pol = 0 then 'Zensko' " +
                    "else 'Ostalo' end as 'Pol', Case when isPilot = 1 then 'Da' " +
                    "else 'Ne' end as 'Pilot' " +
                    "FROM aviokompanija.radnik;");
            }
            rb_radnik.Checked = true;
        }

        private void btn_putnici_Click(object sender, EventArgs e)
        {
            popuniListView("SELECT id_putnik as 'ID', ime as 'Ime', " +
                "prezime as 'Prezime', Case when pol = 1 then 'Musko' " +
                "when pol = 0 then 'Zensko' else 'Ostalo' end as 'Pol', " +
                "adresa as 'Adresa', grad as 'Grad', telefon as 'Telefon', " +
                "let.sifra_leta as 'Sifra leta' FROM putnik, let WHERE " +
                "let.id_let = putnik.id_let;");
            rb_putnik.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void btn_avioni_Click(object sender, EventArgs e)
        {
            popuniListView("SELECT id_avion as 'ID', serijski_broj as 'Serijski broj'," +
                " registracioni_broj as 'Registracioni broj', vlasnik as 'Vlasnik'," +
                " broj_sjedista as 'Broj sjedista', " +
                "kapacitet_rezervoara as 'Kapacitet rezervoara (l)', " +
                "nosivost as 'Nosivost (kg)' FROM aviokompanija.avion;");
            rb_avion.Checked = true;
        }

        private void btn_aeorodromi_Click(object sender, EventArgs e)
        {
            popuniListView("SELECT id_aerodrom as 'ID', ime as 'Ime', " +
                "grad as 'Grad', zemlja as 'Zemlja' FROM aviokompanija.aerodrom;");
            rb_aerodrom.Checked = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(connStr);
            cn.Open();
            string tableName, idName;
            tableName = this.selectedTable().Item1;
            idName = this.selectedTable().Item2;

            string command = string.Format("DELETE FROM {0} WHERE {1} = {2};",
                tableName, idName, lv_prikaz.SelectedItems[0].SubItems[0].Text);

            MySqlCommand comm = new MySqlCommand(command, cn);

            int rows = comm.ExecuteNonQuery();

            cn.Close();

            lv_prikaz.Items.Remove(lv_prikaz.SelectedItems[0]);
        }

        private void lv_prikaz_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (rb_aerodrom.Checked)
            {
                AddEditAerodrom addEditAerodrom = new AddEditAerodrom();
                addEditAerodrom.Show();
            }
            else if (rb_avion.Checked)
            {
                AddEditAvion addEditAvion = new AddEditAvion();
                addEditAvion.Show();
            }
            else if (rb_let.Checked)
            {
                AddEditLet addEditLet = new AddEditLet();
                addEditLet.Show();
            }
            else if (rb_putnik.Checked)
            {
                AddEditPutnik addEditPutnik = new AddEditPutnik();
                addEditPutnik.Show();
            }
            else
            {
                AddEditRadnik addEditRadnik = new AddEditRadnik();
                addEditRadnik.Show();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string[] properties = new string[lv_prikaz.SelectedItems[0].SubItems.Count];
            for (int i = 0; i < lv_prikaz.SelectedItems[0].SubItems.Count; i++)
            {
                properties[i] = lv_prikaz.SelectedItems[0].SubItems[i].Text;
            }
            if (rb_aerodrom.Checked)
            {
                AddEditAerodrom addEditAerodrom = new AddEditAerodrom(properties);
                addEditAerodrom.Show();
            }
            else if (rb_avion.Checked)
            {
                AddEditAvion addEditAvion = new AddEditAvion(properties);
                addEditAvion.Show();
            }
            else if (rb_let.Checked)
            {
                AddEditLet addEditLet = new AddEditLet(properties);
                addEditLet.Show();
            }
            else if (rb_putnik.Checked)
            {
                AddEditPutnik addEditPutnik = new AddEditPutnik(properties);
                addEditPutnik.Show();
            }
            else
            {
                AddEditRadnik addEditRadnik = new AddEditRadnik(properties);
                addEditRadnik.Show();
            }
        }
    }
}
