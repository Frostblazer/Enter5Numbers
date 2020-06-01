using System;
using System.Collections.Generic;

namespace Enter5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNumbers = new List<int>();

            Console.WriteLine("Enter 5 numbers seperated by a comma.");
            Console.Write("Enter a number: ");
            var userInput = Console.ReadLine();
            var number = Int32.Parse(userInput);
            userNumbers.Add(number);
            int i = 1;

            while (i < 5)
            {            
                Console.Write("Enter another number: ");

                var nextInput = Console.ReadLine();

                var nextNumber = Int32.Parse(nextInput);

                if (!userNumbers.Contains(nextNumber))
                {
                    userNumbers.Add(nextNumber);

                    i++;
                }
                else
                {
                    break;
                }
        
            }
            
            foreach(int index in userNumbers)
            {
                Console.WriteLine(index);
            }

        }
    }
}
