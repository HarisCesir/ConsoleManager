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
    public partial class Odrzavanje : Form
    {
        public Odrzavanje()
        {
            InitializeComponent();
        }

        private void Odrzavanje_Load(object sender, EventArgs e)
        {
            BindLista();
        }

        private void BindLista()
        {
            comboBox1.DataSource = konzole.KonzoleLista();
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "ListaKonzolaID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("Unesite naziv konzole");
            }
            else
            {
                List<Data.ListaKonzola> Konzole = konzole.KonzoleLista();
                int ima = 0;
                foreach(Data.ListaKonzola a in Konzole)
                {
                    if(a.Naziv==textBox1.Text.Trim())
                    {
                        ima = 1;
                    }
                }

                if (ima == 1)
                {
                    MessageBox.Show("Konzola vec postoji");
                }
                else
                {
                    konzole.DodajKonzoluLista(textBox1.Text);

                    textBox1.Text = "";
                    MessageBox.Show("Uspjesno dodano");
                    BindLista();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                MessageBox.Show("Odaberi Konzolu");
            }
            else
            {
                konzole.BrisiKonzoluSaListe(Convert.ToInt32(comboBox1.SelectedValue));

                comboBox1.SelectedIndex = 0;
                BindLista();
                MessageBox.Show("Uspjesno Obrisano");


            }
        }
    }
}
