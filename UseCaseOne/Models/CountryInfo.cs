
namespace UseCaseOne.Models
{

    public partial class CountryInfo
    {
        public Name Name { get; set; }

        public IEnumerable<string> Tld { get; set; }

        public string Cca2 { get; set; }

        public string Ccn3 { get; set; }

        public string Cca3 { get; set; }

        public string Cioc { get; set; }

        public bool Independent { get; set; }

        public string Status { get; set; }

        public bool UnMember { get; set; }

        public Currencies Currencies { get; set; }

        public Idd Idd { get; set; }

        public IEnumerable<string> Capital { get; set; }

        public IEnumerable<string> AltSpellings { get; set; }

        public string Region { get; set; }

        public string Subregion { get; set; }

        public Languages Languages { get; set; }
 
        public Dictionary<string, Translation> Translations { get; set; }

        public IEnumerable<double> Latlng { get; set; }

        public bool Landlocked { get; set; }

        public IEnumerable<string> Borders { get; set; }

        public double Area { get; set; }

        public Dictionary<string, Dictionary<string, string>> Demonyms { get; set; }

        public string Flag { get; set; }

        public Maps Maps { get; set; }

        public long Population { get; set; }

        public Gini Gini { get; set; }

        public string Fifa { get; set; }

        public Car Car { get; set; }

        public IEnumerable<string> Timezones { get; set; }

        public IEnumerable<string> Continents { get; set; }

        public Flags Flags { get; set; }

        public CoatOfArms CoatOfArms { get; set; }

        public string StartOfWeek { get; set; }

        public CapitalInfo CapitalInfo { get; set; }

        public PostalCode PostalCode { get; set; }
    }

    public partial class CapitalInfo
    {
        public IEnumerable<double> Latlng { get; set; }
    }

    public partial class Car
    {
        public IEnumerable<string> Signs { get; set; }

        public string Side { get; set; }
    }

    public partial class CoatOfArms
    {
        public string Png { get; set; }

        public string Svg { get; set; }
    }

    public partial class Currencies
    {
        public Jod Jod { get; set; }
    }

    public partial class Jod
    {
        public string Name { get; set; }

        public string Symbol { get; set; }
    }


    public partial class Flags
    {
        public string Png { get; set; }

        public string Svg { get; set; }

        public string Alt { get; set; }
    }

    public partial class Gini
    {
        public double The2010 { get; set; }
    }

    public partial class Idd
    {
        public string Root { get; set; }

        public IEnumerable<string> Suffixes { get; set; }
    }

    public partial class Languages
    {
        public string Ara { get; set; }
    }

    public partial class Maps
    {
        public string GoogleMaps { get; set; }

        public string OpenStreetMaps { get; set; }
    }

    public partial class Name
    {
        public string Common { get; set; }

        public string Official { get; set; }

        public NativeName NativeName { get; set; }
    }

    public partial class NativeName
    {
        public Translation Ara { get; set; }
    }

    public partial class Translation
    {
        public string Official { get; set; }


        public string Common { get; set; }
    }

    public partial class PostalCode
    {
        public string Format { get; set; }

        public string Regex { get; set; }
    }
}
