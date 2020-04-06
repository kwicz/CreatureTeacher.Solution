


using System;
using System.Collections.Generic;

namespace CreatureTeacher.Models
{
  public class Eye
  {
    public int EyeId { get; set; }
    public string Name { get; set; }
    public string Codon { get; set; }
    public string Image { get; set; }
    public virtual ICollection<Creature> Creatures { get; set; }
    public Eye()
    {
      this.Creatures = new HashSet<Creature>();
    }
  }
}