using System.Windows.Input;
using W6_assignment_template.CharacterTemplates;
using W6_assignment_template.Data;
using W6_assignment_template.Models;

namespace W6_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IContext _context;
        private readonly Player _player;
        private readonly Goblin _goblin;
        private readonly FlyingCharacter _ghost;
        private readonly MimicCharacter _mimic;

        public GameEngine(IContext context)
        {
            _context = context;
            _player = context.Characters.OfType<Player>().FirstOrDefault();
            _goblin = _context.Characters.OfType<Goblin>().FirstOrDefault();
            _ghost = _context.Characters.OfType<FlyingCharacter>().FirstOrDefault();
            _mimic = _context.Characters.OfType<MimicCharacter>().FirstOrDefault();
        }

        public void Run()
        {
            if (_player == null || _goblin == null || _ghost == null || _mimic == null)
            {
                Console.WriteLine("Failed to initialize game characters.");
                return;
            }

            Console.WriteLine($"Player Gold: {_player.Gold}");

            _mimic.UniqueBehavior();
            _goblin.Move();
            _ghost.Fly();
            _goblin.UniqueBehavior();
            _mimic.Touched(_goblin);
            _mimic.Devour(_goblin);
            _ghost.UniqueBehavior();
            _mimic.UniqueBehavior();
            _player.Move();
            _player.UniqueBehavior();
            _mimic.Touched(_player);
            _player.Attack(_mimic);

            Console.WriteLine($"Player Gold: {_player.Gold}");



            // Example CRUD operations for Goblin
            //var newGoblin = new Goblin("New Goblin", "Goblin", 1, 30, "None");
            //_context.AddCharacter(newGoblin);

            //newGoblin.Level = 2;
            //_context.UpdateCharacter(newGoblin);

            //_context.DeleteCharacter("New Goblin");
        }
    }
}
