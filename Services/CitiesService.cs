using ServiceContract;

namespace Services
{
    public class CitiesService : ICitiesService
    {
        private List<string> _cities;
        public CitiesService()
        {
            _cities = new List<string>()
            {
                "Chennai",
                "Bangalore",
                "Hyderabad",
                "Pune",
                "Delhi",
                "Mumbai",
                "Kolkata"
            };
        }
        public List<string> GetCities()
        {
            return _cities;
        }
    }
}