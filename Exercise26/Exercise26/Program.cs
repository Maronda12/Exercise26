using System;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {


            Console.WriteLine("Please enter some text.");

            string text = Console.ReadLine();

            //Vowels uppercase/lowercase
            string vowels = "aeiouAEIOU";
            int total = 0;

            //Checks for vowels and prints out
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i] + ""))
                {
                    total++;
                }
            }

            Console.WriteLine("Total vowels ");
            Console.WriteLine("=============");
            Console.WriteLine(total);


                goOn = GetContinue(); // Calls Continue Method
            }
        }

        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                
                return GetContinue();
            }
        }
    }
}
