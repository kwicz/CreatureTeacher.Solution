using System.Collections.Generic;
using System;


namespace CreatureTeacher.Models
{
  public class Creature
  {
    public int CreatureId {get;set;}
    public int Parent1Id {get;set;}
    public int Parent2Id {get;set;}
    public string Name {get;set;}

    public DateTime BirthDate {get;set;}

    public int EyeId {get;set;}
    public Eye Eye {get; set;}
    public int HeadId {get;set;}
    public Head Head {get; set;}
    public int MouthId {get;set;}
    public Mouth Mouth {get; set;}
    public int TailId {get;set;}
    public Tail Tail {get; set;}

    public Creature(Eye eye, Head head, Mouth mouth, Tail tail, int parent1Id, int parent2Id)
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
      this.Parent1Id = parent1Id;
      this.Parent2Id = parent2Id;
    }
    
    public static string CodonScrambler(string codon1, string codon2)
    {
      return null;
    }
    // public static Eye ScrambledEyes(Eye eye1, Eye eye2)  
    // {
    //   return null;
    // }

    // public static Mouth MixedUpMouths(Mouth mouth1, Mouth mouth2)
    // {
    //   return null;
    // }

    // public static Head WedHeads(Head head1, Head head2)
    // {
    //   return null;
    // }
    
    // public static Tail TailTwister(Tail tail1, Tail tail2)
    // {
    //   return null;
    // }
    
  }
}



// TAT
// TAC 

// if(Parent1Eye.Dominance == true && Parent2Eye.Dominance == true )
// {
//   return Parent1Eye.Codon;
// }
// else if (Parent1Eye.Dominance == true && Parent2Eye.Dominance == false)
// { 
//   return Parent1Eye.Codon;
// }
// else if (Parent1Eye.Dominance == false && Parent2Eye.Dominance == true)
// {
//   return Parent2Eye.Codon; 
// }
// else if (Parent1Eye.Dominance == false && Parent2Eye.Dominance == false)
// {
//   return Parent2Eye.Codon;
// }



