using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {

    // [HttpGet("/places")] 
    // public ActionResult Index()
    // {
    //   List<Item> allplaces = Item.GetAll();
    //   return View(allplaces);
    // }

    // [HttpGet("/places/new")] 
    // public ActionResult New() // changed to New() from CreateForm
    // {
    //   return View();
    // }

    // [HttpPost("/places")] 
    // public ActionResult Create(string description)
    // {
    //   Item myItem = new Item(description);
    //   return RedirectToAction("Index");

    // }
    // [HttpPost("/places/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }
    // [HttpGet("/places/{id}")] // new syntax, curly braces in URL path in route decorate... route now utilizing dynamic routing
    // public ActionResult Show(int id)
    // {
    //   Item foundItem = Item.Find(id);
    //   return View(foundItem);
    // }

  }
}
