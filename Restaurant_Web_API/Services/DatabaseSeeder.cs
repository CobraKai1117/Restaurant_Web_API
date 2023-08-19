using Microsoft.EntityFrameworkCore;
using Restaurant_Web_API.Database_Class;
using Restaurant_Web_API.Models;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace Restaurant_Web_API.Services
{
    public class DatabaseSeeder
    {
        private RestaurantContext _context;

        public DatabaseSeeder(RestaurantContext context)
        {
            _context = context;
        }

        public void Initialize(IServiceProvider serviceProvider)
        {
            if (_context.RestaurantSet.Any())
            {
                return;
            }

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim
            };

            using (var reader = new StreamReader("C:\\Users\\Owner\\OneDrive\\Desktop\\Data_Set_for_Web_API_project\\Restaurant_Scores_CondensedDB.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<RestaurantMap>();
                csv.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("");

                var records = csv.GetRecords<Restaurant>().ToList();

                foreach (var record in records)
                {
                    _context.Add(record);
                }

                _context.SaveChanges();
            }
        }
    }

    public sealed class RestaurantMap : ClassMap<Restaurant>
    {
        public RestaurantMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.RestaurantId).Ignore();
           // Map(m => m.business_id).Name("business_id");
            Map(m => m.business_name).Name("business_name");
            Map(m => m.business_address).Name("business_address");
            Map(m => m.business_city).Name("business_city");
            Map(m => m.business_state).Name("business_state");
            Map(m => m.business_postal_code).Name("business_postal_code");
            Map(m => m.inspection_id).Name("inspection_id");
            Map(m => m.inspection_date).Name("inspection_date");
            Map(m => m.inspection_score).Name("inspection_score");
            Map(m => m.inspection_type).Name("inspection_type");
            Map(m => m.violation_id).Name("violation_id");
            Map(m => m.violation_description).Name("violation_description");
            Map(m => m.risk_category).Name("risk_category");

        }
    }
}
