using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
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
        public async Task<IEnumerable<CountryInfo>> Get()
        {
            var result = await countryService.GetAllAsync();
            return result;
        }
    }
}
