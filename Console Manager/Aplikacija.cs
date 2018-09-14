using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Console_Manager
{

    
    public partial class Aplikacija : Form
    {
       
        //Timeri ...
        System.Diagnostics.Stopwatch StopWatch1 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch2 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch3 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch4 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch5 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch6 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch7 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch8 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch9 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatch10 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch StopWatchCijena = new System.Diagnostics.Stopwatch();

        
        


        public Aplikacija()
        {
            InitializeComponent();
            
            //USB komunikacija
            /*
            serialPort2.Open();

            try
            {
                serialPort2.Close();
                serialPort2.PortName = "COM4"; //Ista vrijednost kao i arduino
                serialPort2.BaudRate = 9600;
                serialPort2.DataBits = 8;
                serialPort2.Parity = Parity.None;
                serialPort2.StopBits = StopBits.One;
                serialPort2.Handshake = Handshake.None;
                serialPort2.Encoding = System.Text.Encoding.Default; //bitno
                
            }
            catch
            {
                MessageBox.Show("Problem USB ispisa. Za nastavak rada bice neophodno restartovati USB!","Greška USB!");
            }
            

            //Incijalni test prije paljenja
            try
            {
                serialPort2.Open();
                serialPort2.Write("o");
                serialPort2.WriteTimeout = 200;
                serialPort2.Close();
                serialPort2.Open();
                serialPort2.Write("p");
                serialPort2.WriteTimeout = 200;
                serialPort2.Close();
            }
            catch
            {
                MessageBox.Show("Problem USB ispisa. Za nastavak rada bice neophodno restartovati USB!","Greška USB!");
                serialPort2.Close();
            }
            
            */

            //Skirvanje button-a

            button2.Hide(); button3.Hide(); button1.Show();

            button4.Hide(); button5.Hide(); button6.Show();

            button7.Hide(); button8.Hide(); button9.Show();

            button10.Hide(); button11.Hide(); button12.Show();

            button13.Hide(); button14.Hide(); button15.Show();

            button16.Hide(); button17.Hide(); button18.Show();

            button19.Hide(); button20.Hide(); button21.Show();

            button22.Hide(); button23.Hide(); button24.Show();

            button25.Hide(); button26.Hide(); button27.Show();

            button28.Hide(); button29.Hide(); button30.Hide(); textBox10.Hide(); comboBoxTV10.Hide(); iznosTV10.Hide(); label21.Hide(); label18.Hide(); label30.Hide();

            konzole.Ugasi();
        }

        private void Aplikacija_Load(object sender, EventArgs e)
        {
            
            //timerCijena.Start();
            //StopWatchCijena.Start();

            global.Cjenovnik = cjenovnikklasa.SelectAll();

            comboBoxTV1.DataSource =konzole.konzoleTV1();
            comboBoxTV1.DisplayMember = "naziv";
            comboBoxTV1.ValueMember = "konzolaID";
           
            comboBoxTV2.DataSource = konzole.konzoleTV2();
            comboBoxTV2.DisplayMember = "naziv";
            comboBoxTV2.ValueMember = "konzolaID";

            comboBoxTV3.DataSource = konzole.konzoleTV3();
            comboBoxTV3.DisplayMember = "naziv";
            comboBoxTV3.ValueMember = "konzolaID";

            comboBoxTV4.DataSource = konzole.konzoleTV4();
            comboBoxTV4.DisplayMember = "naziv";
            comboBoxTV4.ValueMember = "konzolaID";

            comboBoxTV5.DataSource = konzole.konzoleTV5();
            comboBoxTV5.DisplayMember = "naziv";
            comboBoxTV5.ValueMember = "konzolaID";

            comboBoxTV6.DataSource = konzole.konzoleTV6();
            comboBoxTV6.DisplayMember = "naziv";
            comboBoxTV6.ValueMember = "konzolaID";

            comboBoxTV7.DataSource = konzole.konzoleTV7();
            comboBoxTV7.DisplayMember = "naziv";
            comboBoxTV7.ValueMember = "konzolaID";

            comboBoxTV8.DataSource = konzole.konzoleTV8();
            comboBoxTV8.DisplayMember = "naziv";
            comboBoxTV8.ValueMember = "konzolaID";

            comboBoxTV9.DataSource = konzole.konzoleTV9();
            comboBoxTV9.DisplayMember = "naziv";
            comboBoxTV9.ValueMember = "konzolaID";

            comboBoxTV10.DataSource = konzole.konzoleTV10();
            comboBoxTV10.DisplayMember = "naziv";
            comboBoxTV10.ValueMember = "konzolaID";
        }
        
        // timer za cijenu
        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatchCijena.Elapsed;
            CijenaPrikaz();
        }
        //Timer TV-1
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch1.Elapsed;
            textBox1.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV1,global.TV1,textBox1.Text,iznosTV1);
        }
        //Timer TV-2
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch2.Elapsed;
            textBox4.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
             cjenovnik(iznosTV2, global.TV2, textBox4.Text, iznosTV2);
            

            
        }
        //Timer TV-3
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch3.Elapsed;
            textBox2.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV3, global.TV3, textBox2.Text,iznosTV3);
        }
        //Timer TV-4
        private void timer4_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch4.Elapsed;
            textBox3.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV4, global.TV4, textBox3.Text,iznosTV4);
        }
        //Timer TV-5
        private void timer5_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch5.Elapsed;
            textBox5.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV5, global.TV5, textBox5.Text,iznosTV5);
        }
        //Timer TV6
        private void timer6_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch6.Elapsed;
            textBox6.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV6, global.TV6, textBox6.Text,iznosTV6);
        }
        //Timer TV-7
        private void timer7_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch7.Elapsed;
            textBox7.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV7, global.TV7, textBox7.Text,iznosTV7);
        }
        //Timer TV-8
        private void timer8_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch8.Elapsed;
            textBox8.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV8, global.TV8, textBox8.Text,iznosTV8);
        }
        //Timer TV-9
        private void timer9_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch9.Elapsed;
            textBox9.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV9, global.TV9, textBox9.Text,iznosTV9);
        }
        //Timer TV-10
        private void timer10_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = StopWatch10.Elapsed;
            textBox10.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
            cjenovnik(iznosTV10, global.TV10, textBox10.Text,iznosTV10);
        }

        //TV-1 ON
        private void button1_Click(object sender, EventArgs e)
        {

            string tv = "TV1";

            if (textBox1.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV1.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV1.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("0");
                        serialPort2.Close();
                    }
                    catch
                    {
                       MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!","Greška USB!");
                       serialPort2.Close();
                       serialPort2.Open();
                       serialPort2.Write("o");
                       serialPort2.Close();
                    }
                    

                    button2.Show();
                    button3.Show();
                    button1.Hide();
                    textBox1.ForeColor = Color.SpringGreen;

                    global.TV1 = comboBoxTV1.Text;
                    timer1.Start();
                    StopWatch1.Start();

                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV1.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }

                }
            }
        }
        //TV-1 OFF
        private void button2_Click(object sender, EventArgs e)
        {

            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach(Data.upapljeno_Result a in upaljeno)
            {
                if(a.pozicija=="TV1")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox1.Text, Math.Round(Convert.ToDecimal(iznosTV1.Text), 2));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("1");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button2.Hide();
                    button3.Hide();
                    button1.Show();
                    textBox1.ForeColor = Color.White;

                    timer1.Stop();
                    StopWatch1.Reset();
                    textBox1.Text = "00:00:00";
                    comboBoxTV1.SelectedIndex = 0;
                    global.TV1 = null;
                    break;
                }
            }
        } 
        //TV-1 RESET 
        private void button3_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno =konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV1")
                {
                   konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox1.Text, Convert.ToDecimal(iznosTV1.Text));

                    timer1.Stop();
                    StopWatch1.Reset() ;
                    
                    textBox1.Text = "00:00:00";
                    

                    break;
                }
            }

            if (textBox1.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV1.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV1 = comboBoxTV1.Text;
                    timer1.Start();
                    StopWatch1.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV1.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-2 ON
        private void button12_Click(object sender, EventArgs e)
        {
            
            string tv = "TV2";

            if (textBox4.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV2.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV2.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;

                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("2");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button10.Show();
                    button11.Show();
                    button12.Hide();
                    textBox4.ForeColor = Color.SpringGreen;
                    global.TV2 = comboBoxTV2.Text;
                    timer2.Start();
                    StopWatch2.Start();

                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV2.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }

                }
            }
        }
        //TV-2 OFF
        private void button11_Click(object sender, EventArgs e)
        {

            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV2")
                {
                    
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox4.Text, Convert.ToDecimal(iznosTV2.Text));

                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("3");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button10.Hide();
                    button11.Hide();
                    button12.Show();
                    textBox4.ForeColor = Color.White;

                    timer2.Stop();
                    StopWatch2.Reset();
                    textBox4.Text = "00:00:00";
                    comboBoxTV2.SelectedIndex = 0;
                    global.TV2 = null;
                    break;
                }
            }
        }
        //TV-2 RESET
        private void button10_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV2")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox4.Text, Convert.ToDecimal(iznosTV2.Text));

                    timer2.Stop();
                    StopWatch2.Reset();
                    textBox4.Text = "00:00:00";
                   
                    break;
                }
            }

            if (textBox4.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV2.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV2 = comboBoxTV2.Text;
                    timer2.Start();
                    StopWatch2.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV2.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-3 ON
        private void button6_Click_2(object sender, EventArgs e)
        {
            
            string tv = "TV3";

            if (textBox2.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV3.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV3.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("4");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button4.Show();
                    button5.Show();
                    button6.Hide();
                    textBox2.ForeColor = Color.SpringGreen;
                    global.TV3 = comboBoxTV3.Text;
                    timer3.Start();
                    StopWatch3.Start();
                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV3.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                }
            }
        }
        //TV-3 OFF
        private void button5_Click_3(object sender, EventArgs e)
        {

            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV3")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox2.Text, Convert.ToDecimal(iznosTV3.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("5");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button4.Hide();
                    button5.Hide();
                    button6.Show();
                    textBox2.ForeColor = Color.White;
                    global.TV3 = null;
                    timer3.Stop();
                    StopWatch3.Reset();
                    textBox2.Text = "00:00:00";
                    comboBoxTV3.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-3 RESTART
        private void button4_Click_2(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV3")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox2.Text, Convert.ToDecimal(iznosTV3.Text));

                    timer3.Stop();
                    StopWatch3.Reset();
                    textBox2.Text = "00:00:00";
                    break;
                }
            }

            if (textBox2.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV3.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV3 = comboBoxTV3.Text;
                    timer3.Start();
                    StopWatch3.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV3.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-4 ON
        private void button9_Click_1(object sender, EventArgs e)
        {
           
            string tv = "TV4";

            if (textBox3.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV4.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV4.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("d");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button7.Show();
                    button8.Show();
                    button9.Hide();
                    textBox3.ForeColor = Color.SpringGreen;
                    global.TV4 = comboBoxTV4.Text;
                    timer4.Start();
                    StopWatch4.Start();
                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV4.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                }

                connection.db.Database.Connection.Close();
            }

        }
        //TV-4 OFF
        private void button8_Click_1(object sender, EventArgs e)
        {
            
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV4")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox3.Text, Convert.ToDecimal(iznosTV4.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("c");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button7.Hide();
                    button8.Hide();
                    button9.Show();
                    textBox3.ForeColor = Color.White;
                    global.TV4 = null;
                    timer4.Stop();
                    StopWatch4.Reset();
                    textBox3.Text = "00:00:00";
                    comboBoxTV4.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-4 RESTART
        private void button7_Click_1(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV4")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox3.Text, Convert.ToDecimal(iznosTV4.Text));

                    timer4.Stop();
                    StopWatch4.Reset();
                    textBox3.Text = "00:00:00";
                    break;
                }
            }

            if (textBox3.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV4.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV4 = comboBoxTV4.Text;
                    timer4.Start();
                    StopWatch4.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV4.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-5 ON
        private void button15_Click(object sender, EventArgs e)
        {
           
            string tv = "TV5";

            if (textBox5.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV5.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV5.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("f");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button13.Show();
                    button14.Show();
                    button15.Hide();
                    textBox5.ForeColor = Color.SpringGreen;
                    global.TV5 = comboBoxTV5.Text;
                    timer5.Start();
                    StopWatch5.Start();
                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV5.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                }
            }
        }
        //TV-5 OFF
        private void button14_Click(object sender, EventArgs e)
        {
            
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV5")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox5.Text, Convert.ToDecimal(iznosTV5.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("e");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button13.Hide();
                    button14.Hide();
                    button15.Show();
                    textBox5.ForeColor = Color.White;
                    global.TV5 = null;
                    timer5.Stop();
                    StopWatch5.Reset();
                    textBox5.Text = "00:00:00";
                    comboBoxTV5.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-5 RESET
        private void button13_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV5")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox5.Text, Convert.ToDecimal(iznosTV5.Text));

                    timer5.Stop();
                    StopWatch5.Reset();
                    textBox5.Text = "00:00:00";
                    break;
                }
            }

            if (textBox5.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV5.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV5 = comboBoxTV5.Text;
                    timer5.Start();
                    StopWatch5.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV5.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-6 ON
        private void button18_Click(object sender, EventArgs e)
        {
           
            string tv = "TV6";

            if (textBox6.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV6.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV6.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("6");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button16.Show();
                    button17.Show();
                    button18.Hide();
                    textBox6.ForeColor = Color.SpringGreen;
                    global.TV6 = comboBoxTV6.Text;
                    timer6.Start();
                    StopWatch6.Start();
                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV6.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                }
            }
        }
        //TV-6 OFF
        private void button17_Click(object sender, EventArgs e)
        {
            
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV6")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox6.Text, Convert.ToDecimal(iznosTV6.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("7");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button16.Hide();
                    button17.Hide();
                    button18.Show();
                    textBox6.ForeColor = Color.White;
                    global.TV6 = null;
                    timer6.Stop();
                    StopWatch6.Reset();
                    textBox6.Text = "00:00:00";
                    comboBoxTV6.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-6 RESTART
        private void button16_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV6")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox6.Text, Convert.ToDecimal(iznosTV6.Text));

                    timer6.Stop();
                    StopWatch6.Reset();
                    textBox6.Text = "00:00:00";
                    break;
                }
            }

            if (textBox6.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV6.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV6 = comboBoxTV6.Text;
                    timer6.Start();
                    StopWatch6.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV6.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-7 ON
        private void button21_Click(object sender, EventArgs e)
        {
            
            string tv = "TV7";

            if (textBox7.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV7.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV7.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("h");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button19.Show();
                    button20.Show();
                    button21.Hide();
                    textBox7.ForeColor = Color.SpringGreen;
                    global.TV7 = comboBoxTV7.Text;
                    timer7.Start();
                    StopWatch7.Start();
                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV7.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                }
            }
        }
        //TV-7 OFF
        private void button20_Click(object sender, EventArgs e)
        {

            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV7")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox7.Text, Convert.ToDecimal(iznosTV7.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("g");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button19.Hide();
                    button20.Hide();
                    button21.Show();
                    textBox7.ForeColor = Color.White;
                    global.TV7 = null;
                    timer7.Stop();
                    StopWatch7.Reset();
                    textBox7.Text = "00:00:00";
                    comboBoxTV7.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-7 RESET
        private void button19_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV7")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox7.Text, Convert.ToDecimal(iznosTV7.Text));

                    timer7.Stop();
                    StopWatch7.Reset();
                    textBox7.Text = "00:00:00";
                    break;
                }
            }

            if (textBox7.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV7.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV7 = comboBoxTV7.Text;
                    timer7.Start();
                    StopWatch7.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV7.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-8 ON
        private void button24_Click(object sender, EventArgs e)
        {
            string tv = "TV8";

            if (textBox8.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV8.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV8.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("8");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    


                    button22.Show();
                    button23.Show();
                    button24.Hide();
                    textBox8.ForeColor = Color.SpringGreen;
                    global.TV8 = comboBoxTV8.Text;
                    timer8.Start();
                    StopWatch8.Start();

                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV8.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                    global.TV8 = comboBoxTV8.Text;
                }
            }
        }
        //TV-8 OFF
        private void button23_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV8")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox8.Text, Convert.ToDecimal(iznosTV8.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("9");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button22.Hide();
                    button23.Hide();
                    button24.Show();
                    textBox8.ForeColor = Color.White;
                    global.TV8 = null;
                    timer8.Stop();
                    StopWatch8.Reset();
                    textBox8.Text = "00:00:00";
                    comboBoxTV8.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-8 RESET
        private void button22_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV8")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox8.Text, Convert.ToDecimal(iznosTV8.Text));

                    timer8.Stop();
                    StopWatch8.Reset();
                    textBox8.Text = "00:00:00";
                    break;
                }
            }

            if (textBox8.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV8.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV8 = comboBoxTV8.Text;
                    timer8.Start();
                    StopWatch8.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV8.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-9 ON
        private void button27_Click_1(object sender, EventArgs e)
        {
            string tv = "TV9";

            if (textBox9.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV9.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV9.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("b");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button25.Show();
                    button26.Show();
                    button27.Hide();
                    textBox9.ForeColor = Color.SpringGreen;
                    global.TV9 = comboBoxTV9.Text;
                    timer9.Start();
                    StopWatch9.Start();
                    try
                    {
                        konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV9.SelectedValue), DateTime.Now.ToShortTimeString());
                    }
                    catch
                    {
                        MessageBox.Show("Problem upisa u bazu!", "Greška upis u bazu");
                    }
                }
            }
        }
        //TV-9 OFF
        private void button26_Click_1(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV9")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox9.Text, Convert.ToDecimal(iznosTV9.Text));
                    
                    try
                    {
                        serialPort2.Open();
                        serialPort2.WriteTimeout = 200;
                        serialPort2.Write("a");
                        serialPort2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Problem USB ispisa.Nastavak rada bice neophodno restartovati USB!", "Greška USB!");
                        serialPort2.Close();
                        serialPort2.Open();
                        serialPort2.Write("o");
                        serialPort2.Close();
                    }
                    

                    button25.Hide();
                    button26.Hide();
                    button27.Show();
                    textBox9.ForeColor = Color.White;
                    global.TV9 = null;
                    timer9.Stop();
                    StopWatch9.Reset();
                    textBox9.Text = "00:00:00";
                    comboBoxTV9.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-9 RESET
        private void button25_Click_1(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV9")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox9.Text, Convert.ToDecimal(iznosTV9.Text));

                    timer9.Stop();
                    StopWatch9.Reset();
                    textBox9.Text = "00:00:00";
                    break;
                }
            }

            if (textBox9.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV9.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV9 = comboBoxTV9.Text;
                    timer9.Start();
                    StopWatch9.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV9.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }

        //TV-10 ON
        private void button30_Click(object sender, EventArgs e)
        {
            string tv = "TV10";

            if (textBox10.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV10.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    provjeraUpaljeno(tv, comboBoxTV10.SelectedIndex);
                    Data.korisnici korisnik = global.prijavljenKorisnik;

                    button28.Show();
                    button29.Show();
                    button30.Hide();
                    textBox10.ForeColor = Color.SpringGreen;
                    global.TV10 = comboBoxTV10.Text;
                    timer10.Start();
                    StopWatch10.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV10.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }
        //TV-10 OFF
        private void button29_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV10")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox10.Text, Convert.ToDecimal(iznosTV10.Text));

                    button28.Hide();
                    button29.Hide();
                    button30.Show();
                    textBox10.ForeColor = Color.White;
                    global.TV10 = null;
                    timer10.Stop();
                    StopWatch10.Reset();
                    textBox10.Text = "00:00:00";
                    comboBoxTV10.SelectedIndex = 0;
                    break;
                }
            }
        }
        //TV-10 RESET
        private void button28_Click(object sender, EventArgs e)
        {
            List<Data.upapljeno_Result> upaljeno = konzole.upaljeno();

            foreach (Data.upapljeno_Result a in upaljeno)
            {
                if (a.pozicija == "TV10")
                {
                    konzole.updateManager(a.managerID, DateTime.Now.ToShortTimeString(), textBox10.Text, Convert.ToDecimal(iznosTV10.Text));
                    
                    timer10.Stop();
                    StopWatch10.Reset();
                    textBox10.Text = "00:00:00";
                    break;
                }
            }

            if (textBox10.Text != "00:00:00")
            {
                MessageBox.Show("Konzola je vec aktivna");
            }
            else
            {
                if (comboBoxTV10.SelectedIndex == 0)
                {
                    MessageBox.Show("Molim Vas odaberite konzolu.");
                }
                else
                {
                    Data.korisnici korisnik = global.prijavljenKorisnik;
                    global.TV10 = comboBoxTV10.Text;
                    timer10.Start();
                    StopWatch10.Start();

                    konzole.upali(korisnik.KorisnikID, DateTime.Now.Date, Convert.ToInt32(comboBoxTV10.SelectedValue), DateTime.Now.ToShortTimeString());
                }
            }
        }



        //Provjera dal' postoji "prazno" polje / Upaljena
        private void provjeraUpaljeno(string tv, int konzola)
        {
            List<Data.CheckStatusKonzole_Result> konzoleU = konzole.upaljeneKonzole(konzola);

            if (konzoleU != null)
            {
                foreach (Data.CheckStatusKonzole_Result a in konzoleU)
                {
                    if (a.konzolaID == konzola && a.pozicija == tv)
                    {
                        konzole.ugasiSve(a.managerID);
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.IsLogout = 1;

            Login frm = new Login();
            frm.ShowDialog();
        }

       
        

        private void CijenaPrikaz()
        {
           
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.IsLogout = 1;

            Login frm = new Login();
            frm.ShowDialog();

        }

        private void opcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if(global.IsADmin==true)
            {

                Manager frm = new Manager();
                global.isOptions = 1;
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Zabranjen pristup!");
            }
        }

       
        private void button5_Click(object sender, EventArgs e)
        {

            if(global.IsADmin==true)
            {
                Manager frm = new Manager();
                global.isOptions = 1;
                frm.ShowDialog();
            }
            else
            {

                MessageBox.Show("Zabranjen pristup!");
            }
        }


        //Ostatak
        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBoxTV3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {

        }
        private void button5_Click_2(object sender, EventArgs e)
        {

        }
        private void button6_Click_1(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void refreshBazeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxTV1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cjenovnik(Label labelIznos,string konzola,string vrijemeT,Label label)
        {
            DateTime vrijeme = Convert.ToDateTime(vrijemeT);
            List<Data.Cjenovnik> cjenovnici = global.Cjenovnik;
            
            
            foreach (Data.Cjenovnik a in cjenovnici)
            {
                if (a.Konzola == konzola && vrijeme < Convert.ToDateTime(a.Vrijeme_do) && vrijeme > Convert.ToDateTime(a.Vrijeme_od))
                {
                    label.Text = a.Cijena;
                    
                }


            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Aplikacija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvjestajPoDatumu frm = new IzvjestajPoDatumu();
            frm.ShowDialog();
        }

    }
}
