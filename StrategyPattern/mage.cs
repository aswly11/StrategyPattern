using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class mage:Player
    {
        public mage(IAttackStrategy attackStrategy)
        {
            base.AttackStrategy = attackStrategy;
        }

    }
}
