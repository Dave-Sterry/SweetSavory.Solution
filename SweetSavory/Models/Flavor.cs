using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SweetSavory.Models
{
  
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntries = new HashSet<FlavorTreat>();
    }
    
    public int FlavorId { get; set; }

    [DisplayName("Flavor Name")]
    public string FlavorName { get; set; }
    

    public virtual ICollection<FlavorTreat> JoinEntries { get; set; }
  }
}