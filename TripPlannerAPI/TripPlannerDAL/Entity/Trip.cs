using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Trip
    {
        public int tripId {  get; set; }
        public string? naam { get; set; }
        public DateTime startDatum { get; set; }
        public DateTime eindDatum { get; set; }
        public int lengte { get; set; }
        public ICollection<Activiteit>? activiteiten { get; set; }
        public ICollection<UserTrip>? userTrips { get; set; }
    }
}
