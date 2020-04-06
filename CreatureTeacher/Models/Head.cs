using System.Collections.Generic;

namespace CreatureTeacher.Models
{
  public class Head 
  {
    public int HeadId { get; set; }
    public string Name { get; set; }
    public string Codon { get; set; }
    public string Image { get; set; }
    public virtual ICollection<Creature> Creatures { get; set; }
    public Head()
    {
      this.Creatures = new HashSet<Creature>();
    }
  }
}