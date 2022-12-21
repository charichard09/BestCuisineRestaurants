

namespace BestCuisineRestaurants.Models;

public class BestCuisineRestaurantContext : DbContext
{
  public DbSet<Cuisine> Cuisines { get; set; }
  public DbSet<Restaurant> Restaurants { get; set; }

  public BestCuisineRestaurantContext(DbContextOptions options) : base(options) { }
}