using System;
using System.Linq;

namespace DelegatesProblem
{
    public delegate void Validate(string s);
    public class ConsoleReader
    {
        public static void onWord(string s)
        {
            Console.WriteLine("This is onWord delegate " +s);
        }
        public static void onNumber(string s)
        {
            Console.WriteLine("This is onNumber delegate " +s);
        }
        public static void onJunk(string s)
        {
            Console.WriteLine("This is onJunk delegate " +s);
        }

        static void Main(string[] args)
        {
            Validate obj1 = new Validate(onWord);
            Validate obj2 = new Validate(onNumber);
            Validate obj3 = new Validate(onJunk);
            while (true)
            {
                Console.WriteLine("Enter the value...or type quit for exit");
                string input = Console.ReadLine();

                if(input == "quit")
                    break;

                   else if (input.All(Char.IsLetter))
                       obj1(input);

                    else if (input.All(Char.IsDigit))
                        obj2(input);

                    else if (input.All(Char.IsLetterOrDigit))
                        obj1(input);

                    else obj3(input);
                
            }
        }
    }
}
