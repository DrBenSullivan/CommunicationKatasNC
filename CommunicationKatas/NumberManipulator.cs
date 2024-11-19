using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationKatas
{
    public class NumberManipulator
    {
        public double SumMiddleRange(double[] numbers)
        {
            double lowestNumber = double.MaxValue;
            double highestNumber = double.MinValue;
            double result = 0;

            foreach (double number in numbers)
            {
                if (number < lowestNumber) lowestNumber = number;
                if (number > highestNumber) highestNumber = number;
            }

            foreach (double number in numbers)
            {
                if (number != lowestNumber && number != highestNumber) result += number;
            }

            return result;
        }
    }
}
