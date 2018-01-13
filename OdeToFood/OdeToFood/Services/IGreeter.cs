﻿using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        object GetDailyGreeting();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter (IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public object GetDailyGreeting()
        {
            return _configuration["Greeting"];
        }
    }
}