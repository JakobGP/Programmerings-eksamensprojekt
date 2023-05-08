using System;
using System.Data;
using System.Linq.Expressions;

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
            string? typeTræning = "";
       
            Console.WriteLine("Velkommen til fysik træneren");
            Console.WriteLine("Hvilken type opgaver vil du lave? Træning eller MC (multiple choice)");
            typeTræning = Console.ReadLine();

            if (typeTræning?.ToLower() == "mc")
            {
                MC();
            }
        }
        
        static void MC()
        {
            Console.Clear();
            Console.WriteLine("Multiple Choice\n");
            string kattegori = "";

            Console.WriteLine("Vælg emne: \na) Termodynaik\nb) Bevæglese");
            kattegori = Console.ReadLine();
            if (kattegori.ToLower() == "termodynamik" || kattegori.ToLower() == "a")
            {
                termodynamik();
            }
            else if (kattegori.ToLower() == "bevægelse" || kattegori.ToLower() == "b")
            {
                bevægelse();
            }
            else
            {
                Console.WriteLine("Du har ikke valgt en rigtig kattegori, prøv igen");
                MC();
            }
            
        }

        static void point()
        {

        }
        static void termodynamik()
        {
            Console.Clear();
            List<int> brugteTal = new List<int>();
            int spørgsmål = 0;
            int antalSpg = 10;
            for (int i = 0; i < antalSpg + 1; i++)
            {
                bool h = false;

                while (!h)
                {
                    bool erBrugt = false;
                    Random tal = new Random();
                    spørgsmål = tal.Next(1, antalSpg + 1);
                    for (int j = 0; j < brugteTal.Count; j++)
                    {
                        if (brugteTal[j] == spørgsmål)
                        {
                            erBrugt = true;
                        }
                    }
                    if (!erBrugt)
                    {
                        h = true;
                        brugteTal.Add(spørgsmål);
                    }
                    else if (brugteTal.Count == antalSpg)
                    {
                        string? prøvIgen = "";
                        Console.WriteLine("Du fik " + scorer + "/" + antalSpg + " rigtige. Vil du prøge igen? Y/N");
                        prøvIgen = Console.ReadLine();
                        if (string.IsNullOrEmpty(prøvIgen))
                        {
                            return;
                        }
                        if (prøvIgen.ToLower() == "y")
                        {
                            Console.Clear();
                            MC();
                        }
                        return;
                    }
                }

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

                    case 7:
                        question = "Hvad er enheden for tryk?";
                        choices = new string[] { "a) Pascal", "b) Newton", "c) Joule", "d) Watt" };
                        correctAnswer = "a";
                        break;

                    case 8:
                        question = "Hvad er den hastighed, som et legeme nærmer sig jorden med, når det frit falder?";
                        choices = new string[] { "a) 9.81 m/s", "b) 10 m/s", "c) 100 m/s", "d) 1,000 m/s" };
                        correctAnswer = "a";
                        break;

                    case 9:
                        question = "Hvad er enheden for magnetisk flux?";
                        choices = new string[] { "a) Weber", "b) Tesla", "c) Ampere", "d) Coulomb" };
                        correctAnswer = "a";
                        break;

                    case 10:
                        question = "Hvad er enheden for elektrisk potentiale?";
                        choices = new string[] { "a) Volt", "b) Ampere", "c) Ohm", "d) Watt" };
                        correctAnswer = "a";
                        break;

                    case 11:
                        question = "Hvad er den anden lov i Newtons bevægelseslove?";
                        choices = new string[] { "a) F = ma", "b) a = F/m", "c) F = G(m1m2)/r^2", "d) E = mc^2" };
                        correctAnswer = "a";
                        break;

                    case 12:
                        question = "Hvad er enheden for elektrisk modstand?";
                        choices = new string[] { "a) Ohm", "b) Watt", "c) Ampere", "d) Volt" };
                        correctAnswer = "a";
                        break;

                    default:
                        Console.WriteLine("Ugyldigt spørgsmål");
                        return;
                }

                Console.WriteLine("spørgsmål: " + (i + 1) + "\n" + question);
                foreach (string choice in choices)
                {
                    Console.WriteLine(choice);
                }

                // Læs brugerens svar og valider det
                Console.Write("Svar: ");
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Korrekt!\n");
                    scorer++;
                }
                else
                {
                    Console.WriteLine("Forkert svar. Det korrekte svar er: " + correctAnswer + "\n");
                }


            }
        }

        static void bevægelse()
        {
            Console.Clear();
            List<int> brugteTal = new List<int>();
            int spørgsmål = 0;
            int antalSpg = 10;
            for (int i = 0; i < antalSpg + 1; i++)
            {
                bool h = false;

                while (!h)
                {
                    bool erBrugt = false;
                    Random tal = new Random();
                    spørgsmål = tal.Next(1, antalSpg + 1);
                    for (int j = 0; j < brugteTal.Count; j++)       
                    {
                        if (brugteTal[j] == spørgsmål)              
                        {
                            erBrugt = true;
                        }
                    }
                    if (!erBrugt)
                    {
                        h = true;
                        brugteTal.Add(spørgsmål);
                    }
                    else if (brugteTal.Count == antalSpg)
                    {
                        string? prøvIgen = "";
                        Console.WriteLine("Du fik " + scorer + "/" + antalSpg + " rigtige. Vil du prøge igen? Y/N");
                        prøvIgen = Console.ReadLine();
                        if (string.IsNullOrEmpty(prøvIgen))
                        {
                            return;
                        }
                        if (prøvIgen.ToLower() == "y")
                        {
                            Console.Clear();
                            MC();
                        }
                        return;
                    }
                }

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

                    case 7:
                        question = "Hvad er enheden for tryk?";
                        choices = new string[] { "a) Pascal", "b) Newton", "c) Joule", "d) Watt" };
                        correctAnswer = "a";
                        break;

                    case 8:
                        question = "Hvad er den hastighed, som et legeme nærmer sig jorden med, når det frit falder?";
                        choices = new string[] { "a) 9.81 m/s", "b) 10 m/s", "c) 100 m/s", "d) 1,000 m/s" };
                        correctAnswer = "a";
                        break;

                    case 9:
                        question = "Hvad er enheden for magnetisk flux?";
                        choices = new string[] { "a) Weber", "b) Tesla", "c) Ampere", "d) Coulomb" };
                        correctAnswer = "a";
                        break;

                    case 10:
                        question = "Hvad er enheden for elektrisk potentiale?";
                        choices = new string[] { "a) Volt", "b) Ampere", "c) Ohm", "d) Watt" };
                        correctAnswer = "a";
                        break;

                    case 11:
                        question = "Hvad er den anden lov i Newtons bevægelseslove?";
                        choices = new string[] { "a) F = ma", "b) a = F/m", "c) F = G(m1m2)/r^2", "d) E = mc^2" };
                        correctAnswer = "a";
                        break;

                    case 12:
                        question = "Hvad er enheden for elektrisk modstand?";
                        choices = new string[] { "a) Ohm", "b) Watt", "c) Ampere", "d) Volt" };
                        correctAnswer = "a";
                        break;

                    default:
                        Console.WriteLine("Ugyldigt spørgsmål");
                        return;
                }

                Console.WriteLine("spørgsmål: " + (i + 1) + "\n" + question);
                foreach (string choice in choices)
                {
                    Console.WriteLine(choice);
                }

                // Læs brugerens svar og valider det
                Console.Write("Svar: ");
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Korrekt!\n");
                    scorer++;
                }
                else
                {
                    Console.WriteLine("Forkert svar. Det korrekte svar er: " + correctAnswer + "\n");
                }
            }
        }
    }
}