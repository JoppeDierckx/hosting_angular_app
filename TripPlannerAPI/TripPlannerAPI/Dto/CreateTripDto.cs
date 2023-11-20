using TripPlannerDAL.Entity;

namespace TripPlannerAPI.Dto
{
    public class CreateTripDto
    {
        public string? naam { get; set; }
        public DateTime startDatum { get; set; }
        public DateTime eindDatum { get; set; }
        public int lengte { get; set; }
        public ICollection<Activiteit>? activiteiten { get; set; }
        public ICollection<UserTrip>? userTrips { get; set; }
    }
}
