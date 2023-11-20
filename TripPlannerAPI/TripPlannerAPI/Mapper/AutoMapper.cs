using AutoMapper;
using System.Text.Json;
using TripPlannerAPI.Dto;
using TripPlannerDAL.Entity;

namespace TripPlannerAPI.Mapper
{
    public class AutoMapper : Profile

    {

        public AutoMapper() {
            CreateMap<GetTripDto, Trip>();
            CreateMap<Trip, GetTripDto>();
            CreateMap<GetActivityDto, Activiteit>();
            CreateMap<Activiteit, GetActivityDto>();

        }

    }
}
