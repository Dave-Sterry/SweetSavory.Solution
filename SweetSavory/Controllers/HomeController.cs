
using SweetSavory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace SweetSavory.Controllers
{
  public class HomeController : Controller
  {

    private readonly SweetSavoryContext _db;
    public HomeController(SweetSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<object, object> model = new Dictionary<object, object>();
      List<Flavor> flavors = _db.Flavors.ToList();
      List<Treat> treats = _db.Treats.ToList();
      model.Add("flavors", flavors);
      model.Add("treats", treats);
      return View(model);
    }
  }

}