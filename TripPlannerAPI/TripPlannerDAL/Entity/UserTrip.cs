using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class UserTrip
    {
        public int Id { get; set; }
        public int? tripId { get; set; }
        public Trip? trip { get; set; }
        public int? gebruikerId { get; set; }
        public Gebruiker? gebruiker { get; set; }
        public bool isEigenaar { get; set; }

    }
}
