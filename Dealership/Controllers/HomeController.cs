using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Car starterCar = new Car("Add first car to Car List", 0, 0);
      return View(starterCar);
    }

  }
}