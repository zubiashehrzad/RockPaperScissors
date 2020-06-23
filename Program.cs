using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputPlayer, otherplayer = null;
            int randomInt;
            int n = 0;
            int r = 0, p = 0, s = 0;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("\nChoose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 2);

                    switch (randomInt)
                    {
                        case 1:
                            otherplayer = "ROCK";
                            Console.WriteLine("Another Player chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                r += 2;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("You WIN!!\n\n");
                                scorePlayer++;
                                p += 1;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Another Player WINS!!\n\n");
                                scoreCPU++;
                                s += 1;
                            }
                            break;
                        case 2:
                            otherplayer = "PAPER";
                            Console.WriteLine("Another Player chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                p += 2;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Another Player WINS!!\n\n");
                                scoreCPU++;
                                r += 1;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("You WINS!!\n\n");
                                scorePlayer++;
                                s += 1;
                            }
                            break;
                        case 3:
                            otherplayer = "SCISSORS";
                            Console.WriteLine("Another Player chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                s += 2;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("You WINS!!\n\n");
                                scorePlayer++;
                                r += 1;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Another Player WINS!!\n\n");
                                scoreCPU++;
                                p += 1;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                  


                    Console.WriteLine("\nSCORES:\tYou:\t{0}\tAnother Player:\t{1}\tNumber of Turns Game Took:\t{2}", scorePlayer, scoreCPU,n+=1);
                    if (r > p && r > s)
                    {
                        Console.WriteLine("\n Most used move during game is rockk");

                    }
                   else if (p > r && p > s)
                    {
                        Console.WriteLine("\n  Most used move during game is paper");

                    }
                    else if (s > r && s > p)
                    {
                        Console.WriteLine("\n Most used move during game is  scissoirs");

                    }
                    else
                    {

                    }
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("You WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Another Player WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}