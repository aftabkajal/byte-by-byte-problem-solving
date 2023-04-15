using System.Text;
namespace FizzBuzz.ProblemSolve
{
    internal class SnakeCases
    {
        //        Snake Case
        //Have the function SnakeCase(str) take the str parameter being passed and return it in proper snake case format where each word is lowercased and separated from adjacent words via an underscore.The string will only contain letters and some combination of delimiter punctuation characters separating each word.
        //        For example: if str is "BOB loves-coding" then your program should return the string bob_loves_coding.
        //Examples
        //Input: "cats AND*Dogs-are Awesome"
        //Output: cats_and_dogs_are_awesome
        //Input: "a b c d-e-f%g"
        //Output: a_b_c_d_e_f_g


        public static string SnakeCase(string str)
        {


            if (string.IsNullOrWhiteSpace(str)) return str;
            str = str.ToLower();
            var interSring = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 32 && str[i] <= 47)
                {
                    interSring.Append('_');
                }
                else
                {
                    interSring.Append(str[i]);
                }
            }

            var final = interSring.ToString();
            while (final.Contains("__"))
            {
                final.Replace("__", "_");
            }
            final = final.Trim('_');
            return final;


        }

        static void Main()
        {

            // keep this function call here
            Console.WriteLine(SnakeCase("\"a b c d-e-f%g\""));

        }
    }
}
