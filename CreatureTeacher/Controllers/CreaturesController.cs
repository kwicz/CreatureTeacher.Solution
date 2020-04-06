using Microsoft.AspNetCore.Mvc;
using CreatureTeacher.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreatureTeacher.Controllers
{
  public class CreaturesController : Controller
  {
    private readonly CreatureTeacherContext _db;

    public CreaturesController(CreatureTeacherContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Creature> model = _db.Creatures.Include(creat => creat.Head).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Creature creature)
    {
      _db.Creatures.Add(creature);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult CreateChild()
    {
      return View();
    }
    public ActionResult Edit(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
      return View(thisStudent);
      
    [HttpPost]
    public ActionResult CreateChild(int parent1Id, int parent2Id)
    {
      Creature parent1 = _db.Creatures.Where(creature => creature.CreatureId == parent1Id).FirstOrDefault();
      Creature parent2 = _db.Creatures.Where(creature => creature.CreatureId == parent2Id).FirstOrDefault();

      string EyeCodon = Creature.CodonScrambler(parent1.Eye.Codon, parent2.Eye.Codon);
      string MouthCodon = Creature.CodonScrambler(parent1.Mouth.Codon, parent2.Mouth.Codon);
      string HeadCodon = Creature.CodonScrambler(parent1.Head.Codon, parent2.Head.Codon);
      string TailCodon = Creature.CodonScrambler(parent1.Tail.Codon, parent2.Tail.Codon);
      // Eye newEye = Creature.ScrambledEyes(parent1.Eye, parent2.Eye);
      // Mouth newMouth = Creature.MixedUpMouths(parent1.Mouth, parent2.Mouth);
      // Head newHead = Creature.WedHeads(parent1.Head, parent2.Head);
      // Tail newTail = Creature.TailTwister(parent1.Tail, parent2.Tail);
      // Creature newCreature = new Creature();

      // Run scramble methods on parent objects, have new object IDs returned

      
      
      // so on and so forth

      // new babyCreature = new Creature (eyeId, )

      // int newEyeId = Creature.ScrambledEyes(parent1.EyeId, parent2.EyeId);
      // newEye = fetch Eye from database with EyeId
      // newCreature.Eye = newEye;
      // newCreature.EyeId = newEyeId;


      // int newMouthID = MixedUpMouths(parent1.Mouth, parent2.Mouth);
      // new Mouth = fetch Mouth from database with Mouth Id

      // Head newHead = WedHeads(parent1.Head, parent2.Head);
      // Tail newTail = TailTwister(parent1.Tail, parent2.Tail);
      return View();      
    }

    public ActionResult Details(int id)
    {
      Creature thisCreature = _db.Creatures.FirstOrDefault(creature => creature.CreatureId == id);
       return View(thisCreature); 
    }

    public ActionResult Delete(int id)
    {
      var thisCreature = _db.Creatures.FirstOrDefault(creature => creature.CreatureId == id);
      return View(thisCreature);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCreature = _db.Creatures.FirstOrDefault(creature => creature.CreatureId == id);
      _db.Creatures.Remove(thisCreature);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisCreature = _db.Creatures.FirstOrDefault(creature => creature.CreatureId == id);
      return View(thisCreature);
    }

    [HttpPost]
    public ActionResult Edit(Creature creature)
    {
      _db.Entry(creature).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}