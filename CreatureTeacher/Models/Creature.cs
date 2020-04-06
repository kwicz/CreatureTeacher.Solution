using System.Collections.Generic;
using System;


namespace CreatureTeacher.Models
{
  public class Creature
  {
    public int CreatureId {get;set;}
    public Creature Parent1 {get;set;}
    public Creature Parent2 {get;set;}
    public string Name {get;set;}

    public DateTime BirthDate {get;set;}

    public int EyeId {get;set;}
    public virtual Eye Eye {get; set;}
    public int HeadId {get;set;}
    public virtual Head Head {get; set;}
    public int MouthId {get;set;}
    public virtual Mouth Mouth {get; set;}
    public int TailId {get;set;}
    public virtual Tail Tail {get; set;}

    public Creature(Eye eye, Head head, Mouth mouth, Tail tail, Creature parent1, Creature parent2)
    {
      this.Name = "New Creature";
      this.BirthDate = DateTime.Now;
      this.Eye = eye;
      this.EyeId = eye.EyeId;
      this.Head = head;
      this.HeadId = head.HeadId;
      this.Mouth = mouth;
      this.MouthId = mouth.MouthId;
      this.Tail = tail;
      this.TailId = tail.TailId;
      this.Parent1 = parent1;
      this.Parent2 = parent2;
     }


    public Creature BreedNew(Creature parent1, Creature parent2)
    {
      Eye newEye = ScrambledEyes(parent1.Eye, parent2.Eye);
      Mouth newMouth = MixedUpMouths(parent1.Mouth, parent2.Mouth);
      Head newHead = WedHeads(parent1.Head, parent2.Head);
      Tail newTail = TailTwister(parent1.Tail, parent2.Tail);
      return new Creature(newEye, newHead, newMouth, newTail, parent1, parent2);
    }
    
    public Eye ScrambledEyes(Eye eye1, Eye eye2)
    {
      return Eye;
    }

    public Mouth MixedUpMouths(Mouth mouth1, Mouth mouth2)
    {
      return Mouth;
    }

    public Head WedHeads(Head head1, Head head2)
    {
      return Head;
    }
    
    public Tail TailTwister(Tail tail1, Tail tail2)
    {
      return Tail;
    }
    
  }
}



TAT
TAC 

if(Parent1Eye.Dominance == true && Parent2Eye.Dominance == true )
{
  return Parent1Eye.Codon;
}
else if (Parent1Eye.Dominance == true && Parent2Eye.Dominance == false)
{ 
  return Parent1Eye.Codon;
}
else if (Parent1Eye.Dominance == false && Parent2Eye.Dominance == true)
{
  return Parent2Eye.Codon; 
}
else if (Parent1Eye.Dominance == false && Parent2Eye.Dominance == false)
{
  return Parent2Eye.Codon;
}



