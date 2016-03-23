using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n + 1;
        int height = (n * 3) + 1;

        char star = '*';

        string firstRow = new string(star, n + 1);
        Console.WriteLine(firstRow);

        int blanksSide = n / 2;
        int blanksMid = n - 1;

        for (int i = 0; i < n - 1; i++)
        {
            if (i <= n / 2)
            {
                string sideB = new string(' ', blanksSide);
                string midB = new string(' ', blanksMid);
                Console.WriteLine("{0}*{1}*{0}", sideB, midB);
            }
            else
            {
                blanksSide--;
                blanksMid += 2;
                string sideB = new string(' ', blanksSide);
                string midB = new string(' ', blanksMid);
                Console.WriteLine("{0}*{1}*{0}", sideB, midB);
            }
        }

        for (int i = 0; i < n; i++)
        {
            
            string blank = new string(' ', n - 1);


        }
        for (int i = 0; i < n; i++)
        {
            string dot = new string('.', n * 2 - 2);
            Console.WriteLine("{0}{1}{0}", star, dot);
        }
        for (int i = 0; i < n; i++)
        {
            string maimunka = new string('@', n * 2 - 2);
            Console.WriteLine("{0}{1}{0}", star, maimunka);
        }
        string lastRow = new string(star, n * 2);
        Console.WriteLine(lastRow);
    }
}
