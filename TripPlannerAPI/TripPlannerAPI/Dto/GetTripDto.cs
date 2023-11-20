using TripPlannerDAL.Entity;

namespace TripPlannerAPI.Dto
{
    public class GetTripDto
    {
        public int tripId { get; set; }
        public string naam { get; set; }
        public DateTime startDatum { get; set; }
        public DateTime eindDatum { get; set; }
        public int lengte { get; set; }
        public IEnumerable<Activiteit>? activiteiten { get; set; }
        public IEnumerable<UserTrip>? userTrips { get; set; }

    }
}
