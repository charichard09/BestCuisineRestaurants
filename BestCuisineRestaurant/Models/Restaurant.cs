using System.Collections.Generic;

namespace BestCuisineRestaurants.Models;

public class Restaurant
{
  public int RestaurantId { get; set; }
  public string Name { get; set; }
  public string BestDish { get; set; }
  public int CuisineId { get; set; }
}