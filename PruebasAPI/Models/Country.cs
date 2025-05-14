namespace PruebasAPI.Models
{
    public class Country
    {
        public CountryName name { get; set; }
        public bool independent { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
    }

    public class CountryName
    {
        public string common { get; set; }
        public string official { get; set; }
    }
}
