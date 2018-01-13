using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                { 1,"Name" }
            }
        }
        List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
