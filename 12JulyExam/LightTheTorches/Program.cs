using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        char[] rooms = new char[int.Parse(line)];
        int currPosition = rooms.Length / 2;
        line = Console.ReadLine();
        int index = 0;

        while (true)
        {
            foreach (char ch in line)
            {
                rooms[index] = ch;
                index++;
                if (rooms[rooms.Length - 1] > 0)
                {
                    break;
                }
            }
            if (rooms[rooms.Length - 1] > 0)
            {
                break;
            }
        }

        line = Console.ReadLine();

        while (line != "END")
        {
            string[] command = line.Split(' ');
            int steps = int.Parse(command[1]);
            bool check = true;
            if (command[0] == "LEFT")
            {

                if (0 > currPosition - steps - 1)
                {
                    check = currPosition != 0;
                    currPosition = 0;
                }
                else
                {
                    currPosition -= (steps + 1);
                }
            }
            else
            {
                if (rooms.Length - 1 < currPosition + steps + 1)
                {
                    check = currPosition != rooms.Length - 1;
                    currPosition = rooms.Length - 1;
                }
                else
                {
                    currPosition += (steps + 1);
                }
            }
            if (check)
            {
                if (rooms[currPosition] == 'L')
                {
                    rooms[currPosition] = 'D';
                }
                else
                {
                    rooms[currPosition] = 'L';
                }
            }

            line = Console.ReadLine();
        }
        int numberOfD = 0;
        foreach (char ch in rooms)
        {
            if (ch == 'D')
            {
                numberOfD++;
            }
        }
        Console.WriteLine('D' * numberOfD);
    }
}