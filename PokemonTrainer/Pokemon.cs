using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        //name, an el ement and health, all values are mandatory
        public string Name{ get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
