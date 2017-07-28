using CityInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class CityContextController : Controller
    {
        private CityInfoContext cityDbContext;

        public CityContextController(CityInfoContext cityDbContext)
        {
            this.cityDbContext = cityDbContext;
        }


        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
