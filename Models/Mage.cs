using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity, ICastable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a terrifying growl.");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} moves aggressively.");
        }
        public void CastSpell(string spellName)
        {
            Console.WriteLine($"{Name} casts a {spellName} spell.");
        }
        public void CastSpell(string spellName, IEntity target)
        {
            Console.WriteLine($"{Name} casts a {spellName} spell at {target.Name}.");
        }
    }
}
