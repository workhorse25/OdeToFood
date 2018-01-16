using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurantData : IRestaurantData
    //{
    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //            {
    //                new Restaurant{ID=1,Name = "Nelson's Pizza Place"},
    //                new Restaurant{ID=2,Name = "Lizzy's Pizza Place"},
    //                new Restaurant{ID=3,Name = "Sophie's Pizza Place"}

    //            };
    //    }
    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants;
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.ID == id);
    //    }

    //    public Restaurant Add(Restaurant newRestaurant)
    //    {
    //        newRestaurant.ID = _restaurants.Max(r => r.ID) + 1;
    //        _restaurants.Add(newRestaurant);
    //        return newRestaurant;
    //    }

    //    IEnumerable<Restaurant> IRestaurantData.GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Restaurant IRestaurantData.Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Restaurant IRestaurantData.Add(Restaurant newRestaurant)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Restaurant IRestaurantData.Update(Restaurant restaurant)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    List<Restaurant> _restaurants;
    ////}
}
