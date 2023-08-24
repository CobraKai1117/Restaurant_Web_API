using Microsoft.EntityFrameworkCore;
using Restaurant_Web_API.Models;

namespace Restaurant_Web_API.Database_Class
{


    public class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) 
        {
        
        }

        public DbSet<Restaurant> RestaurantSet { get; set; }


    }
}
