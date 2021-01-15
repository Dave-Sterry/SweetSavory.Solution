using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SweetSavory.Models
{

  public class Treat
  {
    public Treat()
    {
      this.JoinEntries = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    [DisplayName("Treat Name")]
    public string TreatName { get; set; }

    public ICollection<FlavorTreat> JoinEntries { get; }
  }
}