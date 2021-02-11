using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public class RestaurantList
    {
        public static List<RestaurantSuggestions> restaurants = new List<RestaurantSuggestions>();

        public static IEnumerable<RestaurantSuggestions> Restaurants => restaurants;

        public static void AddRestaurant(RestaurantSuggestions restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
