using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly List<Country> _countries;

        public CountryController(ILogger<CountryController> logger,
            List<Country> countries)
        {
            _logger = logger;
            _countries = countries; // Example: You might replace this with actual data access layer.
        }

        // GET: api/country/all
        [HttpGet("all")]
        public IActionResult GetCountries()
        {
            return Ok(_countries);
        }

        // GET: api/country/5
        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            var country = _countries.Find(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/country
        [HttpPost("insert")]
        public IActionResult CreateCountry(Country country)
        {
            // Example: You might add validation and actual data insertion logic here.
            country.Id = _countries.Count + 1;
            _countries.Add(country);
            return Ok(country);
        }

        // PUT: api/country/5
        [HttpPut("{id}")]
        public IActionResult UpdateCountry(int id, Country country)
        {
            var existingCountry = _countries.Find(c => c.Id == id);
            if (existingCountry == null)
            {
                return NotFound();
            }
            existingCountry.Name = country.Name; // Update fields as needed
                                                 // Example: You might add validation and actual data update logic here.
            return NoContent();
        }

        // DELETE: api/country/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            var existingCountry = _countries.Find(c => c.Id == id);
            if (existingCountry == null)
            {
                return NotFound();
            }
            _countries.Remove(existingCountry);
            // Example: You might add actual data deletion logic here.
            return NoContent();
        }
    }
}
