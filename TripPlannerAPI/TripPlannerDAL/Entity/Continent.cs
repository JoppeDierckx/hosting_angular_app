using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Continent
    {
        public int ContinentId { get; set; }
        public string Naam { get; set; }
        public ICollection<Land>? Landen { get; set; }
    }
}
