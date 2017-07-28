using AutoMapper;
using CityInfo.API.DTOs;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepo)
        {
            this.cityInfoRepository = cityInfoRepo;
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            var cities = this.cityInfoRepository.GetCities();
            var mappedEntities = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cities);

            return Ok(mappedEntities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            var selectedCity = this.cityInfoRepository.GetCity(id, includePointsOfInterest);
            if (selectedCity == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                var mappedCities = Mapper.Map<CityDto>(selectedCity);
                return Ok(mappedCities);
            }

            var justCities = Mapper.Map<CityWithoutPointsOfInterestDto>(selectedCity);
            return Ok(justCities);
        }
    }
}
