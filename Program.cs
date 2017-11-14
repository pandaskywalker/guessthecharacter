using System;

namespace ConsoleApp1
{
    class Program
    {
        // cont - Will use later for continuing game.

        static bool cont = true;
        static void Main()
        {
            // Points at start.
            int points = 0;
            
            while (cont == true)
            {
                string charlist = "Harry, Ron, Hermione, Luna, Severus, Voldemort, Albus";
                string[] s = "Harry|Ron|Hermione|Luna|Severus|Voldemort|Albus".Split('|');

                // Choosing random character.
                Random rnd = new Random();
                string r = s[rnd.Next(s.Length)];
                Console.WriteLine("Welcome To The Guess The Character Game");
                Console.WriteLine("Version - v0.3");
                Console.WriteLine("Guess between these characters - {0}", charlist);
                string diff;
                Console.WriteLine("Choose the difficulty - (1 for hard, 2 for medium, 3 for easy)");
                diff = Console.ReadLine();
                switch (Convert.ToInt32(diff))
                {
                    case 1:
                        for (int i = 2; i > 0; i--)
                        {
                            Console.WriteLine("You've got {0} attempts", i);

                            // Declaring userchar to accept user input and then use it in if/else.

                            string userchar;
                            Console.WriteLine("Your Character - ");
                            userchar = Console.ReadLine();

                            // Checking if user input & randomly choosen string are the same.
                            // In order if they are the same, you win, get 1 point and you are able to continue game with saving your points
                            if (userchar == r)
                            {
                                points++;
                                i = 2;
                                Console.WriteLine("Random character is - {0}", r);
                                Console.WriteLine("User character is - {0}", userchar);
                                Console.WriteLine("You Win!");
                                Console.WriteLine("Score - {0}", points);
                                Console.WriteLine("Do you want to continue? [y] ( Any other key terminates process )");
                                ConsoleKeyInfo cki = Console.ReadKey();
                                if (cki.Key == ConsoleKey.Y)
                                {
                                    i = 2;
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
                            // If randomly chosen character is Voldemort, you lose.
                            else if (r == "Voldemort")
                            {
                                points = 0;
                                i = 0;
                                Console.WriteLine("Voldemort has come!");
                                Console.WriteLine("You Lose!");
                                Console.WriteLine("Score - {0}", points);
                                Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                                ConsoleKeyInfo ck = Console.ReadKey();
                                if (ck.Key == ConsoleKey.Y)
                                {
                                    i = 2;
                                    Console.WriteLine("");
                                    continue;
                                }
                                else
                                {
                                    cont = false;
                                    break;
                                }
                            }
                            // If you run out of attempts you get message about this and you are able to try again.
                            while (i == 1 && userchar != r)
                            {
                                points = 0;
                                Console.WriteLine("You've run out of attempts!");
                                Console.WriteLine("Score - {0}", points);
                                Console.WriteLine("You lose!");
                                Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                                ConsoleKeyInfo ck = Console.ReadKey();
                                if (ck.Key == ConsoleKey.Y)
                                {
                                    i = 3;
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
                        break;
                    case 2:
                        for (int i = 3; i > 0; i--)
                        {
                            Console.WriteLine("You've got {0} attempts", i);

                            // Declaring userchar to accept user input and then use it in if/else.

                            string userchar;
                            Console.WriteLine("Your Character - ");
                            userchar = Console.ReadLine();

                            // Checking if user input & randomly choosen string are the same.
                            // In order if they are the same, you win, get 1 point and you are able to continue game with saving your points
                            if (userchar == r)
                            {
                                points++;
                                i = 3;
                                Console.WriteLine("Random character is - {0}", r);
                                Console.WriteLine("User character is - {0}", userchar);
                                Console.WriteLine("You Win!");
                                Console.WriteLine("Score - {0}", points);
                                Console.WriteLine("Do you want to continue? [y] ( Any other key terminates process )");
                                ConsoleKeyInfo cki = Console.ReadKey();
                                if (cki.Key == ConsoleKey.Y)
                                {
                                    i = 3;
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
                            // If randomly chosen character is Voldemort, you lose.
                            else if (r == "Voldemort")
                            {
                                points = 0;
                                i = 0;
                                Console.WriteLine("Voldemort has come!");
                                Console.WriteLine("You Lose!");
                                Console.WriteLine("Score - {0}", points);
                                Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                                ConsoleKeyInfo ck = Console.ReadKey();
                                if (ck.Key == ConsoleKey.Y)
                                {
                                    i = 3;
                                    Console.WriteLine("");
                                    continue;
                                }
                                else
                                {
                                    cont = false;
                                    break;
                                }
                            }
                            // If you run out of attempts you get message about this and you are able to try again.
                            while (i == 1 && userchar != r)
                            {
                                points = 0;
                                Console.WriteLine("You've run out of attempts!");
                                Console.WriteLine("Score - {0}", points);
                                Console.WriteLine("You lose!");
                                Console.WriteLine("Do you want to try again? [y] ( Any other key terminates process )");
                                ConsoleKeyInfo ck = Console.ReadKey();
                                if (ck.Key == ConsoleKey.Y)
                                {
                                    i = 4;
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
                        break;
                    case 3:
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine("You've got {0} attempts", i);

                            // Declaring userchar to accept user input and then use it in if/else.

                            string userchar;
                            Console.WriteLine("Your Character - ");
                            userchar = Console.ReadLine();

                            // Checking if user input & randomly choosen string are the same.
                            // In order if they are the same, you win, get 1 point and you are able to continue game with saving your points
                            if (userchar == r)
                            {
                                points++;
                                i = 5;
                                Console.WriteLine("Random character is - {0}", r);
                                Console.WriteLine("User character is - {0}", userchar);
                                Console.WriteLine("You Win!");
                                Console.WriteLine("Score - {0}", points);
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
                            // If randomly chosen character is Voldemort, you lose.
                            else if (r == "Voldemort")
                            {
                                points = 0;
                                i = 0;
                                Console.WriteLine("Voldemort has come!");
                                Console.WriteLine("You Lose!");
                                Console.WriteLine("Score - {0}", points);
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
                            // If you run out of attempts you get message about this and you are able to try again.
                            while (i == 1 && userchar != r)
                            {
                                points = 0;
                                Console.WriteLine("You've run out of attempts!");
                                Console.WriteLine("Score - {0}", points);
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
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
