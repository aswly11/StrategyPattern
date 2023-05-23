using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Warrior:Player
    {
        public Warrior(IAttackStrategy attackStrategy)
        {
            base.AttackStrategy = attackStrategy;
        }
    }
}
