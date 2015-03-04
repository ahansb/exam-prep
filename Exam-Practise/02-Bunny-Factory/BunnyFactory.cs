using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BunnyFactory
{
    static void Main(string[] args)
    {
        //input
        string input = string.Empty;
        List<BigInteger> cages = new List<BigInteger>();
        while (input != "END")
        {
            input = Console.ReadLine();
            if (input != "END")
            {
                cages.Add(BigInteger.Parse(input));
            }
        }
        //calc
        int nTimes = 1;

        while (true)
        {
            BigInteger sum = 0;
            if (nTimes > cages.Count)
            {
                break;
            }
            for (int i = 0; i < nTimes; i++)
            {
                sum += cages[i];

            }
            if (sum > cages.Count)
            {
                break;
            }
            for (int i = 0; i < nTimes; i++)
            {

                cages.RemoveAt(0);
            }
            BigInteger sumTwo = 0;
            BigInteger product = 1;
            for (int i = 0; i < sum; i++)
            {
                sumTwo += cages[0];
                product *= cages[0];
                cages.RemoveAt(0);
            }
            ////insert product
            //while (product != 0)
            //{
            //    cages.Insert(0, (int)(product % 10));
            //    product = product / 10;
            //}
            ////insert sum
            //while (sumTwo != 0)
            //{
            //    cages.Insert(0, (int)sumTwo % 10);
            //    sumTwo = sumTwo / 10;
            //}

            //insert produt
            cages.Insert(0, product);
            cages.Insert(0, sumTwo);
            //removing 1 0
            List<string> kletki = new List<string>();
            foreach (var cage in cages)
            {
                kletki.Add(cage.ToString());

            }
            for (int i = 0; i < kletki.Count; i++)
            {
                for (int dig = 0; dig < kletki[i].Length; dig++)
                {
                    if ( kletki[i][dig]=='0'||kletki[i][dig]=='1')
                    {
                        kletki[i]=kletki[i].Remove(dig,1);
                    }
                }
            }
            for (int chislo = 0; chislo < kletki.Count; chislo++)
            {
                cages[chislo] = BigInteger.Parse(kletki[chislo]);
            }

            ////removing 1 0
            //cages.RemoveAll(x => x == 1);
            //cages.RemoveAll(x => x == 0);
            nTimes++;
        }
        //printing result
        string result = string.Join(" ", cages.Select(x => x.ToString()));
        Console.WriteLine(result);
    }

}