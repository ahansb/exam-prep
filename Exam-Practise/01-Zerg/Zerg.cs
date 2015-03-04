using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "TELERIK-ACADEMY";
        StringBuilder sb = new StringBuilder();
        int howManyLetters = 4;
        int sysBase = 15;
        for (int i = 0; i < input.Length; i += howManyLetters)
        {
            switch (input.Substring(i, howManyLetters))
            {
                case "Rawr": sb.Append('0'); break;
                case "Rrrr": sb.Append('1'); break;
                case "Hsst": sb.Append('2'); break;
                case "Ssst": sb.Append('3'); break;
                case "Grrr": sb.Append('4'); break;
                case "Rarr": sb.Append('5'); break;
                case "Mrrr": sb.Append('6'); break;
                case "Psst": sb.Append('7'); break;
                case "Uaah": sb.Append('8'); break;
                case "Uaha": sb.Append('9'); break;
                case "Zzzz": sb.Append('A'); break;
                case "Bauu": sb.Append('B'); break;
                case "Djav": sb.Append('C'); break;
                case "Myau": sb.Append('D'); break;
                case "Gruh": sb.Append('E'); break;
            }
        }
        Console.WriteLine(ConvertAnyToDec(sb.ToString(), sysBase));
    }
    static BigInteger ConvertAnyToDec(string hexadec, int sBase)
    {
        BigInteger numberDec = 0;

        int j = 0;
        BigInteger digit = 0;
        for (int i = hexadec.Length - 1; i >= 0; i--)
        {
            switch (hexadec[i])
            {
                case '0': digit = hexadec[i] - '0'; break;
                case '1': digit = hexadec[i] - '0'; break;
                case '2': digit = hexadec[i] - '0'; break;
                case '3': digit = hexadec[i] - '0'; break;
                case '4': digit = hexadec[i] - '0'; break;
                case '5': digit = hexadec[i] - '0'; break;
                case '6': digit = hexadec[i] - '0'; break;
                case '7': digit = hexadec[i] - '0'; break;
                case '8': digit = hexadec[i] - '0'; break;
                case '9': digit = hexadec[i] - '0'; break;
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
            }
            numberDec += digit * (BigInteger)Math.Pow(sBase, j);
            ++j;
        }
        return numberDec;
    }
}