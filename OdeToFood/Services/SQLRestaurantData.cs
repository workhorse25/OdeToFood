using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;
using OdeToFood.Data;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Services
{
    public class SQLRestaurantData : IRestaurantData
    {
        private OdeToFoodDBContext _context;

        public SQLRestaurantData(OdeToFoodDBContext context)
        {
            _context = context;
        }

        Restaurant IRestaurantData.Add(Restaurant newRestaurant)
        {
            _context.Restaurants.Add(newRestaurant);
            _context.SaveChanges();
            return newRestaurant;
        }

        Restaurant IRestaurantData.Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.ID == id);

        }

        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        Restaurant IRestaurantData.Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
