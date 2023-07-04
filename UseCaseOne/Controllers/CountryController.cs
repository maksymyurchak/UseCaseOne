using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using UseCaseOne.Filter;
using UseCaseOne.Interfaces;
using UseCaseOne.Models;

namespace UseCaseOne.Controllers
{
	[ApiController]
	[Produces(MediaTypeNames.Application.Json)]
	[Route("api/[controller]")]
	public class CountryController : ControllerBase
	{
		private readonly ICountryService countryService;

		public CountryController(ICountryService countryService)
		{
			this.countryService = countryService;
		}

        [HttpGet]
        public async Task<IEnumerable<CountryInfo>> Get([FromQuery] string name = null, [FromQuery] int? population = null)
        {
            var countries = await countryService.GetAllAsync();
			var result = countries.FilterByName(name).FilterByPopulation(population);

			return result;
		}
    }
}
