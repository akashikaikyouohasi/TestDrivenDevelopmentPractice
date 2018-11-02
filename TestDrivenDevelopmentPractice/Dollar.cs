using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentPractice
{
    public class Dollar
    {
        /*
         * This class deal with dollas.
         * Value Object Pattern >> Instance value configured by Constructor must not change. Need equals().
         */

        public int amount;

        //Constructor that takes one argument
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        // Perfome multiplication
        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
