﻿using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController :Controller
    {
        [Route("")]
        public string Phone ()
        {
            return "+1 555 555 5555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
