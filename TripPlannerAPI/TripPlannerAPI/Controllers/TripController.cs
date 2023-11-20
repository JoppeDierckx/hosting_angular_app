using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using TripPlannerAPI.Dto;
using TripPlannerDAL;
using TripPlannerDAL.Entity;

namespace TripPlannerAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class TripController : Controller
    {
        private readonly TripPlannerDbContext _context;
        private readonly IMapper _mapper;
        public TripController(TripPlannerDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetTripDto>> GetTrip(int id)
        {
            var trip = await _context.Trips.Include(t => t.userTrips).Include(t => t.activiteiten).SingleAsync(t => t.tripId == id);

            if (trip == null)
            {
                return NotFound();
            }

            return _mapper.Map<GetTripDto>(trip);
        }
        [HttpGet]
        public async Task<ActionResult<List<GetTripDto>>> GetTrips()
        {
            var trips = await _context.Trips.Include(t => t.activiteiten).ToListAsync();

            if (trips == null)
            {
                return NotFound();
            }

            return _mapper.Map<List<GetTripDto>>(trips);
        }

        [HttpGet("get/{modelName}")]
        public async Task<ActionResult<List<object>>> GetModelInstances(string modelName)
        {
            var modelInstances = await GetModelInstancesAsync(modelName);

            if (modelInstances == null)
            {
                return NotFound();
            }

            // Use AutoMapper to map the model instances to DTOs
            var dtoList = _mapper.Map<List<object>>(modelInstances);

            return dtoList;
        }

        private async Task<List<object>> GetModelInstancesAsync(string modelName)
        {
            switch (modelName.ToLower())
            {
                case "trips":
                    var trips = await _context.Trips.ToListAsync();
                    return trips.Select(t => _mapper.Map<GetTripDto>(t)).Cast<object>().ToList();
                case "activiteiten":
                    var activities = await _context.Activiteiten.ToListAsync();
                    return activities.Select(t => _mapper.Map<GetActivityDto>(t)).Cast<object>().ToList();

                // Add more cases for other models as needed
                default:
                    return null; // Model not found
            }
        }
        [HttpPost("create/{modelName}")]
        public async Task<ActionResult<object>> CreateModelInstance(string modelName, [FromBody] object createDto)
        {
            var modelInstance = await CreateModelInstanceAsync(modelName, createDto);

            if (modelInstance == null)
            {
                return BadRequest(); // You might want to customize this based on your validation logic
            }

            // Use AutoMapper to map the created model instance to DTO
            var dto = _mapper.Map<object>(modelInstance);

            return dto;
        }

        private async Task<object> CreateModelInstanceAsync(string modelName, object createDto)
        {
            switch (modelName.ToLower())
            {
                case "trips":
                    if (createDto is JsonElement jsonElement)
                    {
                        var jsonString = jsonElement.GetRawText();
                        var tripDto = JsonSerializer.Deserialize<CreateTripDto>(jsonString);

                        var trip = new Trip
                        {
                            naam = tripDto.naam,
                            startDatum = tripDto.startDatum,
                            eindDatum = tripDto.eindDatum,
                            lengte = tripDto.lengte,
                            activiteiten = tripDto.activiteiten,
                            userTrips = tripDto.userTrips
                        };

                        foreach (var activiteit in trip.activiteiten)
                        {
                            activiteit.trip = trip; // Set the trip for each activiteit
                        }

                        _context.Trips.Add(trip);

                        foreach (var activiteit in trip.activiteiten)
                        {
                            _context.Entry(activiteit).State = EntityState.Added; // Explicitly set EntityState for each activiteit
                        }

                        await _context.SaveChangesAsync();

                        return trip;
                    }
                    break;

                // Add more cases for other models as needed
                default:
                    return null; // Model not found
            }

            return null; // Default return
        }


    }
}
