using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class StrangeLandNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        //string input = "pNWEoBJECbINf";
        List<char> number = new List<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLower(input[i]))
            {
                number.Add(input[i]);
            }

        }
        StringBuilder sb = new StringBuilder();
        int sysBase = 7;
        for (int i = 0; i < number.Count; i ++)
        {
            switch (number[i])
            {
                case 'f': sb.Append('0'); break;
                case 'b': sb.Append('1'); break;
                case 'o': sb.Append('2'); break;
                case 'm': sb.Append('3'); break;
                case 'l': sb.Append('4'); break;
                case 'p': sb.Append('5'); break;
                case 'h': sb.Append('6'); break;
                //case "Psst": sb.Append('7'); break;
                //case "Uaah": sb.Append('8'); break;
                //case "Uaha": sb.Append('9'); break;
                //case "Zzzz": sb.Append('A'); break;
                //case "Bauu": sb.Append('B'); break;
                //case "Djav": sb.Append('C'); break;
                //case "Myau": sb.Append('D'); break;
                //case "Gruh": sb.Append('E'); break;
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