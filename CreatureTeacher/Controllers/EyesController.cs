using Microsoft.AspNetCore.Mvc;
using CreatureTeacher.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreatureTeacher.Controllers
{
  public class EyesController : Controller
  {
    private readonly CreatureTeacherContext _db;

    public EyesController(CreatureTeacherContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Eye> model = _db.Eyes.Include(eyes => eyes.Eye).ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Eye thisEye = _db.Eyes.FirstOrDefault(eyes => eyes.EyeId == id);
      return View(thisEye);
    }
  }
}
