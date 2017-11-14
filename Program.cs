using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheCharacter0._4
{
    class Program
    {
        static bool cont = true;
        static int dif;
        static int userdif;
        static string charlist = "Harry, Ron, Hermione, Luna, Severus, Voldemort, Albus";
        static string[] s = "Harry|Ron|Hermione|Luna|Severus|Voldemort|Albus".Split('|');
        static string userchar;
        static int points = 0;

        static void Diff(string difficulty)
        {
            switch (Convert.ToInt32(difficulty))
            {
                case 1:
                    dif = 5;
                    userdif = dif;
                    break;
                case 2:
                    dif = 3;
                    userdif = dif;
                    break;
                case 3:
                    dif = 1;
                    userdif = dif;
                    break;

            }
        }

        static void Main(string[] args)
        {
            while (cont == true)
            {
                Random rnd = new Random();
                Console.WriteLine("Welcome To The Guess The Character Game");
                Console.WriteLine("Version - v0.4");
                Console.WriteLine("Guess between these characters - {0}", charlist);
                Console.WriteLine("Choose the difficulty - (1 for easy, 2 for medium, 3 for hard)");
                Diff(Console.ReadLine());

                for (; dif > 0; dif--)
                {
                    string r = s[rnd.Next(s.Length)];
                    Console.WriteLine("You have {0} attempts!", dif);
                    Console.WriteLine("Your character - ");
                    userchar = Console.ReadLine();

                    if (userchar == r)
                    {
                        points++;

                        dif = userdif;
                        Console.WriteLine("Random character is - {0}", r);
                        Console.WriteLine("User character is - {0}", userchar);
                        Console.WriteLine("You Win!");
                        Console.WriteLine("Score - {0}", points);
                        Console.WriteLine("Do you want to continue? [y] ( Any other key terminates process )");
                        ConsoleKeyInfo cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Y)
                        {
                            dif = userdif + 1;
                            Console.WriteLine("");
                            Console.WriteLine("Good luck");
                            continue;

                        }
                        else
                        {
                            cont = false;
                            break;
                        }
                    }
                    else if (r == "Voldemort")
                    {
                        points = 0;
                        dif = 0;
                        Console.WriteLine("Voldemort has come!");
                        Console.WriteLine("You Lose!");
                        Console.WriteLine("Score - {0}", points);
                        Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                        ConsoleKeyInfo ck = Console.ReadKey();
                        if (ck.Key == ConsoleKey.Y)
                        {
                            dif = userdif + 1;
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            cont = false;
                            break;
                        }
                    }
                    while (dif == 1 && userchar != r)
                    {
                        points = 0;
                        Console.WriteLine("You've run out of attempts!");
                        Console.WriteLine("Score - {0}", points);
                        Console.WriteLine("You lose!");
                        Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                        ConsoleKeyInfo ck = Console.ReadKey();
                        if (ck.Key == ConsoleKey.Y)
                        {
                            dif = userdif + 1;
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            cont = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
