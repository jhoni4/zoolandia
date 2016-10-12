using System.Collections.Generic;
using Zoolandia;

namespace Zoolandia
{
  public class Habitat
  {
    public string currentLocation { get; set; }
    public List<Animal> inhabitants = new List<Animal>();
    public List<Habitat> habitats = new List<Habitat>();
    
    public string homeName { get; set;}


  }
}