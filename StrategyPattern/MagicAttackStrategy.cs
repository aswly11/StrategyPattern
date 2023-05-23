using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MagicAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Magic Attack");
        }
    }
}
