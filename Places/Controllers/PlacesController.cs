using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")] 
    public ActionResult Index()
    {
      List<Place> allplaces = Place.GetAll();
      return View(allplaces);
    }

    [HttpGet("/places/new")] 
    public ActionResult New() // changed to New() from CreateForm
    {
      return View();
    }

    [HttpPost("/places")] 
    public ActionResult Create(string placeName, string company, string lengthOfStay, string dateOfVisit, string journalEntry, string favFood)
    {
      Place myPlace = new Place(placeName, company, lengthOfStay, dateOfVisit, journalEntry, favFood);
      return RedirectToAction("Index");

    }
    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
    [HttpGet("/places/{id}")] // new syntax, curly braces in URL path in route decorate... route now utilizing dynamic routing
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

  }
}
