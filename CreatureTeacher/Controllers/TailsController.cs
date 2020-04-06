using Microsoft.AspNetCore.Mvc;
using CreatureTeachewr.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreatureTeacher.Controllers
{
  public class TailsController : Controller
  {
    private readonly CreatureTeacherContext _db;

    public TailsController(CreatureTeacherContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Tail> model = _db.Tails.Include(tails => tails.Tail).ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Tail thisTail = _db.Tails.FirstOrDefault(tails => tails.TailId == id);
      return View(thisTail);
    }
  }
}