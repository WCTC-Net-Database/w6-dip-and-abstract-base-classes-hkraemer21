using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace W6_assignment_template.Interfaces
{
    public interface IMimic
    {
        void Devour(ICharacter target);
        void Touched(ICharacter toucher);
        void UniqueBehavior();
    }
}
