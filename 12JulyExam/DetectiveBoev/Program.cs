using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string mask = Console.ReadLine();
        string secretMessage = Console.ReadLine();

        int result = 0;
        int maskNum = 0;
        int secrMessNum = 0;

        char[] maskArray = mask.ToCharArray();

        for (int i = 0; i < maskArray.Length; i++)
        {
            maskNum += int.Parse(((int)maskArray[i]).ToString());
        }

        if (maskNum > 9 )
        {
            int firstDigit = maskNum % 10;

            int restNumberTwo = maskNum / 10;
            int secondDigit = restNumberTwo % 10;

            int restNumberThree = maskNum / 100;
            int thirdDigit = restNumberThree % 10;

            int restNumberFour = maskNum / 1000;
            int fourthDigit = restNumberFour % 10;

            maskNum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            if (maskNum > 9)
            {
                firstDigit = maskNum % 10;

                restNumberTwo = maskNum / 10;
                secondDigit = restNumberTwo % 10;

                maskNum = firstDigit + secondDigit;
            }
        }
        char[] secretMessageArray = secretMessage.ToCharArray();


        for (int i = secretMessageArray.Length - 1; i >= 0; i--)
        {
            secrMessNum = int.Parse(((int)secretMessageArray[i]).ToString());

            if (secrMessNum % maskNum == 0)
            {
                result = secrMessNum + maskNum;
                Console.Write((char)result);
            }
            else
            {
                result = secrMessNum - maskNum;
                Console.Write((char)result);
            }
        }
    }
}