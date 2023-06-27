using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            int num = 0;
        // Create a do-while loop and use the template below:
            do
            {
                Console.WriteLine(num);
                num++;   // Increment num by 1
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100);

            while (num < 200)
            {
                
                num++;
                numbers.Add(num);

            }  
            
            Console.WriteLine("Increase:");

                foreach (int number in numbers)  // Create a foreach loop using the collection - numbers
                                                 //In the scope of the foreach loop, print each number in numbers
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("");
                Console.WriteLine("Decrease:");
                
                    for(int i = 199; i <= numbers.Count && i >= 0; i--)
                { 

                    Console.WriteLine(numbers[i]);
                    
                }


                // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

                //start for loop here
                // place numbers[i] inside of the Console.WriteLine() method              //------------End of exercise
        }
    }
}
