using System.Collections.Generic;
using Zoolandia;

namespace Zoolandia
{
  public class Zoo
  {
    private string _name = "Zoolandia";
    
    public List<Habitat> habitats = new List<Habitat>();
    
    public string process ()
    {
      return "The amazing " + _name;
    }
  }
}