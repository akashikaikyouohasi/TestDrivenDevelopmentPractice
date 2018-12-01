using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentPractice
{
    public class Franc
    {
        /*
         * This class deal with dollas.
         * Value Object Pattern >> Instance value configured by Constructor must not change. Need equals().
         */

        private int amount;

        //Constructor that takes one argument
        public Franc(int amount)
        {
            this.amount = amount;
        }

        // Perfome multiplication
        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        //
        public override Boolean Equals(Object obj)
        {
            Franc franc = (Franc)obj;
            return amount == franc.amount;
        }
    }
}
