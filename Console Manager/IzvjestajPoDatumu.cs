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
    public partial class IzvjestajPoDatumu : Form
    {
        public IzvjestajPoDatumu()
        {
            InitializeComponent();
        }

        private void IzvjestajPoDatumu_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Data.IzvjestajPoDatumu_Result> ds = Izvjestaj.IzvjestajPoDatumu(dateTimePicker1.Value.Date,dateTimePicker2.Value.Date);

            dataGridView1.DataSource = ds;
            dataGridView1.AutoGenerateColumns = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource!=null && global.IsADmin==true)
            {
                Izvjestaj.DeleteIzvjestaj(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                List<Data.IzvjestajPoDatumu_Result> ds = Izvjestaj.IzvjestajPoDatumu(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);

                dataGridView1.DataSource = ds;
                dataGridView1.AutoGenerateColumns = false;
            }
            else
            {
                MessageBox.Show("Samo administratoru je dozvoljeno brisanje izvještaja");
            }
        }
    }
}
