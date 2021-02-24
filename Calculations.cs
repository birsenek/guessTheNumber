using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class Calculations
    {
        public int isNumberCorrect(int userInput, int randomNumber)
        {
            int result = 0;
            int lowerRange = randomNumber - 5;
            int higherRange = randomNumber + 5;

            if (userInput < randomNumber && userInput >= lowerRange)
            {
                result = 1;
            }
            else if (userInput < randomNumber && userInput < lowerRange)
            {
               result = 2; 
            }
            else if (userInput > randomNumber && userInput <= higherRange)
            {
                result = 3; 
            }
            else if (userInput > randomNumber && userInput > higherRange)
            {
                result = 4;
            }
            else if (userInput == randomNumber)
            {
                result = 5;
            }

            return result;
        }
    }
}
