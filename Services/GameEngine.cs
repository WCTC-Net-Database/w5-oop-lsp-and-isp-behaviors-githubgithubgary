using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _mage;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _mage = mage;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _mage.Name = "Merlin";

            _character.Move();
            _character.Attack(_goblin);
            ((ISwimmable)_character).Swim();
            Console.Write("\r\n");

            _goblin.Move();
            _goblin.Attack(_character);
            ((ISwimmable)_goblin).Swim();
            Console.Write("\r\n");

            _ghost.Move();
            _ghost.Attack(_character);
            ((Ghost) _ghost).Fly();
            Console.Write("\r\n");

            //  Another option that just doing the cast as a Ghost
            //if (_ghost is IFlyable)
            //{
            //    ((IFlyable)_ghost).Fly();
            //}

            _mage.Move();
            _mage.Attack(_ghost);
            ((ICastable)_mage).CastSpell("Freeze");
            ((ICastable)_mage).CastSpell("Freeze", _ghost);
        }
    }
}
