using Microsoft.AspNetCore.Mvc;
using Restaurant_Web_API.Models;
using Restaurant_Web_API.Database_Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.WebUtilities;
using Restaurant_Web_API.Database.Data_Filtering;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant_Web_API.Controllers
{
    [Route("api/Restaurant")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        // GET: api/<RestaurantController> // Returns all Restaurants from Database
        [HttpGet]
        public async Task<IEnumerable<Restaurant>> GetRestaurantAsync(int RestaurantId, RestaurantContext context)
        {

            IQueryable<Restaurant> query = context.RestaurantSet.OrderByDescending(b => b.inspection_date).Take(20);

            List<Restaurant> restaurantData = await query.ToListAsync();

            return restaurantData;
            
        }

        // GET api/<RestaurantController>/Charlies Deli Cafe // Returns restaurants based on name, sorted descended by date
        [HttpGet("{businessName}")]
        public async Task<RestaurantSearchResultModel> GetSpecificRestaurantAsync(string businessName, RestaurantContext context)
        {
            // var restaurantData = await context.RestaurantSet.OrderByDescending(b => b.inspection_date).Where(b=>b.business_name == businessName).Take(20).ToListAsync();

            // var restaurantData = await context.RestaurantSet.OrderByDescending(b => b.inspection_date).Where(b => b.business_name == businessName).ToListAsync();

            RestaurantSearchResultModel searchResults = new RestaurantSearchResultModel();

            IQueryable<Restaurant> query = context.RestaurantSet.Where(b => b.business_name == businessName).OrderByDescending(b => b.inspection_date).Take(20);

            int resultCount = query.Count();
           
            if(resultCount == 0)
            {
                searchResults.Message = "No records match the business name specified";
            }

            else
            {
                searchResults.Message = String.Format ("A total of {0} records have been found.",resultCount);
            }

            searchResults.Restaurants = await query.ToListAsync();

            return searchResults;
        }

        // GET api/<RestaurantController>/12/11/2020
        //[HttpGet("{inspectionDate}")]
        //public string Get(DateOnly inspectionDate)
       // {
        //    return "value";
       // }


        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
