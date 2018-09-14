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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registracija frm = new Registracija();
            frm.ShowDialog();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (global.isOptions != 1)
            {
                Aplikacija frm = new Aplikacija();
               
                this.Opacity = 0.0f;
                this.ShowInTaskbar = false;
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                this.Opacity = 0.0f;
                this.ShowInTaskbar = false;
                this.Close();
            }

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void cjenovnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cjenovnik frm = new Cjenovnik();
            frm.ShowDialog();
        }

        private void konzoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeKonzola frm = new DodavanjeKonzola();
            frm.Show();
        }

        private void održavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(global.prijavljenKorisnik.KorisnickoIme == "golden")
                {

                Odrzavanje frm = new Odrzavanje();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pristup ograničen!");
            }

            
        }

        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvjestajPoDatumu frm = new IzvjestajPoDatumu();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fm = Application.OpenForms["Aplikacija"];

            if (fm == null)
            {
                Application.Exit();
            }
        }
    }
}
