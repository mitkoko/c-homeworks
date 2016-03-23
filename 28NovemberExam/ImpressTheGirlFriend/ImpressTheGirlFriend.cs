using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ImpressTheGirlFriend
{
    static void Main()
    {
        uint r = uint.Parse(Console.ReadLine()); //rubli
        uint d = uint.Parse(Console.ReadLine()); //dolari
        uint e = uint.Parse(Console.ReadLine()); //euro
        uint b = uint.Parse(Console.ReadLine()); //special offer B
        uint m = uint.Parse(Console.ReadLine()); //M site

        double rublInLev = (r / 100) * 3.5;
        double dollaInLev = d * 1.5;
        double euroInLev = e * 1.95;
        double bOffer = b / 2;
        string zeros = ".00";

        if (rublInLev > dollaInLev && rublInLev > euroInLev && rublInLev > bOffer && rublInLev > m)
        {
            Console.WriteLine(Math.Ceiling(rublInLev) + zeros);
        }
        else if (dollaInLev > rublInLev && dollaInLev > euroInLev && dollaInLev > bOffer && dollaInLev > m)
        {
            Console.WriteLine(Math.Ceiling(dollaInLev) + zeros);
        }
        else if (euroInLev > rublInLev && euroInLev > dollaInLev && euroInLev > bOffer && euroInLev > m)
        {
            Console.WriteLine(Math.Ceiling(euroInLev) + zeros);
        }
        else if (bOffer > rublInLev && bOffer > dollaInLev && bOffer > euroInLev && bOffer > m)
        {
            Console.WriteLine(Math.Ceiling(bOffer) + zeros);
        }
        else
        {
            Console.WriteLine(m + zeros);
        }
    }
}