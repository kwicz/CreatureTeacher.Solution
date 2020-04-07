using System.Collections.Generic;

namespace CreatureTeacher.Models
{
  public class Codon 
  {
    public int CodonId { get; set; }
    public virtual ICollection<NucleicAcid> NucleicAcids { get; set;}

    public Codon()
    {
      this.NucleicAcids = new List<NucleicAcid>();
    }
  }
}