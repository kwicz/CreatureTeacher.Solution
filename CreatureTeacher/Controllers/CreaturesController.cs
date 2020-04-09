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

    public IActionResult Learn()
		{
			return View();
		}

    public ActionResult Create()
    {
      ViewBag.Eye = _db.Eyes.ToList();
      ViewBag.Mouth = _db.Mouths.ToList();
      ViewBag.Head = _db.Heads.ToList();
      ViewBag.Tail = _db.Tails.ToList(); 
      ViewBag.EyeId = new SelectList(_db.Eyes, "EyeId", "Codon");
      ViewBag.MouthId = new SelectList(_db.Mouths, "MouthId", "Codon");
      ViewBag.HeadId = new SelectList(_db.Heads, "HeadId", "Codon");
      ViewBag.TailId = new SelectList(_db.Tails, "TailId", "Codon");
      return View();
    }

    [HttpPost]
    public ActionResult Create(string name, int eyeId, int mouthId, int headId, int tailId)
    {
      var thisEye = _db.Eyes .FirstOrDefault(eyes => eyes.EyeId == eyeId);
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
      return RedirectToAction("Details", new{ id=creature.CreatureId});
    }

    public ActionResult CreateChild()
    {
      List<Creature> model = _db.Creatures.ToList();
      //REPLACE WITH BODY OUTLINE IMAGES
      ViewBag.Parent1Body = "body-outline.png";
      ViewBag.Parent1Eye = "body-outline.png";
      ViewBag.Parent1Head = "body-outline.png"; 
      ViewBag.Parent1Mouth = "body-outline.png";
      ViewBag.Parent1Tail = "body-outline.png";
      ViewBag.Parent2Body = "body-outline.png";
      ViewBag.Parent2Eye = "body-outline.png";
      ViewBag.Parent2Head = "body-outline.png";
      ViewBag.Parent2Mouth = "body-outline.png";
      ViewBag.Parent2Tail = "body-outline.png";
      return View(model);
    }

    public ActionResult SelectParent1(int parent1Id)
    {
      List<Creature> model = _db.Creatures.ToList();
      // Find parent 1 creature in database
      Creature parent1 = _db.Creatures
        .Include(creature => creature.Eye)
        .Include(creature => creature.Head)
        .Include(creature => creature.Mouth)
        .Include(creature => creature.Tail) 
        .FirstOrDefault(creature => creature.CreatureId == parent1Id);

      //Instantiate new baby with parent1 id and add it to the creatures database
      //Create if statement that new creature shouldn't be created if the last one isn't finished. If the last one isn't finished, alter it.
      // Creature lastCreature = _db.Creatures.LastOrDefault();
      Creature lastCreature = new Creature();
      if (lastCreature.Name != "New Baby") //IF Parent 1 is clicked FIRST
      {
        Creature newBaby = new Creature();
        newBaby.Name = "New Baby";
        newBaby.Parent1Id = parent1Id;
        _db.Creatures.Add(newBaby);
        _db.SaveChanges();

        ViewBag.Parent1Body = "body-green.png";
        ViewBag.Parent1Eye = parent1.Eye.Image;
        ViewBag.Parent1Head = parent1.Head.Image;
        ViewBag.Parent1Mouth = parent1.Mouth.Image;
        ViewBag.Parent1Tail = parent1.Tail.Image;

        ViewBag.Parent2Body = "body-outline.png";
        ViewBag.Parent2Eye = "body-outline.png";
        ViewBag.Parent2Head = "body-outline.png";
        ViewBag.Parent2Mouth = "body-outline.png";
        ViewBag.Parent2Tail = "body-outline.png";
        return View("CreateChild", model);
      } 
      else //IF Parent 1 is clicked SECOND
      {
        lastCreature.Parent1Id = parent1Id;
        ViewBag.Parent1Body = "body-green.png";
        ViewBag.Parent1Eye = parent1.Eye.Image;
        ViewBag.Parent1Head = parent1.Head.Image;
        ViewBag.Parent1Mouth = parent1.Mouth.Image;
        ViewBag.Parent1Tail = parent1.Tail.Image;

        Creature parent2 = _db.Creatures
          .Include(creature => creature.Eye)
          .Include(creature => creature.Head)
          .Include(creature => creature.Mouth)
          .Include(creature => creature.Tail)
          .FirstOrDefault(creature => creature.CreatureId == lastCreature.Parent2Id);  
        ViewBag.Parent2Body = "body-yellow.png";
        ViewBag.Parent2Eye = parent2.Eye.Image;
        ViewBag.Parent2Head = parent2.Head.Image;
        ViewBag.Parent2Mouth = parent2.Mouth.Image;
        ViewBag.Parent2Tail = parent2.Tail.Image;

        lastCreature.Name = "Born!";
        lastCreature.Eye.Image = parent2.Eye.Image;
        lastCreature.Head.Image = parent1.Head.Image;
        lastCreature.Mouth.Image = parent2.Mouth.Image;
        lastCreature.Tail.Image = parent1.Tail.Image;

        ViewBag.NewBabyId = lastCreature.CreatureId;

        _db.Entry(lastCreature).State = EntityState.Modified;
        _db.SaveChanges();
        return View("CreateChild", model);
      }
    }

    public ActionResult SelectParent2(int parent2Id)
    {
      List<Creature> model = _db.Creatures.ToList();
      // Find parent 2 creature in database
      Creature parent2 = _db.Creatures
        .Include(creature => creature.Eye)
        .Include(creature => creature.Head)
        .Include(creature => creature.Mouth)
        .Include(creature => creature.Tail) 
        .FirstOrDefault(creature => creature.CreatureId == parent2Id);

      //Instantiate new baby with parent2 id and add it to the creatures database
      //Create if statement that new creature shouldn't be created if the last one isn't finished. If the last one isn't finished, alter it.
      Creature lastCreature = _db.Creatures.LastOrDefault();

      if (lastCreature.Name != "New Baby") //IF Parent 1 is clicked FIRST
      {
        Creature newBaby = new Creature();
        newBaby.Parent2Id = parent2Id;
        newBaby.Name = "New Baby";
        _db.Creatures.Add(newBaby);
        _db.SaveChanges();

        ViewBag.Parent2Body = "body-yellow.png";
        ViewBag.Parent2Eye = parent2.Eye.Image;
        ViewBag.Parent2Head = parent2.Head.Image;
        ViewBag.Parent2Mouth = parent2.Mouth.Image;
        ViewBag.Parent2Tail = parent2.Tail.Image;

        ViewBag.Parent1Body = "body-outline.png";
        ViewBag.Parent1Eye = "body-outline.png";
        ViewBag.Parent1Head = "body-outline.png";
        ViewBag.Parent1Mouth = "body-outline.png";
        ViewBag.Parent1Tail = "body-outline.png";
        return View("CreateChild", model);
      } 
      else //IF Parent 2 is clicked SECOND
      {
        lastCreature.Parent2Id = parent2Id;

        Creature parent1 = _db.Creatures
          .Include(creature => creature.Eye)
          .Include(creature => creature.Head)
          .Include(creature => creature.Mouth)
          .Include(creature => creature.Tail)
          .FirstOrDefault(creature => creature.CreatureId == lastCreature.Parent1Id);

        ViewBag.Parent1Body = "body-green.png";
        ViewBag.Parent1Eye = parent1.Eye.Image;
        ViewBag.Parent1Head = parent1.Head.Image;
        ViewBag.Parent1Mouth = parent1.Mouth.Image;
        ViewBag.Parent1Tail = parent1.Tail.Image;

        ViewBag.Parent2Body = "body-yellow.png";
        ViewBag.Parent2Eye = parent2.Eye.Image;
        ViewBag.Parent2Head = parent2.Head.Image;
        ViewBag.Parent2Mouth = parent2.Mouth.Image;
        ViewBag.Parent2Tail = parent2.Tail.Image;


        lastCreature.Name = "Born!";
        lastCreature.Eye.Image = parent2.Eye.Image;
        lastCreature.Head.Image = parent1.Head.Image;
        lastCreature.Mouth.Image = parent2.Mouth.Image;
        lastCreature.Tail.Image = parent1.Tail.Image;

        ViewBag.lastCreatureId = lastCreature.CreatureId;

        _db.Entry(lastCreature).State = EntityState.Modified;
        _db.SaveChanges();
        return View("CreateChild", model);
      }
    }
  
    public ActionResult Details(int id)
    {
      Creature thisCreature = _db.Creatures
      .Include(creature => creature.Eye)
      .Include(creature => creature.Mouth)
      .Include(creature => creature.Head)
      .Include(creature => creature.Tail)
      .FirstOrDefault(creature => creature.CreatureId == id);
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
