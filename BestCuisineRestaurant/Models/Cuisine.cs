using System.Collections.Generic;

namespace BestCuisineRestaurants.Models;

public class Cuisine
{
  public int CuisineId { get; set; }
  public string Cuisine { get; set; }
  public List<Restaurant> Restaurants { get; set; }
}