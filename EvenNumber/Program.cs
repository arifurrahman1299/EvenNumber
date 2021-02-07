using System;

namespace EvenNumber
{
    static class Program
    {

        static void Main()
        {

            for (int number = 2; number <= 50; number++)
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            Console.ReadLine();
        }
    }
}
