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
    public partial class DodavanjeKonzola : Form
    {
        public DodavanjeKonzola()
        {
            InitializeComponent();
        }

        private void DodavanjeKonzola_Load(object sender, EventArgs e)
        {
            comboBoxTV.DataSource = konzole.Televizije();

            comboBox1.DataSource = konzole.KonzoleTV("TV1");
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = "konzolaID";

            comboBoxKonzole.DataSource = konzole.KonzoleLista();
            comboBoxKonzole.DisplayMember = "Naziv";
            comboBoxKonzole.ValueMember = "ListaKonzolaID";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if(comboBoxKonzole.SelectedIndex==0)
            {
                MessageBox.Show("Odaberi konzolu");
            }
            else
            {
                konzole.DodajKonzolu(comboBoxTV.SelectedItem.ToString(), comboBoxKonzole.GetItemText(comboBoxKonzole.SelectedItem));

                MessageBox.Show("Uspjesno dodano");
                comboBoxKonzole.SelectedIndex = 0;
                comboBoxTV.SelectedIndex = 0;

            }

           
        }

        private void comboBoxTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BindK();
        }

        private void BindK()
        {
            comboBox1.DataSource = konzole.KonzoleTV(comboBoxTV.SelectedItem.ToString());
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = "konzolaID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Odaberi konzolu");
            }
            else
            {

                konzole.BrisiKonzola(Convert.ToInt32(comboBox1.SelectedValue));
                BindK();
                MessageBox.Show("Uspjesno obrisano");
            }
        }
    }
}
