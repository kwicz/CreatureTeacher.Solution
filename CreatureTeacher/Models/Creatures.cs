using System.Collections.Generic;
using System;


namespace CreatureTeacher.Models
{
  public class Creature
  {
    public int CreatureId {get;set;}
    public string Name {get;set;}

    public Date BirthDate {get;set}

    public int EyeId {get;set;}
    public virtual Eye Eye {get; set;}
    public int HeadId {get;set;}
    public virtual Head Head {get; set;}
    public int MouthId {get;set;}
    public virtual Mouth Mouth {get; set;}
    public int TailID {get;set;}
    public virtual Tail Tail {get; set;}
  }
}