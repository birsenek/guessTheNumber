using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator _randomNumberGenerator = new NumberGenerator();
            Calculations _isNumberRight = new Calculations();

            int randomNumber = _randomNumberGenerator.generateRandomNumber(1, 100);
            int userInput;
            int isNumberRight;

            Console.WriteLine("**Acerte o número!**");
            Console.WriteLine("==========================\n");
            Console.WriteLine("Esoclha um número entre 1 e 100");
            Console.WriteLine("==========================\n");


            //Loop de interação

            do
            {
                Console.Write("Digite seu palpite: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                isNumberRight = _isNumberRight.isNumberCorrect(userInput, randomNumber);


                Console.WriteLine($"Você escolheu o número {userInput}.\n");


                switch (isNumberRight)
                {
                    case 1:
                        Console.WriteLine("Está Quente!! Escolha um número maior!\n");
                        break;
                    case 2:
                        Console.WriteLine("Muito Frio!! Escolha um número maior!\n");
                        break;
                    case 3:
                        Console.WriteLine("Muito Quente!! Escolha um número menor!\n");
                        break;
                    case 4:
                        Console.WriteLine("Muito Frio!! Escolha um número menor!\n");
                        break;
                    case 5:
                        Console.WriteLine($"Parabéns!! Você acertou! O número sorteado foi {randomNumber}!");
                        break;
                }
            } while (userInput != randomNumber);
        }
    }
}
