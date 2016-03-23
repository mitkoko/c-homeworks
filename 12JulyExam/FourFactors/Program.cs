using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FourFactors
{
    static void Main()
    {
        double FG = double.Parse(Console.ReadLine()); //field goals
        double FGA = double.Parse(Console.ReadLine()); //field goals attempts
        double threeP = double.Parse(Console.ReadLine()); // 3point field goals
        double TOV = double.Parse(Console.ReadLine()); // turnovers
        double ORB = double.Parse(Console.ReadLine()); // offensive rebounds
        double oppDRB = double.Parse(Console.ReadLine()); // opponent defensive rebounds
        double FT = double.Parse(Console.ReadLine()); //free throws
        double FTA = double.Parse(Console.ReadLine()); //free throw attempts

        double eFGPerc = ((FG + (0.5 * threeP)) / FGA) ; //effective field goals percent
        double TOVPerc = (TOV / (FGA + (0.44 * FTA) + TOV)); // turnover percentage
        double ORBPerc = (ORB / (ORB + oppDRB));
        double FTPerc = (FT / FGA);

        Console.WriteLine("eFG% {0:f3}", eFGPerc);
        Console.WriteLine("TOV% {0:f3}", TOVPerc);
        Console.WriteLine("ORB% {0:f3}", ORBPerc);
        Console.WriteLine("FT% {0:f3}", FTPerc);
    }
}
