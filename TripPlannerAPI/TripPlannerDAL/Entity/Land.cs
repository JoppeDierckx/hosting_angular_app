using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Land
    {
        public int landId { get; set; }
        public string naam { get; set; }
        public int? continentId { get; set; }
        public Continent? continent { get; set; }
        public ICollection<Plaats>? plaatsen { get; set; }
    }
}
