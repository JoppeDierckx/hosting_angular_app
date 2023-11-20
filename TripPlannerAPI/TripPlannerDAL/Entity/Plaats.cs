using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerDAL.Entity
{
    public class Plaats
    {
        [Key]
        public int plaatsId { get; set; }
        public int? landId { get; set; }
        public Land? land { get; set; }
        public string naam { get; set; }
        public string postcode { get; set; }
        public ICollection<Gebruiker>? gebruikers { get; set; }
        public ICollection<Activiteit>? activiteiten { get; set; }
    }
}
