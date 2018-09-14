using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_Manager
{
    public partial class Cjenovnik : Form
    {
        public Data.Cjenovnik  cjenovnik{ get; set; }
        public Cjenovnik()
        {
            InitializeComponent();
        }

        private void Cjenovnik_Load(object sender, EventArgs e)
        {


            comboBoxKonzola.DataSource = konzole.KonzoleLista();
            comboBoxKonzola.DisplayMember = "naziv";
            comboBoxKonzola.ValueMember = "ListaKonzolaID";


            if (cjenovnikklasa.SelectAll().ToList() != null)
            {

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = cjenovnikklasa.SelectAll();
            }
        }

        //dodavanje 
        private void button1_Click(object sender, EventArgs e)
        {
            Data.Cjenovnik cjenovnik = new Data.Cjenovnik();
            cjenovnik.Konzola = comboBoxKonzola.Text;
            cjenovnik.Vrijeme_od = dateTimePicker1.Value.ToShortTimeString();
            cjenovnik.Vrijeme_do = dateTimePicker2.Value.ToShortTimeString();
            cjenovnik.Cijena = maskedTextBox1.Text;

            cjenovnikklasa.InsertCjenovnik(cjenovnik);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = cjenovnikklasa.SelectAll();

        }

       
        //prikaz
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int CjenovnikID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            cjenovnik = cjenovnikklasa.cjenovnik(CjenovnikID);

            textBox1.Text = cjenovnik.Konzola;
            textBox2.Text = cjenovnik.Vrijeme_od;
            textBox3.Text = cjenovnik.Vrijeme_do;
            textBox4.Text = cjenovnik.Cijena;


        }

        //izmjena
        private void button2_Click(object sender, EventArgs e)
        {
            if(cjenovnik!=null)
            {
                cjenovnikklasa.CjenovnikIzmjena(cjenovnik.CjenovnikID, textBox4.Text);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = cjenovnikklasa.SelectAll();
            }
        }
        
        //brisi
        private void button3_Click(object sender, EventArgs e)
        {
            if (cjenovnik != null)
            {
                cjenovnikklasa.CjenovnikBrisi(cjenovnik.CjenovnikID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = cjenovnikklasa.SelectAll();
            }
        }

        private void comboBoxKonzola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
