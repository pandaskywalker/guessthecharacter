using System;

namespace ConsoleApp1
{
    class Program
    {
        // Cont - переменная позволяющая продолжить игру
        //
        static bool cont = true;
        static void Main()
        {
            // начальные очки
            int score = 0;
            while (cont == true)
            {
                string charlist = "Harry, Ron, Hermione, Luna, Severus, Voldemort, Albus";
                string[] s = "Harry|Ron|Hermione|Luna|Severus|Voldemort|Albus".Split('|');
                // рандом последством переменной rnd
                Random rnd = new Random();
                string r = s[rnd.Next(s.Length)];
                Console.WriteLine("Welcome To The Guess The Character Game");
                Console.WriteLine("Version - v0.3");
                Console.WriteLine("Guess between these characters - {0}", charlist);

                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine("You've got {0} attempts", i);
                    string userchar;
                    Console.WriteLine("Your Character - ");
                    userchar = Console.ReadLine();
                    if (userchar == r)
                    {
                        score++;
                        i = 5;
                        Console.WriteLine("Random character is - {0}", r);
                        Console.WriteLine("User character is - {0}", userchar);
                        Console.WriteLine("You Win!");
                        Console.WriteLine("Score - {0}", score);
                        Console.WriteLine("Do you want to continue? [y] ( Any other key terminates process )");
                        ConsoleKeyInfo cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Y)
                        {
                            i = 5;
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
                        score = 0;
                        i = 0;
                        Console.WriteLine("Voldemort has come!");
                        Console.WriteLine("You Lose!");
                        Console.WriteLine("Score - {0}", score);
                        Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                        ConsoleKeyInfo ck = Console.ReadKey();
                        if (ck.Key == ConsoleKey.Y)
                        {
                            i = 5;
                            Console.WriteLine("");
                            continue;
                        }
                        else
                        {
                            cont = false;
                            break;
                        }
                    }
                    while (i == 1 && userchar != r)
                    {
                        score = 0;
                        Console.WriteLine("You've run out of attempts!");
                        Console.WriteLine("Score - {0}", score);
                        Console.WriteLine("You lose!");
                        Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                        ConsoleKeyInfo ck = Console.ReadKey();
                        if (ck.Key == ConsoleKey.Y)
                        {
                            i = 6;
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
