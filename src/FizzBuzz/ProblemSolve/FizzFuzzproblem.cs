//FizFuzz: Output numbers from 1 to x. if the number is divisible by 3, replace it with "Fizz". if it is divisible by 5, replace it with Buzz. 
//if the number is divisible by 3 and 5 then replace with FizzBuzz.
//https://youtu.be/c0OMPDLef08

using System.Linq;
using System.Text;

namespace FizzBuzz.ProblemSolve
{
    public class FizzFuzzproblem
    {
        public static string FizzBuzz(int number)
        {
            var fizzBuzz = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                { 
                    fizzBuzz.AppendLine("FizzBuzz"); 
                }
                else if (i % 3 == 0 )
                {
                    fizzBuzz.AppendLine("Fizz");
                }
                else if ( i % 5 == 0)
                {
                    fizzBuzz.AppendLine("Buzz");
                }

                fizzBuzz.AppendLine(i.ToString());

            }
            Console.WriteLine(fizzBuzz.ToString());
            return fizzBuzz.ToString();
        }
    }
}
