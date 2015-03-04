using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicWords
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }
        for (int i = 0; i < words.Count; i++)
        {
            string word = words[i];
            int newPos= words[i].Length % (n + 1);
            words[i] = null;
            
            words.Insert( newPos,word );
            words.Remove(null);
        }
        int bestLenghtWord = 0;
        for (int i = 0; i < words.Count; i++)
        {
            if (bestLenghtWord<words[i].Length)
            {
                bestLenghtWord = words[i].Length;
            }
        }
        var sb = new StringBuilder();
        for (int i = 0; i <bestLenghtWord; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                if (i<words[j].Length)
                {
                    sb.Append(words[j][i]);
                }
                
            }   
        }
        Console.WriteLine(sb);

    }
}