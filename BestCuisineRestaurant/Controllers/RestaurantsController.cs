using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BestCuisineRestaurants.Models;

namespace BestCuisineRestaurants.Controller
{
  public class RestaurantsController : Controller
  {
    private readonly BestCuisineRestaurantContext _db;

    public RestaurantsController(BestCuisineRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants
                                  .Include(restaurant => restaurant.Cuisine)
                                  .ToList();
      ViewBag.PageTitle = "View All Restaurants"
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Cuisine")
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      if (restaurant.Cuisine == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants
                                  .Include(restaurant => restaurant.Cuisine)
                                  .FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }

    public ActionResult Delete(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      _db.Restaurants.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }



  }
}