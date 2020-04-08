using Microsoft.AspNetCore.Mvc;
using CreatureTeacher.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
      List<Creature> model = _db.Creatures.ToList();
      ViewBag.Eye = _db.Eyes.ToList();
      ViewBag.Mouth = _db.Mouths.ToList();
      ViewBag.Head = _db.Heads.ToList();
      ViewBag.Tail = _db.Tails.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.EyeId = new SelectList(_db.Eyes, "EyeId", "Codon");
      ViewBag.MouthId = new SelectList(_db.Mouths, "MouthId", "Codon");
      ViewBag.HeadId = new SelectList(_db.Heads, "HeadId", "Codon");
      ViewBag.TailId = new SelectList(_db.Tails, "TailId", "Codon");
      return View();
    }

    [HttpPost]
    public ActionResult Create(string name, int eyeId, int mouthId, int headId, int tailId)
    {
      var thisEye = _db.Eyes.FirstOrDefault(eyes => eyes.EyeId == eyeId);
      var thisMouth = _db.Mouths.FirstOrDefault(mouths => mouths.MouthId == mouthId);
      var thisHead = _db.Heads.FirstOrDefault(head => head.HeadId == headId);
      var thisTail = _db.Tails.FirstOrDefault(tail => tail.TailId == tailId);
      Creature creature = new Creature();
      creature.Name = name; 
      creature.Eye = thisEye;
      creature.EyeId = eyeId;
      creature.Mouth = thisMouth;
      creature.MouthId = mouthId;
      creature.Head = thisHead;
      creature.HeadId = headId;
      creature.Tail = thisTail;
      creature.TailId = tailId;
      _db.Creatures.Add(creature);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult CreateChild()
    {
      // List<Creature> model = _db.Creatures.ToList();
      // ViewBag.CreatureId = new SelectList(_db.Creatures, "CreatureId", "Name");
      List<Creature> model = _db.Creatures.ToList();
      return View(model);
    }

    public ActionResult SelectParent1(string parent1)
    {
      string parent1Image = "../img/creatureImages/bodies/" + parent1 + ".png";
      return View("CreateChild", parent1Image);
    }
    public ActionResult SelectParent2(string parent2)
    {
      string parent2Image = "../img/creatureImages/bodies/" + parent2 + ".png";
      return View("CreateChild", parent2Image);
    }
      
    [HttpPost]
    public ActionResult CreateChild(int parent1Id, int parent2Id)
    {
      Console.WriteLine("PARENT 1 ID: ", parent1Id);
      // Get parent objects
      Creature parent1 = _db.Creatures.Where(parent => parent.CreatureId == parent1Id).FirstOrDefault();
      Creature parent2 = _db.Creatures.Where(parent => parent.CreatureId == parent2Id).FirstOrDefault();

      Console.WriteLine(parent1.CreatureId);
      Console.WriteLine(parent2.CreatureId);

      // // Create new codons for a new creature
      // int eyeId = Creature.CodonScrambler(parent1.Eye.EyeId, parent1.Eye.Dominance, parent2.Eye.EyeId, parent2.Eye.Dominance);
      // int mouthId = Creature.CodonScrambler(parent1.Mouth.MouthId, parent1.Mouth.Dominance, parent2.Mouth.MouthId, parent2.Mouth.Dominance);
      // int headId = Creature.CodonScrambler(parent1.Head.HeadId, parent1.Head.Dominance, parent2.Head.HeadId, parent2.Head.Dominance);
      // int tailId = Creature.CodonScrambler(parent1.Tail.TailId, parent1.Tail.Dominance, parent2.Tail.TailId, parent2.Tail.Dominance);

      // // Get new feature objects based on codons
      // var thisEye = _db.Eyes.FirstOrDefault(eyes => eyes.EyeId == eyeId);
      // var thisMouth = _db.Mouths.FirstOrDefault(mouths => mouths.MouthId == mouthId);
      // var thisHead = _db.Heads.FirstOrDefault(head => head.HeadId == headId);
      // var thisTail = _db.Tails.FirstOrDefault(tail => tail.TailId == tailId);

      // //Create Child with Creature Constructor
      // Creature creature = new Creature();
      // creature.Name = "New Creature";
      // creature.Eye = thisEye;
      // creature.EyeId = eyeId;
      // creature.Mouth = thisMouth;
      // creature.MouthId = mouthId;
      // creature.Head = thisHead;
      // creature.HeadId = headId;
      // creature.Tail = thisTail;
      // creature.TailId = tailId;
      // _db.Creatures.Add(creature);
      // _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // [Route("Creature/{id:int}")]
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