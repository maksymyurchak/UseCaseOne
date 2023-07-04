using UseCaseOne.Models;

namespace UseCaseOne.Interfaces
{
	public interface ICountryService
	{
		/// <summary>
		/// Retrieves all country information.
		/// </summary>
		/// <returns>A task that represents the asynchronous operation. The task result contains a list of CountryInfo objects.</returns>
		Task<IEnumerable<CountryInfo>> GetAllAsync();
	}
}
