﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SargentRF.Models;
using SargentRF.Data;
using Microsoft.EntityFrameworkCore;

namespace SargentRF.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private SargentRFDbContext _context;

        public SqlRestaurantData(SargentRFDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = 
                EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
