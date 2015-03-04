using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class TRES4Numbers
{
    static void Main(string[] args)
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        BigInteger sysBase = 9;
        Console.WriteLine(ConvertDecToAny(input, sysBase));
    }
    static string ConvertDecToAny(BigInteger numberDec, BigInteger dBase)
    {
        List<string> toAny = new List<string>();
        if (numberDec == 0)
        {
            toAny.Add("LON+");
        }
        else
        {


            while (numberDec > 0)
            {
                switch ((numberDec % dBase).ToString())
                {
                    case "0": toAny.Add("LON+"); break;
                    case "1": toAny.Add("VK-"); break;
                    case "2": toAny.Add("*ACAD"); break;
                    case "3": toAny.Add("^MIM"); break;
                    case "4": toAny.Add("ERIK|"); break;
                    case "5": toAny.Add("SEY&"); break;
                    case "6": toAny.Add("EMY>>"); break;
                    case "7": toAny.Add("/TEL"); break;
                    case "8": toAny.Add("<<DON"); break;
                    //case 9: toAny.Add('9'); break;
                    //case 10: toAny.Add('A'); break;
                    //case 11: toAny.Add('B'); break;
                    //case 12: toAny.Add('C'); break;
                    //case 13: toAny.Add('D'); break;
                    //case 14: toAny.Add('E'); break;
                    //case 15: toAny.Add('F'); break;

                }
                numberDec /= dBase;
            }
        }
        toAny.Reverse();
        string any = string.Join("", toAny).ToString();
        return any;
    }
}