using TripPlannerDAL.Entity;

namespace TripPlannerAPI.Dto
{
    public class GetActivityDto
    {
        public int activiteitId { get; set; }
        public string activiteitNaam { get; set; }
        public int? plaatsId { get; set; }
        public Plaats? plaats { get; set; }
        public DateTime startDatum { get; set; }
        public DateTime eindDatum { get; set; }
        public int personenAantal { get; set; }
        public int? tripId { get; set; }
        public Trip? trip { get; set; }
    }
}
