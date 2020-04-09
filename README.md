
      @* @foreach (Creature creature in @Model)
      {
        <a href='@Url.Action("SelectParent1","Creatures", new { parent1Id = creature.CreatureId})'>
          <img src="../../img/creatureImages/bodies/body-blue.png" width="100" id="bodyImg">
          <img src="../../img/creatureImages/eyes/@Url.Content(creature.Eye.Image)" width="100" id="headImg">
          <img src="../../img/creatureImages/mouths/@Url.Content(creature.Mouth.Image)" width="100" id="headImg">
          <img src="../../img/creatureImages/tails/@Url.Content(creature.Tail.Image)" width="100" id="headImg">
          <img src="../../img/creatureImages/hair/@Url.Content(creature.Head.Image)" width="100" id="headImg">
        </a>
      }  *@
      @* @foreach (Creature creature in @Model)
      {
        <img src="../../img/creatureImages/bodies/body-blue.png" width="100" id="bodyImg">
        <p>@creature.Eye.Name</p> *@
        @* @foreach (var eye in ViewBag.Eye)
        {
          if (eye.EyeId == creature.EyeId)
          {
            <img src="../../img/creatureImages/eyes/@Url.Content(eye.Image)" width="100" id="eyeImg">
          }
        }
        @foreach (var mouth in ViewBag.Mouth)
        {
          if (mouth.MouthId == creature.MouthId)
          {
            <img src="../../img/creatureImages/mouths/@Url.Content(mouth.Image)" width="100" id="mouthImg">
          }
        }
        @foreach (var tail in ViewBag.Tail)
        {
          if (tail.TailId == creature.TailId)
          {
            <img src="../../img/creatureImages/tails/@Url.Content(tail.Image)" width="100" id="tailImg">
          }
        }
        @foreach (var head in ViewBag.Head)
        {
          if (head.HeadId == creature.HeadId)
          {
            <img src="../../img/creatureImages/hair/@Url.Content(head.Image)" width="100" id="headImg">
          }
        } 
      }*@



        // .Include(creature => creature.Eye)
        // .Include(creature => creature.Mouth)
        // .Include(creature => creature.Head)
        // .Include(creature => creature.Tail)
      // ViewBag.Eye = _db.Eyes.ToList();
      // ViewBag.Mouth = _db.Mouths.ToList();
      // ViewBag.Head = _db.Heads.ToList();
      // ViewBag.Tail = _db.Tails.ToList();




      public ActionResult SelectParent2(int parent2Id)
    {
      List<Creature> model = _db.Creatures.ToList();

      //Retrieve new baby from database and add parent2id
      Creature newBaby = _db.Creatures.LastOrDefault();
      newBaby.Parent2Id = parent2Id;
      _db.SaveChanges();
      
      //Retrieve parent1 features from database and add to the viewbag
      if (newBaby.Parent2Id == 1)
      {
        ViewBag.Parent1Body = "body-outline.png";
        ViewBag.Parent1Eye = "body-outline.png";
        ViewBag.Parent1Head = "body-outline.png";
        ViewBag.Parent1Mouth = "body-outline.png";
        ViewBag.Parent1Tail = "body-outline.png";
      }
      else
      {
        Creature parent1 = _db.Creatures
          .Include(creature => creature.Eye)
          .Include(creature => creature.Head)
          .Include(creature => creature.Mouth)
          .Include(creature => creature.Tail)
          .FirstOrDefault(creature => creature.CreatureId == newBaby.Parent1Id);
          ViewBag.Parent1Body = "body-outline.png";
          ViewBag.Parent1Eye = parent1.Eye.Image;
          ViewBag.Parent1Head = parent1.Head.Image;
          ViewBag.Parent1Mouth = parent1.Mouth.Image;
          ViewBag.Parent1Tail = parent1.Tail.Image;
      }

      //Retrieve parent2 features from database and add to the viewbag
      Creature parent2 = _db.Creatures
        .Include(creature => creature.Eye)
        .Include(creature => creature.Head)
        .Include(creature => creature.Mouth)
        .Include(creature => creature.Tail)
        .FirstOrDefault(creature => creature.CreatureId == parent2Id);
      ViewBag.Parent2Body = "body-yellow.png";
      ViewBag.Parent2Eye = parent2.Eye.Image;
      ViewBag.Parent2Head = parent2.Head.Image;
      ViewBag.Parent2Mouth = parent2.Mouth.Image;
      ViewBag.Parent2Tail = parent2.Tail.Image;
      return View("CreateChild", model);
    }




    [HttpPost]
    public ActionResult CreateChild(int parent1Id, int parent2Id)
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~PARENT 2 ID: ", parent2Id);
      Creature newBaby = _db.Creatures.Last();
      Creature parent1 = _db.Creatures.FirstOrDefault(parent => parent.CreatureId == newBaby.Parent1Id);
      // Creature parent2 = _db.Creatures.FirstOrDefault(parent => parent.CreatureId == newBaby.Parent2Id);
      // Console.WriteLine("PARENT 1 ID: ", parent1Id);
      // Get parent objects
      // Creature parent1 = _db.Creatures.Where(parent => parent.CreatureId == parent1Id).FirstOrDefault();
      Creature parent2 = _db.Creatures.Where(parent => parent.CreatureId == parent2Id).FirstOrDefault();

      // Console.WriteLine(parent1.CreatureId);
      // Console.WriteLine(parent2.CreatureId);

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