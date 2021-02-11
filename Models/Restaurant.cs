using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        [Required]
        public int? Rank { get;  }

        [Required]
        public string Name { get; set; }


        public string FavoriteDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        [RegularExpression("\\(\\d{3}\\)d{3}-\\d{4}")]
        public string Phone { get; set; }

        public string WebsiteURL { get; set; } = "Coming soon!";


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                
                Name = "Rancheritos",
                FavoriteDish = "Adobada Burrito",
                Address = "46 E 1230 N St, Provo, UT 84604",
                Phone = "(801)374-0822",
                WebsiteURL = "www.rancheritosprovoonline.com/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                
                Name = "Tucanos",
                FavoriteDish = "Picanha",
                Address = "545 E University Pkwy, Orem, UT 84097",
                Phone = "(801)224-4774",
                WebsiteURL = "www.tucanos.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                
                Name = "Sushi Ya",
                FavoriteDish = "Crystal Crunch Roll",
                Address = "1545 State St, Orem, UT 84097",
                Phone = "(801)225-7760",
                WebsiteURL = "www.facebook.com/sushiyaorem/"
            };

            Restaurant r4 = new Restaurant(4)
            {
                
                Name = "Texas Roadhouse",
                FavoriteDish = "Ribeye",
                Address = "1265 S. State Street, Orem, UT 84097",
                Phone = "(801)226-2742",
                WebsiteURL = "www.texasroadhouse.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                
                Name = "Leatherby's",
                FavoriteDish = "Allan's Black and Tan Sundae with a side of fries",
                Address = "304 East University Parkway Orem UT 84058",
                Phone = "(385)223-8140",
                WebsiteURL = "www.leatherbys.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }


    }
}
