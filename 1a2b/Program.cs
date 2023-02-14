using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ans = new int[10];
            int t, r;
            bool game1 = true;
            Console.WriteLine("Welcome to the 1A2B number guessing game~");
            while (game1)
            {

                bool game2 = true;
                Random ran = new Random();
                for (int i = 0; i < 10; i++)
                {
                    ans[i] = i;
                }
                for (int i = 0; i < 10; i++)
                {
                    r = ran.Next(0, 10 - i);
                    t = ans[r];
                    ans[r] = ans[9 - i];
                    ans[9 - i] = t;
                }
                while (game2)
                {
                    int a = 0;
                    int b = 0;
                    Console.WriteLine("------");
                    Console.Write("Please enter 4 numbers:");
                    string[] arr = Console.ReadLine().Split(' ');
                    int guessnumber1 = Convert.ToInt16(arr[0]) / 1000;
                    int guessnumber2 = (Convert.ToInt16(arr[0]) / 100) - (guessnumber1 * 10);
                    int guessnumber3 = (Convert.ToInt16(arr[0]) / 10) - (guessnumber1 * 100) - (guessnumber2 * 10);
                    int guessnumber4 = (Convert.ToInt16(arr[0])) - (guessnumber1 * 1000) - (guessnumber2 * 100) - (guessnumber3 * 10);

                    if (guessnumber1 == ans[0]) { a++; };
                    if (guessnumber2 == ans[1]) { a++; };
                    if (guessnumber3 == ans[2]) { a++; };
                    if (guessnumber4 == ans[3]) { a++; };
                    if (guessnumber1 == ans[1] || guessnumber1 == ans[2] || guessnumber1 == ans[3]) { b++; };
                    if (guessnumber2 == ans[0] || guessnumber2 == ans[2] || guessnumber2 == ans[3]) { b++; };
                    if (guessnumber3 == ans[1] || guessnumber3 == ans[0] || guessnumber3 == ans[3]) { b++; };
                    if (guessnumber4 == ans[1] || guessnumber4 == ans[2] || guessnumber4 == ans[0]) { b++; };

                    Console.WriteLine($"The judgment result is {a}A{b}B");
                    //Console.WriteLine($"ans{ans[0]}{ans[1]}{ans[2]}{ans[3]}");//測試
                    if (a == 4)
                    {
                        Console.WriteLine("congratulations! You guessed it! !");
                        Console.WriteLine("------");
                        game2 = false;
                    }

                }
                Console.Write("Do you want to play again ?(y/n): ");

                string re = Console.ReadLine();
                if(re == "n")
                {
                    game1 = false;
                }
            }
        }
    }
}
