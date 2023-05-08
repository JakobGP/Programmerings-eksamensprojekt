using System;
using System.Data;

namespace Programmerings_eksamensprojekt
{
    internal class Programmerings_eksamensprojekt
    {
        public string question = "";
        public string[] choices = { "" };
        public string correctAnswer = "";

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
            Console.WriteLine("Multiple Choice\n");
            Random tal = new Random();
            int spørgsmål = tal.Next(1, 7);

            string question = "";
            string[] choices = { };
            string correctAnswer = "";

            switch (spørgsmål)
            {
                case 1:
                    question = "Hvad er den hastighed, som lyset bevæger sig med?";
                    choices = new string[] { "a) 299,792,458 m/s", "b) 300,000,000 m/s", "c) 299,792 km/s", "d) 186,282 mi/s" };
                    correctAnswer = "a";
                    break;

                case 2:
                    question = "Hvad er enheden for elektrisk ladning?";
                    choices = new string[] { "a) Volt", "b) Watt", "c) Ampere", "d) Ohm" };
                    correctAnswer = "c";
                    break;

                case 3:
                    question = "Hvad er enheden for energi?";
                    choices = new string[] { "a) Joule", "b) Watt", "c) Ampere", "d) Volt" };
                    correctAnswer = "a";
                    break;

                case 4:
                    question = "Hvad er Ohms lov?";
                    choices = new string[] { "a) I = V/R", "b) V = IR", "c) P = IV", "d) F = ma" };
                    correctAnswer = "b";
                    break;

                case 5:
                    question = "Hvad er enheden for frekvens?";
                    choices = new string[] { "a) Hertz", "b) Newton", "c) Pascal", "d) Coulomb" };
                    correctAnswer = "a";
                    break;

                case 6:
                    question = "Hvad er den første lov i termodynamikken?";
                    choices = new string[] { "a) Energi kan hverken skabes eller tilintetgøres, kun overføres eller omdannes", "b) Jo større kraften er, desto større er accelerationen", "c) For hvert kraftpar, der virker på to legemer, er kræfterne lige store og modsat rettede", "d) To legemer påvirker hinanden med kræfter, der har samme størrelse og modsat retning" };
                    correctAnswer = "a";
                    break;
                default:
                    Console.WriteLine("Ugyldigt spørgsmål");
                    return;
            }

            Console.WriteLine(question);
            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }

            // Læs brugerens svar og valider det
            Console.Write("Svar: ");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Korrekt!");
            }
            else
            {
                Console.WriteLine("Forkert svar. Det korrekte svar er: " + correctAnswer);
            }

            string prøv_igen = "";
            Console.WriteLine("Vil du prøge igen? Y/N");
            prøv_igen = Console.ReadLine();
            if (prøv_igen.ToLower() == "y")
            {
                Console.Clear();
                MC();
            }

        }
    }
}
