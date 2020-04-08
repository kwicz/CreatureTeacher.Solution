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

    public Creature()
    {

    }
    
    public static int CodonScrambler(int id1, string dominance1, int id2, string dominance2)
    {
      if (dominance1 == dominance2)
      {
        Random random = new Random();
        int result = random.Next(1, 2);
        if (result == 1)
        {
          return id1;
        }
        else
        {
          return id2;
        }
      }
      else if (dominance1 == "TRUE")
      {
        return id1;
      }
      else
      {
        return id2;
      }
    }
  }
}

