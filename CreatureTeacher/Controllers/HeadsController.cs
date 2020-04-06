using Microsoft.AspNetCore.Mvc;
using CreatureTeachewr.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreatureTeacher.Controllers
{
  public class HeadsController : Controller
  {
    private readonly CreatureTeacherContext _db;

    public HeadsController(CreatureTeacherContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Head> model = _db.Heads.Include(heads => heads.Head).ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Head thisHead = _db.Heads.FirstOrDefault(heads => heads.HeadId == id);
      return View(thisHead);
    }
  }
}