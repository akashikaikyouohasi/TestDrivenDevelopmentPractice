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
         */

        public int amount;

        //Constructor that takes one argument
        public Dollar(int amount)
        {

        }

        // Perfome multiplication
        public void Times(int multiplier)
        {
            amount = 5 * 2;
        }
    }
}
