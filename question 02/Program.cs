using System;

namespace question02
{
    class question02
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter a number");
                int number = int.Parse(Console.ReadLine());

                if (isEven(number))
                {
                    Console.WriteLine("even");
                }
                else
                {

                    Console.WriteLine("odd");
                }

            }
        }

        static bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }
}

