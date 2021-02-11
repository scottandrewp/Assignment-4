using Assignment_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("TopRestaurants")]
        public IActionResult Top5Restaurants()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add($"Rank: <b>{r.Rank}</b>  Restaurant Name: <b>{r.Name}</b>  Favorite Dish: <b>{r.FavoriteDish}</b> <br> Address: <b>{r.Address}</b>  Phone Number: <b>{r.Phone}</b> <br> Website: <a href=\"{r.WebsiteURL}\">{r.WebsiteURL}</a>");
            }
            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();

        }
        
       

        [HttpGet]
        public IActionResult Suggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestion(RestaurantSuggestions restaurant)
        {
            if(restaurant.FavoriteDish == null)
            {
                restaurant.FavoriteDish = "It's all tasty!";
            }
            if (ModelState.IsValid)// This ensures that invalid inputs don't get added to the list #Notcoveredinthevideos!
            {
                
                RestaurantList.AddRestaurant(restaurant);
                return View("Confirmation", restaurant); // passed in the model to let user know that the restaurant was added successfully
            }
            return View();
        }

        public IActionResult SuggestionList()
        {
            return View(Assignment_4.Models.RestaurantList.Restaurants);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
