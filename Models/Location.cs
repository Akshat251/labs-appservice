using System.ComponentModel.DataAnnotations;

namespace BrezyWeather.Models
{
    public class Location
    {
        //This comment am adding to check workflow for any edits
        //This is second comment am adding to check staging workflow
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int Zipcode { get; set; }
    }
}
