// Write a program that will generate a random password that is 5 characters long, consisting of uppercase letters (look up how to convert from an integer to a character, and append a character to a string).

using System;
using System.Text;                              // Needs system.Text for random

namespace PracticeProblem9
{
    class Program
    {
        static void Main(string[] args)         // Solution found via https://www.educative.io/edpresso/how-to-generate-a-random-string-in-c-sharp
        {
            int length = 5;                             // Sets the length of the string to an integer, in this case 5. 
      
      StringBuilder str_build = new StringBuilder();    // build a new stringbuilder method
      Random random = new Random();                     // Sets up a new rng generator

      char password;                                      // set initial character

      for (int i = 0; i < length; i++)                  
      {
        double flt = random.NextDouble();                       // Calls a random float that is between 0.0 and 1.0
        int shift = Convert.ToInt32(Math.Floor(25 * flt));       // Multiply the float by 25 and take the floor of the result, giving in integer between 1 and 25. 
        password = Convert.ToChar(shift + 65);                    // Add shift integer to 65, which is the ASCII value of the character A. This will give us an integer between 65 and 90, which are the ASCII values for capital letters. 
        str_build.Append(password);  
      }  
      Console.WriteLine($"Your 5 letter password is {str_build.ToString()}");
      Console.ReadLine();
    }
}}