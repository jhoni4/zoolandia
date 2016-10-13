using System;
using Zoolandia;

namespace Zoolandia
{
   public class Animal : IAnimal
    {
        public string scientificName { get; set; }
        public string commonName { get; set; }
        public string url { get; set; }
        public string Habitat { get; set; }
        public bool Wings { get; set; }
        public bool IsSleeping { get; set; }
        public bool flying { get; set; }
        public bool Domestic { get; set; }
        public string sound { get; set; }
        public Genus genus { get; set; }
        public string feed { get; set; }
        public string Reproduce { get; set; }
        public string Sound { get; set; }
        public string Genus { get; set; }
        
        public virtual string genusName { get; set; }
        private string _nickname = null;
        public string nickname{
            get{
                return _nickname;
            }
            set{
                if (value != "")
                {
                    _nickname = value;
                }
            }
        }
        public int legs{ get; set; }
        private int _weighs;
        public int weighs{
            get{
                return _weighs;
            }
            set{
                if (value!=0)
                {
                    _weighs = value;
                }
            }
        }
        public virtual void sleepWay() {}
        public virtual void food() {}
        // public string legCount( int legs) {
        //     return ($"{nickname} Has 4 number of legs");
        // }
        public string legCount(int legs) {
            if(legs != 0) {
              return ($"Has {this.legs} number of legs");
            }
            else {
                return ($"It seems like it has no legs atall!");
            }
        }
        
    }
}    
