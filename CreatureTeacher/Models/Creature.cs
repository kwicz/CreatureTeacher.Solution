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
    public int MouthId {get;set;}
    public Mouth Mouth {get; set;}    
    public int HeadId {get;set;}
    public Head Head {get; set;}
    public int TailId {get;set;}
    public Tail Tail {get; set;}

    public Creature (int parent1Id, int parent2Id, Eye eye, Mouth mouth,  Head head, Tail tail)
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
    
    public static string CodonScrambler(string codon1, string dominance1, string codon2, string dominance2)
    {
      if (dominance1 == dominance2)
      {
        Random random = new Random();
        int result = random.Next(1, 2);
        if (result == 1)
        {
          return codon1;
        }
        else
        {
          return codon2;
        }
      }
      else if (dominance1 == "TRUE")
      {
        return codon1;
      }
      else
      {
        return codon2;
      }
    }
  }
}

