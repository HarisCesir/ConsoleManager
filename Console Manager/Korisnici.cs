using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Manager
{
   public class Korisnici
    {
        public static void InsertKorisnik(Data.korisnici korisnik)
        {
            connection.db.insertkorisnici(korisnik.Ime, korisnik.Prezime, korisnik.KorisnickoIme, korisnik.LozinkaSalt, korisnik.LozinkaHash,korisnik.IsAdmin);
        }
        public static Data.korisnici SelectByKorisnickoIme(string korisnickoime, string lozinka)
        {
           Data.korisnici ko = connection.db.selectByKorisnickoIme(korisnickoime).FirstOrDefault();
            if (ko != null && UiHelper.GenerateHash(lozinka, ko.LozinkaSalt) == ko.LozinkaHash.Trim())
            {

                return ko;

            }
            return null;
        }
    }
}
