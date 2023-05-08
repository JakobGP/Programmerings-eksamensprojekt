using System;
using System.Collections.Generic;
namespace Programmerings_eksamensprojekt
{
    internal class Programmerings_eksamensprojekt
    {
        public string question = "";
        public string[] choices = { "" };
        public string correctAnswer = "";
        public static int scorer = 0;

        static void Main(string[] args)
        {
            string type_træning = "";

            Console.WriteLine("Velkommen til fysik træneren");
            Console.WriteLine("Hvilken type opgaver vil du lave? Træning eller MC (multiple choice)");
            type_træning = Console.ReadLine();

            if (type_træning.ToLower() == "mc")
            {
                MC();
            }
        }

        static void MC()
        {
            Console.WriteLine("Multiple Choice");
            Random tal = new Random();
            int spørgsmål = tal.Next(1, 7);
            switch (spørgsmål)
            {
                case 1:
                    //førse spørgsmål
                    break;

                case 2:
                    // andet spørgsmål
                    break;

                case 3:
                    break;

            }
        }

    }
}