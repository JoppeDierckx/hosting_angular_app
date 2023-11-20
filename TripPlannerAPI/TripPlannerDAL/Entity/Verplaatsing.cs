using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Verplaatsing : Activiteit
    {
        public int? eindplaatsId { get; set; }
        public Plaats? eindplaats { get; set; }
        public int prijs { get; set; }
    }
}