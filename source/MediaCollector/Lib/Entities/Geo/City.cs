namespace Lib.Entities.Geo
{
    public class City
    {
        public int Id {get; set;}
        public int Title {get; set;}
        public int CountryId {get; set;}
        public Country Country {get; set;}
    }
}