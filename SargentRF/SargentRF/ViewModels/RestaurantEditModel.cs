using SargentRF.Models;
using System.ComponentModel.DataAnnotations;

namespace SargentRF.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
