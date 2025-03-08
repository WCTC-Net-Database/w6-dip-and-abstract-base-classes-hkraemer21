using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W6_assignment_template.Interfaces;
using W6_assignment_template.Models;

namespace W6_assignment_template.CharacterTemplates
{
    public abstract class FlyingCharacter : CharacterBase, IFlyable, ILootable
    {
        public string Treasure { get; set; }

        public FlyingCharacter(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }

        public abstract void Fly();
        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }


}
