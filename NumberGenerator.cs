using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    public class NumberGenerator
    {
   
        public int generateRandomNumber(int minValue, int maxValue)
        {
            Random rnd = new Random();
            int result = rnd.Next(minValue, maxValue);
            return result;
        }
    }
}
