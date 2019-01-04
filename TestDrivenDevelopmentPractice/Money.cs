using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentPractice
{
     public class Money
    {
        protected int amount;

        public override Boolean Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }

    }
}
