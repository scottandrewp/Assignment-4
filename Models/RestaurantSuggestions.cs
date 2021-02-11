using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public class RestaurantSuggestions
    {


        public string Name { get; set; } = "Anonymous";

        [Required]
        public string ResturantName { get; set; }

        
        public string FavoriteDish { get; set; } = "It's all Tasty";

        [RegularExpression("\\(\\d{3}\\)\\d{3}-\\d{4}", ErrorMessage ="Phone Number must be in (XXX)XXX-XXXX format!")]
        public string RestaurantPhone { get; set; }
    }
}
