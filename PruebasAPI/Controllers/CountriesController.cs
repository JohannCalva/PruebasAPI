using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebasAPI.Repositories;

namespace PruebasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private CountriesRepository _repo;
        public CountriesController()
        {
            _repo = new CountriesRepository();
        }
        

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetCountryList()
        {
            try
            {
                var countries = await _repo.GetCountryListAsync();
                return Ok(countries);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
            
        }
    }
}
