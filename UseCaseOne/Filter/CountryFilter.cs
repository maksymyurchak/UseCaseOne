using UseCaseOne.Models;

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
    }
    }
