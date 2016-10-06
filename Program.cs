using System;
using System.Text;
using Zoolandia.Species;

namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args) {
            // Animal firstAnimal = new Animal();
            // firstAnimal.name = args[0].Split(new Char[] { ' ' })[0];
           Cat mycat = new Cat() {
               Name= "kitty",
               SpeciesName="cateooo",
               Wings=false,
               Legs=4,
               Sound="miaoow"
           };
           mycat.inform();
        }
    }
}
