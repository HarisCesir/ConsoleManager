using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Manager
{
   public class konzole
    {
        //Ucitavanje TV-1
        public static List<Data.konzola> konzoleTV1()
        {
            List<Data.konzola> lista = connection.db.konzoleTV1().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.naziv = "IZBOR KONZOLE";
            konzola.pozicija = "";

            lista.Insert(0, konzola);
            return lista;
            

        }
        //Ucitavanje TV-2
        public static List<Data.konzola> konzoleTV2()
        {
            List<Data.konzola> lista = connection.db.konzoleTV2().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-3
        public static List<Data.konzola> konzoleTV3()
        {
            List<Data.konzola> lista = connection.db.konzoleTV3().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-4
        public static List<Data.konzola> konzoleTV4()
        {
            List<Data.konzola> lista = connection.db.konzoleTV4().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-5
        public static List<Data.konzola> konzoleTV5()
        {
            List<Data.konzola> lista = connection.db.konzoleTV5().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-6
        public static List<Data.konzola> konzoleTV6()
        {
            List<Data.konzola> lista = connection.db.konzoleTV6().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-7
        public static List<Data.konzola> konzoleTV7()
        {
            List<Data.konzola> lista = connection.db.konzoleTV7().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-8
        public static List<Data.konzola> konzoleTV8()
        {
            List<Data.konzola> lista = connection.db.konzoleTV8().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;
        }
        //Ucitavanje TV-9
        public static List<Data.konzola> konzoleTV9()
        {
            List<Data.konzola> lista = connection.db.konzoleTV9().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-10
        public static List<Data.konzola> konzoleTV10()
        {
            List<Data.konzola> lista = connection.db.konzoleTV10().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-11
        public static List<Data.konzola> konzoleTV11()
        {
            List<Data.konzola> lista = connection.db.konzoleTV11().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje TV-12
        public static List<Data.konzola> konzoleTV12()
        {
            List<Data.konzola> lista = connection.db.konzoleTV12().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;

        }
        //Ucitavanje svi konzola
        public static List<Data.konzola> KonzoleAll()
        {
            List<Data.konzola> lista = connection.db.SelectAllKonzole().ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;
        }

        public static List<Data.ListaKonzola> KonzoleLista()
        {
            List<Data.ListaKonzola> lista = connection.db.SveKonzole().ToList();
            Data.ListaKonzola konzola = new Data.ListaKonzola();
            konzola.ListaKonzolaID = 0;
            
            konzola.Naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;
        }
        public static void DodajKonzoluLista(string naziv)
        {
            connection.db.InsertKonzole(naziv);
        }

        public static List<string> Televizije()
        {
            List<Data.konzola> lista = connection.db.SelectAllKonzole().ToList();

            List<string> tv = new List<string>();

            foreach(Data.konzola k in lista)
            {
                int i = 0;

                foreach(string a in tv)
                {
                    if(a==k.pozicija)
                    {
                        i = 1;
                    }
                }

                if(i==0)
                {
                    tv.Add(k.pozicija);
                }
            }

            return tv;
        }

        public static void DodajKonzolu(string pozicija, string naziv)
        {
            connection.db.DodajKonzolu(pozicija, naziv);
        }

        public static List<Data.konzola> KonzoleTV(string tv)
        {
            List<Data.konzola> lista = connection.db.KonzolaPoTV(tv).ToList();
            Data.konzola konzola = new Data.konzola();
            konzola.konzolaID = 0;
            konzola.pozicija = "";
            konzola.naziv = "IZBOR KONZOLE";

            lista.Insert(0, konzola);

            return lista;
        }
        public static void BrisiKonzola(int konzolaID)
        {
            connection.db.BrisiKonzolu(konzolaID);
        }
        public static void upali(int korisnikID, DateTime datum, int konzola, string pocetnovrijeme)
        {
            connection.db.upaljena(korisnikID, datum, konzola, pocetnovrijeme);
        }
        public static void upali2(int korisnikID, string datum, int konzola, string pocetnovrijeme)
        {
            connection.db.upaljena2(korisnikID, datum, konzola, pocetnovrijeme);
        }
       

        public static void updateManager(int managerID, string zavrsetak, string totaltime, decimal cijena)
        {
            connection.db.updateManager(managerID, zavrsetak, totaltime, cijena);
        }
        public static List<Data.upapljeno_Result> upaljeno()
        {
            return connection.db.upapljeno().ToList();
        }
       public static void ugasiSve(int managerID)
       {

           connection.db.UgasiSve(managerID);
        }

       public static List<Data.CheckStatusKonzole_Result> upaljeneKonzole(int konzolaID)
       {
           return connection.db.CheckStatusKonzole(konzolaID).ToList();
       }
       public static void BrisiKonzoluSaListe(int konzolaID)
       {
           connection.db.BrisiListaKonzola(konzolaID);
       }
       public static void Ugasi()
       {
           connection.db.Ugasi();
       }
   
    }
}
