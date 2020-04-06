using Microsoft.AspNetCore.Mvc;
using CreatureTeachewr.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreatureTeacher.Controllers
{
  public class MouthsController : Controller
  {
    private readonly CreatureTeacherContext _db;

    public MouthsController(CreatureTeacherContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Mouth> model = _db.Mouths.Include(mouths => mouths.Mouth).ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Mouth thisMouth = _db.Mouths.FirstOrDefault(mouths => mouths.MouthId == id);
      return View(thisMouth);
    }
  }
}