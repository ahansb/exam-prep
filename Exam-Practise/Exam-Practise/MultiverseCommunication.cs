using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MultiverseComm
{
    class MultiverseCommunication
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "TELERIK-ACADEMY";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i+=3)
            {
                switch (input.Substring(i, 3))
                {
                    case "CHU": sb.Append('0'); break;
                    case "TEL": sb.Append('1'); break;
                    case "OFT": sb.Append('2'); break;
                    case "IVA": sb.Append('3'); break;
                    case "EMY": sb.Append('4'); break;
                    case "VNB": sb.Append('5'); break;
                    case "POQ": sb.Append('6'); break;
                    case "ERI": sb.Append('7'); break;
                    case "CAD": sb.Append('8'); break;
                    case "K-A": sb.Append('9'); break;
                    case "IIA": sb.Append('A'); break;
                    case "YLO": sb.Append('B'); break;
                    case "PLA": sb.Append('C'); break;
                }
            }
            Console.WriteLine(ConvertAnyToDec(sb.ToString(),13));
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
}
