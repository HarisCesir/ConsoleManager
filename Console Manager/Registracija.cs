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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                Data.korisnici korisnik = new Data.korisnici();

                korisnik.Ime = textBoxIme.Text;
                korisnik.Prezime = textBoxPrezime.Text;
                korisnik.KorisnickoIme = textBoxKorisnickoIme.Text;
                korisnik.IsAdmin = checkBox1.Checked;
                korisnik.LozinkaSalt = UiHelper.GenerateSalt();
                korisnik.LozinkaHash = UiHelper.GenerateHash(textBoxLozinka.Text, korisnik.LozinkaSalt);

                Korisnici.InsertKorisnik(korisnik);

                MessageBox.Show("Uspješno dodan korisnik!", "Registracija");
            }
            catch
            {
                MessageBox.Show("Pokušaj ponovo!", "Greška");
            }

        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }
    }
}
