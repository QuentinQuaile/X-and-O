//This code is brought to you by C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quuestion_1
{
    class Program
    {
        static string[,] yes = new string[3, 3];
        static void Main(string[] args)
        
        {
            int count = 2;


            for (int i = 0; i < 3; i++)
            {
                for (int g = 0; g < 3; g++)
                {
                    yes[i, g] = "[-]";
                }
            }
            ConsoleKeyInfo wubba;

            int a = 0, b = 0;
            do
            {
                if (yes[a,b] != "[O]" && yes[a,b] != "[X]")
                {
                    yes[a, b] = "[_]";                   
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int g = 0; g < 3; g++)
                    {
                        Console.Write(yes[i, g]);
                    }
                    Console.WriteLine("");
                } 

                Console.WriteLine("Enter in key: ");
                wubba = Console.ReadKey();

                movement(wubba, ref a, ref b); // This is for movement  

                if (KeyPressed(wubba,a,b,count) == true)
                {
                    count++;
                }
                Console.Clear();
            } while (win() == false);
            for (int i = 0; i < 3; i++)
            {
                for (int g = 0; g < 3; g++)
                {
                    Console.Write(yes[i, g]);
                }
                Console.WriteLine("");
            }
        }
        static bool KeyPressed(ConsoleKeyInfo wubba, int a, int b, int count)
        {
            if (wubba.Key == ConsoleKey.Enter && yes[a,b] != "[X]" && yes[a,b] != "[O]")
            {
                if (count % 2 == 0)
                {
                        yes[a, b] = "[X]";
                }
                else if (count % 2 == 1)
                {
                        yes[a, b] = "[O]";
                }
                return true;
            }
            else
                return false;
        }
        static void movement(ConsoleKeyInfo wubba, ref int a, ref int b)
        {
                if (wubba.Key == ConsoleKey.DownArrow)
                {
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[-]";
                    }
                    a++;
                WithinRange(wubba, ref a, ref b);
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[_]";
                    }
                }


                else if (wubba.Key == ConsoleKey.RightArrow)
                {
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[-]";
                    }
                    b++;
                WithinRange(wubba, ref a, ref b);
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[_]";
                    }
                }
                else if (wubba.Key == ConsoleKey.UpArrow)
                {
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[-]";
                    }
                    a--;
                WithinRange(wubba, ref a, ref b);
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[_]";
                    }
                }
                else if (wubba.Key == ConsoleKey.LeftArrow)
                {
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[-]";
                    }
                    b--;
                WithinRange(wubba, ref a, ref b);
                    if (yes[a, b] != "[O]" && yes[a, b] != "[X]")
                    {
                        yes[a, b] = "[_]";
                    }
                }
        }
        static bool WithinRange(ConsoleKeyInfo wubba, ref int a, ref int b)
        {
            if (a > 2)
            {
                a = a - 3;
                return true;
            }
            else if(a < 0)
            {
                a = a + 3;
                return true;
            }
            if (b > 2)
            {
                b = b - 3;
                return true;
            }
            else if (b < 0)
            {
                b = b + 3;
                return true;
            }
            else
                return true;
        }
        static bool win()
        {
            int rowOne = 0, Digcount = 0, rowTwo = 0, rowThree = 0, ReDigcount = 0, verOne = 0, verTwo = 0, verThree = 0;
            int DigcountO = 0, rowOneO = 0, rowTwoO = 0, rowThreeO = 0, ReDigcountO = 0, verOneO = 0, verTwoO = 0, verThreeO = 0;
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                if (yes[i, i] == "[X]")
                {
                    Digcount++;
                }
                if (yes[i, i] == "[O]")
                {
                    DigcountO++;
                }

            }

            for (int i = 0; i < 3; i++)
            {
                if (yes[0, i] == "[X]")
                {
                    rowOne = rowOne + 1;
                }
                if (yes[1, i] == "[X]")
                {
                    rowTwo = rowTwo + 1;
                }
                if (yes[2, i] == "[X]")
                {
                    rowThree = rowThree + 1;
                }
                if (yes[0, i] == "[O]")
                {
                    rowOneO = rowOneO + 1;
                }
                if (yes[1, i] == "[O]")
                {
                    rowTwoO = rowTwoO + 1;
                }
                if (yes[2, i] == "[O]")
                {
                    rowThreeO = rowThreeO + 1;
                }

            }

            for (int i = 0; i < 3; i++)
            {
                if (yes[i, 0] == "[X]")
                {
                    verOne = verOne + 1;
                }
                if (yes[i, 1] == "[X]")
                {
                    verTwo = verTwo + 1;
                }
                if (yes[i, 2] == "[X]")
                {
                    verThree = verThree + 1;
                }
                if (yes[i, 0] == "[O]")
                {
                    verOneO = verOneO + 1;
                }
                if (yes[i, 1] == "[O]")
                {
                    verTwoO = verTwoO + 1;
                }
                if (yes[i, 2] == "[O]")
                {
                    verThreeO = verThreeO + 1;
                }

            }
            for (int g = 0; g < 3; g++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (yes[g, i] == "[X]" || yes[g, i] == "[O]")
                    {
                        count++;
                    }
                }

            }

            if (yes[2, 0] == "[X]" && yes[1, 1] == "[X]" && yes[0, 2] == "[X]")
            {
                ReDigcount = ReDigcount + 1;
            }
            else if (yes[2, 0] == "[O]" && yes[1, 1] == "[O]" && yes[0, 2] == "[O]")
            {
                ReDigcountO = ReDigcountO + 1;
            }

            if (Digcount == 3 || rowOne == 3 || rowTwo == 3 || rowThree == 3 || ReDigcount == 1 || verOne == 3 || verTwo == 3 || verThree == 3)
            {
                Console.WriteLine("X Wins");
                return true;
            }
            else if (DigcountO == 3 || rowOneO == 3 || rowTwoO == 3 || rowThreeO == 3 || ReDigcountO == 1 || verOneO == 3 || verTwoO == 3 || verThreeO == 3)
            {
                Console.WriteLine("O Wins");
                return true;
            }
            else if (count == 9)
            {
                Console.WriteLine("OwO men's day aka draw");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
