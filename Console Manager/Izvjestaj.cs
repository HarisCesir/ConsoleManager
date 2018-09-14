using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Manager
{
  public class Izvjestaj
    {
        public static List<Data.IzvjestajPoDatumu_Result> IzvjestajPoDatumu(DateTime DatumOD, DateTime DatumDO)
        {
            return connection.db.IzvjestajPoDatumu(DatumOD, DatumDO).ToList();
        }

      public static List<Data.TEst_Result> testiram()
        {
            return connection.db.TEst().ToList();
        }
      public static void DeleteIzvjestaj(DateTime DatumOD, DateTime DatumDO)
      {
          connection.db.DeleteIzvjesta(DatumOD, DatumDO);
      }
    }
}
