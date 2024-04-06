using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pokemontest
{
    public class Pokemon : Player
    {
        public int CurrentHP { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public List<string> Moves { get; set; }

        public Pokemon(string name, int currentHP, int HP, int attack)
            : base(name)
        {
            CurrentHP = currentHP;
            this.HP = HP;
            Attack = attack;
        }

        public void TakeDamage(int damage)
        {
            CurrentHP -= damage;
            if (CurrentHP <= 0)
            {
                CurrentHP = 0;
                Console.WriteLine($"{Name} fainted!");
            }
            else
            {
                Console.WriteLine($"{Name} took {damage} damage!");
            }
        }

        public bool IsFainted()
        {
            return CurrentHP <= 0;
        }

        public void LearnMove(string move)
        {
            Moves.Add(move);
            Console.WriteLine($"{Name} learned {move}!");
        }
    }
}
