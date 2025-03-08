using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W6_assignment_template.CharacterTemplates;
using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    internal class Mimic : MimicCharacter
    {
        public Mimic(string name, string type, int level, int hp, int gold) : base(name, type, level, hp, gold)
        {

        }

        public override void Devour(ICharacter target)
        {
            Console.WriteLine($"Mimic opens wide and devours {target.Name} whole.");
        }

        public override void Touched(ICharacter toucher)
        {
            Console.WriteLine($"{toucher.Name} attempts to open {Name}, which reveals itself to be a Mimic by opening its giant maw and baring " +
                $"its razor sharp teeth.");
            Name = "Mimic";
        }

        public override void UniqueBehavior()
        {
            Name = "Treasure Chest";
            Console.WriteLine($"{Name} sits temptingly in the corner.");
        }
    }
}
