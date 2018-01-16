using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Services;
using OdeToFood.Models;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;


        [BindProperty]
        public Restaurant Restaurant { get; set; }


        public EditModel(IRestaurantData restaurant)
        {
            _restaurantData = restaurant;
        }
        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);
            if (Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { id = Restaurant.ID });
            }
            else
            {
                return Page();
            }
        }


    }
}