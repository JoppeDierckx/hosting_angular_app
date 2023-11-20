using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Activiteit
    {
        [Key]
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
