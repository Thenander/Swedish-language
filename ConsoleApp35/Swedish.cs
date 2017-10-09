using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;

namespace Lab3
{
    class Swedish
    {
        /* * * * Variabel med lång livslängd :-) * * * */
        static StringBuilder sb = new StringBuilder();

        /* * * * Property/Getter för val av ord * * * */
        public static int ChoseANumber
        {
            get
            {
                Console.Write("\nVälj ett nummer i listan ovan: ");
                int choseInput;
                choseInput = int.Parse(Console.ReadLine());
                return choseInput;
            }
        }

        /* * * * END loop * * * */
        public static void EndLoop()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
        }

        /* * * * Metoder för print av listor * * * */
        public static void Adjective()
        {
            for (int i = 1; i < adjectiveList.Count; i++)
            {
                MakingNumberedList list = adjectiveList[i];
                Console.WriteLine(list.Id + ". " + list.Words);
            }
        }
        public static void Adverb()
        {
            for (int i = 1; i < adverbList.Count; i++)
            {
                MakingNumberedList list = adverbList[i];
                Console.WriteLine(list.Id + ". " + list.Words);
            }
        }
        public static void Conjunction()
        {
            for (int i = 1; i < conjunctionList.Count; i++)
            {
                MakingNumberedList list = conjunctionList[i];
                Console.WriteLine(list.Id + ". " + list.Words);
            }
        }
        public static void PersonalPronoun()
        {
            for (int i = 1; i < personalPronounList.Count; i++)
            {
                MakingNumberedList list = personalPronounList[i];
                Console.WriteLine(list.Id + ". " + list.Words);
            }
        }
        public static void Verb()
        {
            for (int i = 1; i < verbList.Count; i++)
            {
                MakingNumberedList list = verbList[i];
                Console.WriteLine(list.Id + ". " + list.Words);
            }
        }
        public static void Punctuation()
        {
            for (int i = 1; i < punctuationList.Count; i++)
            {
                MakingNumberedList list = punctuationList[i];
                Console.WriteLine(list.Id + ". " + list.Words);
            }
        }

        /* * * * Listor * * * */
        private static List<MakingNumberedList> mainList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() { Words = "Adjektiv",                      Id =  1 },
            new MakingNumberedList() { Words = "Adverb",                        Id =  2 },
            new MakingNumberedList() { Words = "Konjunktioner",                 Id =  3 },
            new MakingNumberedList() { Words = "Personliga pronomen",           Id =  4 },
            new MakingNumberedList() { Words = "Verb",                          Id =  5 },
            new MakingNumberedList() { Words = "Skiljetecken",                  Id =  6 },
            new MakingNumberedList() { Words = "Skriv din egen mening",         Id =  7 },
            new MakingNumberedList() { Words = "Titta på din skapade mening",   Id =  8 },
            new MakingNumberedList() { Words = "Radera den skapade meningen",    Id =  9 },
            new MakingNumberedList() { Words = "Spara och avsluta",             Id = 10 },
            new MakingNumberedList() { Words = "Avsluta (utan att spara)",      Id = 11 },
        };
        private static List<MakingNumberedList> adjectiveList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() {                                                  },
            new MakingNumberedList() { Words = "röd",                           Id =  1 },
            new MakingNumberedList() { Words = "sur",                           Id =  2 },
            new MakingNumberedList() { Words = "svart",                         Id =  3 },
            new MakingNumberedList() { Words = "tjock",                         Id =  4 },
            new MakingNumberedList() { Words = "stor",                          Id =  5 },
            new MakingNumberedList() { Words = "underbar",                      Id =  6 },
            new MakingNumberedList() { Words = "vacker",                        Id =  7 },
            new MakingNumberedList() { Words = "snygg",                         Id =  8 },
            new MakingNumberedList() { Words = "fin",                           Id =  9 },
            new MakingNumberedList() { Words = "kraftig",                       Id = 10 },
            new MakingNumberedList() { Words = "lång",                          Id = 11 },
            new MakingNumberedList() { Words = "glad",                          Id = 12 },
            new MakingNumberedList() { Words = "rund",                          Id = 13 },
            new MakingNumberedList() { Words = "trött",                         Id = 14 },
        };
        private static List<MakingNumberedList> adverbList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() {                                                  },
            new MakingNumberedList() { Words = "sakta",                         Id =  1 },
            new MakingNumberedList() { Words = "flitigt",                       Id =  2 },
            new MakingNumberedList() { Words = "hårt",                          Id =  3 },
            new MakingNumberedList() { Words = "bra",                           Id =  4 },
            new MakingNumberedList() { Words = "högt",                          Id =  5 },
            new MakingNumberedList() { Words = "ofta",                          Id =  6 },
            new MakingNumberedList() { Words = "snabbt",                        Id =  7 },
            new MakingNumberedList() { Words = "rakt",                          Id =  8 },
            new MakingNumberedList() { Words = "högljutt",                      Id =  9 },
            new MakingNumberedList() { Words = "mjukt",                         Id = 10 },
            new MakingNumberedList() { Words = "farligt",                       Id = 11 },
        };
        private static List<MakingNumberedList> conjunctionList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() {                                                  },
            new MakingNumberedList() { Words = "och",                           Id =  1 },
            new MakingNumberedList() { Words = "eller",                         Id =  2 },
            new MakingNumberedList() { Words = "utan",                          Id =  3 },
            new MakingNumberedList() { Words = "men",                           Id =  4 },
            new MakingNumberedList() { Words = "för",                           Id =  5 },
            new MakingNumberedList() { Words = "ty",                            Id =  6 },
            new MakingNumberedList() { Words = "samt",                          Id =  7 },
            new MakingNumberedList() { Words = "fast",                          Id =  8 },
        };
        private static List<MakingNumberedList> personalPronounList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() {                                                  },
            new MakingNumberedList() { Words = "jag",                           Id =  1 },
            new MakingNumberedList() { Words = "du",                            Id =  2 },
            new MakingNumberedList() { Words = "vi",                            Id =  3 },
            new MakingNumberedList() { Words = "han",                           Id =  4 },
            new MakingNumberedList() { Words = "hon",                           Id =  5 },
            new MakingNumberedList() { Words = "den",                           Id =  6 },
            new MakingNumberedList() { Words = "det",                           Id =  7 },
            new MakingNumberedList() { Words = "de",                            Id =  8 },
        };
        private static List<MakingNumberedList> verbList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() {                                                  },
            new MakingNumberedList() { Words = "springer",                      Id =  1 },
            new MakingNumberedList() { Words = "pratar",                        Id =  2 },
            new MakingNumberedList() { Words = "jobbar",                        Id =  3 },
            new MakingNumberedList() { Words = "hoppar",                        Id =  4 },
            new MakingNumberedList() { Words = "bakar",                         Id =  5 },
            new MakingNumberedList() { Words = "trycker",                       Id =  6 },
            new MakingNumberedList() { Words = "dansar",                        Id =  7 },
            new MakingNumberedList() { Words = "spikar",                        Id =  8 },
            new MakingNumberedList() { Words = "vinglar",                       Id =  9 },
            new MakingNumberedList() { Words = "äter",                          Id = 10 },
        };
        private static List<MakingNumberedList> punctuationList = new List<MakingNumberedList>()
        {
            new MakingNumberedList() {                                                  },
            new MakingNumberedList() { Words = ". ",                            Id =  1 },
            new MakingNumberedList() { Words = ", ",                            Id =  2 },
            new MakingNumberedList() { Words = "! ",                            Id =  3 },
            new MakingNumberedList() { Words = "? ",                            Id =  4 },
            new MakingNumberedList() { Words = ": ",                            Id =  5 },
            new MakingNumberedList() { Words = "; ",                            Id =  6 },
            new MakingNumberedList() { Words = "- ",                            Id =  7 },
        };

        /* * * * MESSAGES * * * */
        private static void ErrorMessage() => Console.WriteLine("Återgår till huvudmenyn");
        private static void AdjectiveMessage() => Console.WriteLine("ADJEKTIV\n");
        private static void AdverbMessage() => Console.WriteLine("ADVERB\n");
        private static void ConjunctionMessage() => Console.WriteLine("KONJUNKTIONER\n");
        private static void PersonalPronounMessage() => Console.WriteLine("PERSONLIGA PRONOMEN\n");
        private static void VerbMessage() => Console.WriteLine("VERB\n");
        private static void PunctuationMessage() => Console.WriteLine("SKILJETECKEN\n");
        private static void WelcomeMessage() => Console.WriteLine("Välkommen till 'SVENSKA SPRÅKET'" +
                            "\nHär kan du få hjälp att formulera meningar med ordklasser som utgångspunkt." +
                            "\nNär du avslutar programmet sparas en textfil till din dator med namnet " +
                            "\"Lab3_Joacim_Thenander.txt\"" +
                            "\n\nTryck på RETURN för att börja!");

        /* * * * Ordklass val * * * */
        private static void FirstChoice()
        {
            Console.WriteLine("\nVälj ett nummer i menyn:\n");

            foreach (MakingNumberedList item in mainList)
            {
                Console.WriteLine(item.Id + ". " + item.Words);
            }
            Console.WriteLine();
        }

        /* * * * MAIN PROGRAM * * * */
        private static void MainProgram()
        {
            FirstChoice();

            /* * * * Try/Catch som ger felmeddelande om annat än case skrivs in. * * * */
            try
            {
                int mainListSwitcher;

                mainListSwitcher = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (mainListSwitcher)
                {
                    case 1:
                        Console.Clear();
                        AdjectiveMessage();
                        Adjective();

                        int adjectiveInput = ChoseANumber;
                        for (int i = 0; i < adjectiveList.Count; i++)
                        {
                            MakingNumberedList values = adjectiveList[i];
                            if (adjectiveInput == i)
                            {
                                sb.Append(" " + values.Words);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        AdverbMessage();
                        Adverb();

                        int adverbInput = ChoseANumber;
                        for (int i = 0; i < adverbList.Count; i++)
                        {
                            MakingNumberedList values = adverbList[i];
                            if (adverbInput == i)
                            {
                                sb.Append(" " + values.Words);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        ConjunctionMessage();
                        Conjunction();

                        int conjunctionInput = ChoseANumber;
                        for (int i = 0; i < conjunctionList.Count; i++)
                        {
                            MakingNumberedList values = conjunctionList[i];
                            if (conjunctionInput == i)
                            {
                                sb.Append(" " + values.Words);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        PersonalPronounMessage();
                        PersonalPronoun();

                        int personalPronounInput = ChoseANumber;
                        for (int i = 0; i < personalPronounList.Count; i++)
                        {
                            MakingNumberedList values = personalPronounList[i];
                            if (personalPronounInput == i)
                            {
                                sb.Append(" " + values.Words);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.Clear();
                        VerbMessage();
                        Verb();

                        int input = ChoseANumber;
                        for (int i = 0; i < verbList.Count; i++)
                        {
                            MakingNumberedList values = verbList[i];
                            if (input == i)
                            {
                                sb.Append(" " + values.Words);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        PunctuationMessage();
                        Punctuation();

                        int verbInput = ChoseANumber;
                        for (int i = 0; i < punctuationList.Count; i++)
                        {
                            MakingNumberedList values = punctuationList[i];
                            if (verbInput == i)
                            {
                                sb.Append(" " + values.Words);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("Skriv in egna ord eller en egen mening: ");
                        string egenMening = Console.ReadLine();
                        sb.Append(" " + egenMening);
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Den skapade meningen är:\n" + sb);
                        Console.WriteLine("\nTryck på RETURN för att återgå.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        sb.Clear();
                        Console.WriteLine("Raderad!");
                        Thread.Sleep(700);
                        Console.Clear();
                        break;
                    case 10:
                        StreamWriter streamWriter = new StreamWriter("Lab3_Joacim_Thenander.txt", append: true);
                        streamWriter.WriteLine(sb);
                        streamWriter.Close();
                        Console.Clear();
                        Console.Write("sparar till disk");
                        Thread.Sleep(400);
                        EndLoop();
                        Environment.Exit(0);
                        break;
                    case 11:
                        Console.Write("Avslutar...");
                        Thread.Sleep(700);
                        Environment.Exit(0);
                        break;
                    default:
                        MainProgram();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                SystemSounds.Beep.Play();
                Console.WriteLine(e.Message+"\n");
                ErrorMessage();
                Thread.Sleep(700);
                MainProgram();
            }
            MainProgram();
        }

        public static void Main()
        {
            WelcomeMessage();
            Console.ReadLine();
            Console.Clear();
            MainProgram();
        }
    }
}