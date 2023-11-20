using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Verblijf : Activiteit
    {
        public string adres { get; set; }
        public int slaapPlaatsen { get; set; }
        public int prijsPerNacht { get; set; }
    }
}
