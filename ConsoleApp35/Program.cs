using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {

            Communication.FirstChoice();

            while (true)
            {
                try
                {
                    int mainListSwitcher;

                    mainListSwitcher = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (mainListSwitcher)
                    {
                        case 1:
                            if (mainListSwitcher == 1)
                            {
                                Console.Clear();
                                ChoiceOfList.Adjective();
                            }
                            break;
                        case 2:
                            if (mainListSwitcher == 2)
                            {
                                Console.Clear();
                                ChoiceOfList.Adverb();
                            }
                            break;
                        case 3:
                            if (mainListSwitcher == 3)
                            {
                                Console.Clear();
                                ChoiceOfList.Conjunction();
                            }
                            break;
                        case 4:
                            if (mainListSwitcher == 4)
                            {
                                Console.Clear();
                                ChoiceOfList.PersonalPronoun();
                            }
                            break;
                        case 5:
                            if (mainListSwitcher == 5)
                            {
                                Console.Clear();
                                ChoiceOfList.Verb();
                            }
                            break;
                        default:
                            Console.Clear();
                            Communication.ErrorMessage();
                            Thread.Sleep(1000);
                            Communication.FirstChoice();
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Communication.ErrorMessage();
                    Thread.Sleep(1000);
                    Communication.FirstChoice();
                }
            }



            //Console.WriteLine("Skriv:");
            //string answer = Console.ReadLine();
            //sb.Append(answer + " ");
            //Console.WriteLine("Skriv igen:");
            //sb.Append(Console.ReadLine() + " ");
            //Console.WriteLine();
            //Console.WriteLine(sb);

        }
    }
}
