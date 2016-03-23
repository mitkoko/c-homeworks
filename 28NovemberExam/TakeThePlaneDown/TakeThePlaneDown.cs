using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TakeThePlaneDown
{
    static void Main()
    {
        int headX = int.Parse(Console.ReadLine());
        int headY = int.Parse(Console.ReadLine());
        int distHeadToBorder = int.Parse(Console.ReadLine());
        int planes = int.Parse(Console.ReadLine());
        for (int i = 0; i < planes; i++)
        {
            int planeCoordX = int.Parse(Console.ReadLine());
            int planeCoordY = int.Parse(Console.ReadLine());
            if (planeCoordX <= headX + distHeadToBorder && planeCoordX >= headX - distHeadToBorder)
            {
                if (planeCoordY <= headY + distHeadToBorder && planeCoordY >= headY - distHeadToBorder)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeCoordX, planeCoordY);
                }
            }
        }
    }
}