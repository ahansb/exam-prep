using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class TwoGirlsOnePath
{
    static void Main(string[] args)
    {
        //string input = "9000000000000000001 9000000000000000001 9000000000000000001 9000000000000000001 1 1 1 1";
        string input = Console.ReadLine();
        
        BigInteger[] numbers = input.Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

        long mCurPos = 0;
        long dCurPos = numbers.Length-1;

        BigInteger mFlowers = 0;
        BigInteger dFlowers = 0;

        BigInteger curFlower = 0;
        int devider = numbers.Length;
        bool areFlow = true;
        
        while (areFlow)
        {
            

            if (numbers[mCurPos] == 0 || numbers[dCurPos] == 0)
            {
                areFlow = false;

                if (numbers[mCurPos] == 0 && numbers[dCurPos] != 0)
                {

                    Console.WriteLine("Dolly");
                }
                else if (numbers[mCurPos] != 0 && numbers[dCurPos] == 0)
                {
                    Console.WriteLine("Molly");
                }
                else if (numbers[mCurPos] == 0 && numbers[dCurPos] == 0)
                {
                    Console.WriteLine("Draw");
                }
            }
            if (mCurPos == dCurPos)
            {
                curFlower = numbers[mCurPos];
                if (numbers[mCurPos] % 2 == 0)
                {
                    mFlowers += (numbers[mCurPos] / 2);
                    dFlowers += (numbers[mCurPos] / 2);
                    numbers[mCurPos] = 0;
                }
                else
                {
                    mFlowers += ((numbers[mCurPos] -1) / 2);
                    dFlowers += ((numbers[mCurPos]-1) / 2);
                    numbers[mCurPos] = 1;
                }

                mCurPos = (long)(mCurPos + curFlower) % devider;
                dCurPos -= (long)curFlower;
                if (dCurPos < 0)
                {
                    dCurPos = numbers.Length + (dCurPos % devider);
                }
            }
            else
            {
                curFlower = numbers[mCurPos];
                mFlowers += curFlower;
                numbers[mCurPos] = 0;
                mCurPos = (long)(mCurPos + curFlower) % devider;

                curFlower = numbers[dCurPos];
                dFlowers += curFlower;

                numbers[dCurPos] = 0;
                dCurPos -= (long)curFlower;
                if (dCurPos < 0)
                {
                    dCurPos = numbers.Length + (dCurPos % devider);
                }
            }
            


        }
        

        Console.WriteLine("{0} {1}",mFlowers,dFlowers);
    }
}