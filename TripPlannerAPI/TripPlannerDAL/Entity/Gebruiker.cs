using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace TripPlannerDAL.Entity
{
    public class Gebruiker
    {
        [Key]
        public int userId { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string mail { get; set; }
        public string hashedwachtwoord { get; set; }
        public bool isAdmin { get; set; }
        public bool isActief { get; set; }
        public string adres { get; set; }
        public int? plaatsId { get; set; }
        public Plaats? plaats { get; set; }
        public ICollection<UserTrip>? userTrips { get; set; }

        public void HashPassword(string password)
        {
            // Hash the password and store it in the hashedwachtwoord property
            hashedwachtwoord = BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            // Compare the provided password with the hashed password
            return BCrypt.Net.BCrypt.Verify(password, hashedwachtwoord);
        }
    }
}
