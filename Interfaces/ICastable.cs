using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_assignment_template.Interfaces
{
    internal interface ICastable
    {
        void CastSpell(string? spellName);
        void CastSpell(string? spellName, IEntity target);
    }
}
