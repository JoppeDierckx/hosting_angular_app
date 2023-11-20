using TripPlannerDAL;
using TripPlannerDAL.Entity;
using System.Diagnostics;

namespace TripPlannerDAL.Initializer
{
    public class DBInitializer
    {
        public static void Initialize(TripPlannerDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Seed the Trips table with some dummy data
            if (!context.Trips.Any())
            {
                var activiteiten = new Activiteit[]
                {
                    new Activiteit
                    {
                         activiteitNaam = "dansen", startDatum = DateTime.Now, eindDatum = DateTime.Now, personenAantal = 10,
                    },
                    new Activiteit
                    {
                        activiteitNaam = "lopen", startDatum = DateTime.Now, eindDatum = DateTime.Now, personenAantal = 10,
                    },
                    new Activiteit
                    { activiteitNaam = "gaan", startDatum = DateTime.Now, eindDatum = DateTime.Now, personenAantal = 10},
                    new Activiteit
                    { activiteitNaam = "praten", startDatum = DateTime.Now, eindDatum = DateTime.Now, personenAantal = 10}
                }
                ;
                foreach (Activiteit i in activiteiten)
                {
                    context.Activiteiten.Add(i);
                }
                var verplaatsingen = new Verplaatsing[]
                {
                    new Verplaatsing
                    {
                       prijs = 150, activiteitNaam = "verplaatsing1", eindDatum= DateTime.Now, personenAantal= 10, startDatum = DateTime.Now, 
                    },
                    new Verplaatsing
                    {
                       prijs = 150, activiteitNaam = "verplaatsing2", eindDatum= DateTime.Now, personenAantal= 10, startDatum = DateTime.Now,
                    },
                    new Verplaatsing
                    {
                        prijs = 150, activiteitNaam = "verplaatsing3", eindDatum= DateTime.Now, personenAantal= 10, startDatum = DateTime.Now,
                    },
                    new Verplaatsing
                    {
                        prijs = 150, activiteitNaam = "verplaatsing4", eindDatum= DateTime.Now, personenAantal= 10, startDatum = DateTime.Now,
                    }
                }
                ;
                foreach (Verplaatsing h in verplaatsingen)
                {
                    context.Verplaatsingen.Add(h);
                }

                var entertainments = new Entertainment[]
                {
                    new Entertainment
                    {
                        activiteitNaam = "entertainment1", eindDatum = DateTime.Now, personenAantal = 4, PrijsPerPersoon = 5, startDatum = DateTime.Now
                    },
                    new Entertainment
                    {
                        activiteitNaam = "entertainment2", eindDatum = DateTime.Now, personenAantal = 4, PrijsPerPersoon = 5, startDatum = DateTime.Now
                    },
                    new Entertainment
                    {
                        activiteitNaam = "entertainment3", eindDatum = DateTime.Now, personenAantal = 4, PrijsPerPersoon = 5, startDatum = DateTime.Now
                    },
                    new Entertainment
                    {
                        activiteitNaam = "entertainment4", eindDatum = DateTime.Now, personenAantal = 4, PrijsPerPersoon = 5, startDatum = DateTime.Now
                    } }
                ;
                foreach (Entertainment g in entertainments)
                {
                    context.Entertainments.Add(g);
                }
                var verblijven = new Verblijf[]
                {
                    new Verblijf
                    {
                        adres = "toverlaan", prijsPerNacht = 5000, slaapPlaatsen = 5, activiteitNaam = "verblijf1", eindDatum= DateTime.Now, startDatum = DateTime.Now, personenAantal = 10, 
                    },
                    new Verblijf
                    {
                        adres = "toverlaan", prijsPerNacht = 5000, slaapPlaatsen = 5, activiteitNaam = "verblijf2", eindDatum= DateTime.Now, startDatum = DateTime.Now, personenAantal = 10,
                    },
                    new Verblijf
                    {
                        adres = "toverlaan", prijsPerNacht = 5000, slaapPlaatsen = 5, activiteitNaam = "verblijf3", eindDatum = DateTime.Now, startDatum = DateTime.Now, personenAantal = 10
                    },
                    new Verblijf
                    {
                        adres = "toverlaan", prijsPerNacht = 5000, slaapPlaatsen = 5, activiteitNaam = "verblijf4", eindDatum = DateTime.Now, startDatum = DateTime.Now, personenAantal = 10
                    }
                };

                foreach (Verblijf f in verblijven)
                {
                    context.Verblijven.Add(f);
                }
                var trips = new Trip[]
                {
                    new Trip
                    {
                        naam = "Naar bolivie",startDatum = DateTime.Now, eindDatum = DateTime.Now, lengte = 5
                    },
                    new Trip
                    {
                        naam = "naar azie",startDatum = DateTime.Now, eindDatum = DateTime.Now, lengte = 5
                    },
                    new Trip
                    {
                         naam = "Naar den afrique",startDatum = DateTime.Now, eindDatum = DateTime.Now, lengte = 5
                    },
                    new Trip
                    {
                        naam = "naar japan",startDatum = DateTime.Now, eindDatum = DateTime.Now, lengte = 5,
                    }
                };
                foreach (Trip e in trips)
                {
                    context.Trips.Add(e);
                }

                var users = new Gebruiker[]
                {
                    new Gebruiker
                    {
                        voornaam = "Joppe",
                        achternaam = "Van Dierckxen",
                        adres = "Uitbreidingsstraat 48",
                        hashedwachtwoord = "QDUNQSDLIUQSBDLXWNDWSUJD",
                        isActief = true,
                        isAdmin = true,
                        mail = "Joppe.vanDierckxen@hotmail.be",

                    },
                    new Gebruiker
                    {
                        voornaam = "Ted",
                        achternaam = "Bundy",
                        adres = "Zzyzx road",
                        hashedwachtwoord = "QDUNQSDLIUQSBDLXWNDWSUJA",
                        isActief = true,
                        isAdmin = false,
                        mail = "TedBundy@gmail.com",
                    },
                    new Gebruiker
                    {
                        voornaam = "Michel",
                        achternaam = "Van Aertsen",
                        adres = "combat road",
                        hashedwachtwoord = "QDUNQSDLIUQSBDLXWNDWSUJB",
                        isActief = true,
                        isAdmin = false,
                        mail = "MichelAertsen@hotmail.be",

                    },
                    new Gebruiker
                    {
                        voornaam = "Jarne",
                        achternaam = "Baelus",
                        adres = "Kwakkelstraat",
                        hashedwachtwoord = "QDUNQSDLIUQSBDLXWNDWSUJT",
                        isActief = true,
                        isAdmin = false,
                        mail = "JarneBaelus@gmail.be",

                    },
                };
                foreach (Gebruiker d in users)
                {
                    context.Gebruikers.Add(d);
                }

                var plaatsen = new Plaats[]
                {
                    new Plaats
                    {
                        naam = "Borgerhout",
                        postcode = "5500"
                    },
                    new Plaats
                    {
                        naam = "De walen",
                        postcode = "510"
                    },
                    new Plaats
                    {
                        naam = "De wadde eilanden",

                        postcode = "9875"
                    },
                    new Plaats
                    {
                        naam = "harare",

                        postcode = "4500"
                    },
                };
                foreach (Plaats a in plaatsen)
                {
                    context.Plaatsen.Add(a);
                }

                var landen = new Land[]
                {
                    new Land
                    {
                        naam = "België",

                    },
                    new Land
                    {
                        naam = "Frankrijk",

                    },
                    new Land
                    {
                        naam = "Bolivia",

                    },
                    new Land
                    {
                        naam = "Oostenrijk",

                    },
                };
                foreach (Land b in landen)
                {
                    context.Landen.Add(b);
                }

                var continenten = new Continent[]
                {
                    new Continent
                    {

                        Naam = "Afrika"
                    },
                    new Continent
                    {

                        Naam = "Europa"
                    },
                };
                foreach (Continent c in continenten)
                {
                    context.Continenten.Add(c);
                }

                context.SaveChanges();
            }
        }
    }
}
