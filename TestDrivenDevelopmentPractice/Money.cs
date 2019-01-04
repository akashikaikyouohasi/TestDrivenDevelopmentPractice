using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentPractice
{
     public abstract class Money
    {
        protected int amount;

        public abstract Money Times(int multiplier);

        public override Boolean Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && this.GetType().Equals(money.GetType());
        }


        //Factory Method
        static public Dollar dollar(int amount)
        {
            return new Dollar(amount);
        }
        static public Franc franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
