using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        MySqlTransaction myTrans = null; //-- MySQL 4.1 and higher

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "pizza";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            VevoListaUpdate();
            PizzaListaUpdate();
        }

        private void VevoListaUpdate()
        {
            listBox_vevok.Items.Clear();
            sql.CommandText = "select * from vevo";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_vevok.Items.Add(new Vevo(dr.GetInt32("vazon"), dr.GetString("vnev"), dr.GetString("vcim")));
                }
            }
        }

        private void PizzaListaUpdate()
        {
            listBox_Pizzak.Items.Clear();
            sql.CommandText = "select * from pizza";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_Pizzak.Items.Add(new Pizza(dr.GetInt32("pazon"), dr.GetString("pnev"), dr.GetInt32("par")));
                }
            }
        }

        private void listBox_vevok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_vevok.SelectedIndex < 0)
            {
                MessageBox.Show("Vélasszon vevőt!");
                return;
            }
            textBox_Vevonev.Text = ((Vevo)listBox_vevok.SelectedItem).Vnev;
        }

        private void listBox_Pizzak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Pizzak.SelectedIndex < 0)
            {
                MessageBox.Show("válasszon pizzat");
                return;
            }
            textBox_Pizza_neve.Text = ((Pizza)listBox_Pizzak.SelectedItem).Pnev;
            textBox_Pizzak_ara.Text = ((Pizza)listBox_Pizzak.SelectedItem).Par.ToString();
            numericUpDown_Db.Value = 1;
        }

        private void numericUpDown_Db_ValueChanged(object sender, EventArgs e)
        {
            if (listBox_Pizzak.SelectedIndex < 0)
            {
                MessageBox.Show("Válaszon pizzat!");
                return;
            }
            textBox_Pizzak_ara.Text = (numericUpDown_Db.Value * ((Pizza)listBox_Pizzak.SelectedItem).Par).ToString();
        }

        private void button_Rendeles_Click(object sender, EventArgs e)
        {
            //-- választott pizzát? --------------------------
            if (listBox_Pizzak.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon pizzat");
                return;
            }
            //-- választott vevőt? --------------------------
            if (listBox_vevok.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon vevőt");
                return;
            }
            int vazon = ((Vevo)listBox_vevok.SelectedItem).Vazon;
            int pazon = ((Pizza)listBox_Pizzak.SelectedItem).Pazon;
            string pnev = ((Pizza)listBox_Pizzak.SelectedItem).Pnev;
            decimal db = numericUpDown_Db.Value;
            //-- leellenőrizzük, szerepel-e már a listában -----
            bool nincs = true;

            for (int i = 0; i < listBox_REndelt_pizzak.Items.Count; i++)
            {

                if (((MegrendeltPizza)listBox_REndelt_pizzak.Items[i]).Pazon == pazon)
                {
                    ((MegrendeltPizza)listBox_REndelt_pizzak.Items[i]).Db += db;
                    listBox_REndelt_pizzak.Items[i] = listBox_REndelt_pizzak.Items[i]; //-- frissíti a tartalmat
                    nincs = false;
                }
            }

            if (nincs)
            {
                listBox_REndelt_pizzak.Items.Add(new MegrendeltPizza(vazon, pazon, pnev, db));
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (listBox_REndelt_pizzak.Items.Count<1)
            {
                MessageBox.Show("A lista üres!");
                return;
            }
            int razon = 0;
            int vazon = ((Vevo)listBox_vevok.SelectedItem).Vazon;
            sql.Transaction = myTrans;
            myTrans = conn.BeginTransaction();
 
            try
            {
                //-- razon értékének a lekérdezése ------------------
                sql.CommandText = "SELECT MAX(`razon`)+1 FROM rendeles";
                object result = sql.ExecuteScalar();
                if (result != null)
                {
                    razon = Convert.ToInt32(result);
                }
                //-- rendelés indítása --------------------------------
                sql.CommandText = "INSERT INTO `rendeles`(`razon`, `vazon`, `fazon`) VALUES (" + razon + "," + vazon + ",1)";
                if (sql.ExecuteNonQuery() != 1)
                {
                    //-- Nem sikerült a rendelésbe beszúrni a rekordot, visszavonás -----------------
                    myTrans.Rollback();
                    MessageBox.Show("Rendelés rögzítése sikertelen!");
                    return;
                }
                //-- rendelési tételek rögzítése --------------------------
                sql.CommandText = "INSERT INTO `tetel`(`razon`, `pazon`, `db`) VALUES ";
                int rowNum = 0;
                foreach (MegrendeltPizza item in listBox_REndelt_pizzak.Items)
                {
                    sql.CommandText += "(" + razon + "," + item.Pazon + "," + item.Db + "),";
                    rowNum++;
                }
                sql.CommandText = sql.CommandText.Trim(',');
                if (rowNum != sql.ExecuteNonQuery())
                {
                    //--- A rendelt pizzák száma és a beszúrt rekordok száma eltér! -------------
                    myTrans.Rollback();
                    MessageBox.Show("Rendelés rögzítése sikertelen!");
                    return;
                }

                myTrans.Commit();
                MessageBox.Show("rendelés rögzítve");
            }
            catch (Exception ex)
            {
                myTrans.Rollback(); //-- adatmódosítások visszavonása
                MessageBox.Show("Rendelés rögzítése sikertelen!\n\n" + ex.Message);
                return;
            }
            //-- rendelés táblába besz.

 
        }
    }
}
