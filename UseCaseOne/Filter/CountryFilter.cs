﻿using UseCaseOne.Models;

namespace UseCaseOne.Filter
{
	public static class CountryFilter
	{
		public static IEnumerable<CountryInfo> FilterByName(this IEnumerable<CountryInfo> countries, string name)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				return countries.Where(country => country.Name.Common.Contains(name));
			}
			return countries;
		}

		public static IEnumerable<CountryInfo> FilterByPopulation(this IEnumerable<CountryInfo> countries, int? populationInMillions)
		{
			if (populationInMillions.HasValue)
			{
				// Convert populationInMillions to just population (because populationInMillions is in millions)
				int population = populationInMillions.Value * 1_000_000;

				// Filter countries where the population is less than the provided population
				return countries.Where(country => country.Population < population);
			}
			return countries;
		}
	}

}