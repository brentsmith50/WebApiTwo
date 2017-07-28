using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.DTOs
{
    public class CitiesDataStore
    {
        public static CitiesDataStore CurrentStore { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "Has a large downtown park.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDto
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Los Angeles",
                    Description = "Has many movie studios.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 3,
                            Name = "Mount Wilson",
                            Description = "Observatory at high elevation"
                        },
                        new PointOfInterestDto
                        {
                            Id = 4,
                            Name = "Sunset Blvd",
                            Description = "Where the beautiful people hangout to be SEEN!"
                        }
                    }
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Denver",
                    Description = "Has amazing mountains nearby.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 5,
                            Name = "Rocky Mountain National Park",
                            Description = "Amazzzzing mountains"
                        },
                        new PointOfInterestDto
                        {
                            Id = 6,
                            Name = "Aspen",
                            Description = "High Class ski resort for exclusive people only!"
                        }
                    }
                },
            };
        }
    }
}
