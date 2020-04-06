using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CreatureTeacher.Models;

namespace CreatureTeacher.Controllers
{
  public class StephsController : Controller
  {
    public IActionResult Index()
    {
        return View("StephsTestView");
    }
  }
}
