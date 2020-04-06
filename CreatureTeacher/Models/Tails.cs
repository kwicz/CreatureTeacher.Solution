using System.Collections.Generic;

namespace CreatureTeacher.Models
{
  public class Tail 
  {
    public int TailId { get; set; }
    public string Codon { get; set; }
    public string Image { get; set; }
    public virtual ICollection<Creature> Creatures { get; set; }
    public Tail()
    {
      this.Creatures = new HashSet<Creature>();
    }
  }
}