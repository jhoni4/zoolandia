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
        public double weight { get; set; }
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
        // public sleep (bool sleeping){
        //   return sleeping ? "is now sleeping" : "is awake now";
        // }
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
        // public string food{ get; set; }
        // public string sleepWay{ get; set; }
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
        public string legCount(string nickname) {
            return ($"{nickname} Has 4 number of legs");
        }
        public void legCount(string nickname, int legs) {
            Console.WriteLine($"{nickname} Has {legs} number of legs");
        }
        
    }
}    
