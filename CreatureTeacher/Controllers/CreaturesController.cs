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
      
    [HttpPost]
    public ActionResult CreateChild(int parent1Id, int parent2Id)
    {
      // Get parent objects
      Creature parent1 = _db.Creatures.Where(creature => creature.CreatureId == parent1Id).FirstOrDefault();
      Creature parent2 = _db.Creatures.Where(creature => creature.CreatureId == parent2Id).FirstOrDefault();

      // Create new codons for a new creature
      string eyeCodon = Creature.CodonScrambler(parent1.Eye.Codon, parent1.Eye.Dominance, parent2.Eye.Codon, parent2.Eye.Dominance);
      string mouthCodon = Creature.CodonScrambler(parent1.Mouth.Codon, parent1.Mouth.Dominance, parent2.Mouth.Codon, parent2.Mouth.Dominance);
      string headCodon = Creature.CodonScrambler(parent1.Head.Codon, parent1.Head.Dominance, parent2.Head.Codon, parent2.Head.Dominance);
      string tailCodon = Creature.CodonScrambler(parent1.Tail.Codon, parent1.Tail.Dominance, parent2.Tail.Codon, parent2.Tail.Dominance);

      // Get new feature objects based on codons
      Eye newEye = _db.Eyes.Where(eyes => eyes.Codon == eyeCodon).FirstOrDefault();
      Mouth newMouth = _db.Mouths.FirstOrDefault(mouths => mouths.Codon == mouthCodon);
      Head newHead = _db.Heads.FirstOrDefault(heads => heads.Codon == headCodon);
      Tail newTail = _db.Tails.FirstOrDefault(tails => tails.Codon == tailCodon);
      
      //Create Child with Creature Constructor
      Creature newCreature = new Creature(parent1Id, parent2Id, newEye, newMouth, newHead, newTail);
 
      return View(newCreature);
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