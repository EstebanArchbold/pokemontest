using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemontest
{
    public class Move
    {
        // Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }

        // Constructor
        public Move(string name, string type, int power)
        {
            Name = name;
            Type = type;
            Power = power;
        }

        // Method to use the move on a target Pokémon
        public void Use(Pokemon attacker, Pokemon target)
        {
        }
    }
}
