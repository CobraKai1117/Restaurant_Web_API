using Restaurant_Web_API.Models;


namespace Restaurant_Web_API.Database.Data_Filtering
{
    
    public class RestaurantSearchResultModel
    {

        public string Message { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }


    }
}
