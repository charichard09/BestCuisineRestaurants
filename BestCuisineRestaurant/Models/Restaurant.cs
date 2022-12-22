using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BestCuisineRestaurants.Models;

public class Restaurant
{
  public int RestaurantId { get; set; }
  public string Name { get; set; }
  public string BestDish { get; set; }
  [Required]
  public int CuisineId { get; set; }
  public Cuisine Cuisine  { get; set; }
}