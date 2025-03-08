using W6_assignment_template.CharacterTemplates;
using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Ghost : FlyingCharacter
    {
        public Ghost(string name, string type, int level, int hp, string treasure) : base(name, type, level, hp, treasure)
        {

        }

        public override void UniqueBehavior()
        {
            System.Console.WriteLine($"{Name} phases through the wall.");
        }

        public override void Fly()
        {
            System.Console.WriteLine($"{Name} flies rapidly through the air.");
        }
    }
}
