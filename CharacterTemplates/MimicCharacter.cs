using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W6_assignment_template.Interfaces;
using W6_assignment_template.Models;

namespace W6_assignment_template.CharacterTemplates
{
    public abstract class MimicCharacter : CharacterBase, IMimic
    {
        public int Gold { get; set; }
        public MimicCharacter(string name, string type, int level, int hp, int gold)
            : base(name, type, level, hp)
        {
            Gold = gold;
        }
        public abstract void Devour(ICharacter target);
        public abstract void Touched(ICharacter toucher);
    }
}
