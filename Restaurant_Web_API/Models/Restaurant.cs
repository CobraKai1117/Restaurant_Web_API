using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Web_API.Models
{
    public class Restaurant
    {
       // [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int RestaurantId { get; set; }

        public Guid RestaurantId { get; set; }
        public string business_name { get; set; }

        public string business_address { get; set; }

        public string business_city { get; set; }

        public string business_state { get; set;  }

        public string? business_postal_code { get; set; }

        public string inspection_id { get; set;}

        public DateTime inspection_date { get; set; }

        public int? inspection_score { get; set; }

        public string inspection_type { get; set; }

        public string? violation_id { get; set; }

        public string? violation_description { get; set; }

        public string? risk_category { get; set; }







        



    }
}
