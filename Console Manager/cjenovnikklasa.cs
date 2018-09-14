using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Manager
{
   public class cjenovnikklasa
    {
       public static List<Data.Cjenovnik> SelectAll()
       {
           return connection.db.SELECTCjenovnik().ToList();
       }
       public static void InsertCjenovnik(Data.Cjenovnik cjenovnik)
       {
           connection.db.InsertCjenovnik(cjenovnik.Konzola, cjenovnik.Vrijeme_od, cjenovnik.Vrijeme_do, cjenovnik.Cijena);
       }
       public static Data.Cjenovnik cjenovnik(int cjenovnikID)
       {
           return connection.db.SelectCjenovnikByID(cjenovnikID).FirstOrDefault();
       }

       public static void CjenovnikIzmjena(int cjenovnikID,string cijena)
       {
           connection.db.UpdataCjenovnik(cjenovnikID, cijena);
       }
       public static void CjenovnikBrisi(int cjenovnikID)
       {
           connection.db.obrisiCjenovnik(cjenovnikID);
       }
       
    }
}
