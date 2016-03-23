using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AceOfDiamonds
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string border = new string('*', number);
        Console.WriteLine(border);

        for (int i = 0; i < (number - 2) / 2; i++)
        {
            string sides = new string('-', ((number - 2) / 2) - i);
            string klyombi = new string('@', 1 + (i * 2));
            Console.WriteLine("*{0}{1}{0}*", sides, klyombi);
        }
        string middle = new string('@', number - 2);
        Console.WriteLine('*' + middle + '*');

        for (int i = 1; i <= (number - 2) / 2; i++)
        {
            string sides = new string('-', i);
            string klyombi = new string('@', number - 2 - (i * 2));
            Console.WriteLine("*{0}{1}{0}*", sides, klyombi);
        }
        Console.WriteLine(border);
    }
}
