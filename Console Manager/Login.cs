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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        Data.korisnici korisnik=Korisnici.SelectByKorisnickoIme(textBoxKorisnickoIme.Text, textBoxLozinka.Text);

            if(korisnik!=null)
            {
                if (korisnik.IsAdmin==true)  
                {
                    MessageBox.Show("Dobro došli!","Login");
                    global.prijavljenKorisnik = korisnik;
                    global.IsADmin = korisnik.IsAdmin;
                    if (global.IsLogout == 1)
                    {
                       

                        this.Opacity = 0.0f;
                        this.ShowInTaskbar = false;
                        this.Hide();
                        
                    }
                    else
                    {
                        global.prijavljenKorisnik = korisnik;
                        global.IsADmin = korisnik.IsAdmin;
                        Manager frm = new Manager();
                        this.Opacity = 0.0f;
                        this.ShowInTaskbar = false;
                        this.Hide();
                        frm.ShowDialog();
                    }
                    

                }
                else
                {
                    if (global.IsLogout == 1)
                    {
                        global.prijavljenKorisnik = korisnik;
                        global.IsADmin = korisnik.IsAdmin;
                        this.Opacity = 0.0f;
                        this.ShowInTaskbar = false;
                        this.Hide();
                        
                        
                    }
                    else
                    {
                        Aplikacija frm = new Aplikacija();
                        global.prijavljenKorisnik = korisnik;
                        global.IsADmin = korisnik.IsAdmin;
                        MessageBox.Show("Dobro došli!", "Login");
                        this.Opacity = 0.0f;
                        this.ShowInTaskbar = false;
                        this.Hide();
                        frm.ShowDialog();
                    }
                }

            }
            else
            {
                MessageBox.Show("Pogrešni podaci","Upozorenje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registracija frm = new Registracija();
            frm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Registracija frm = new Registracija();
            frm.ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
