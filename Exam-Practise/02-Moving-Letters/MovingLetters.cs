using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MovingLetters
{
    static void Main()
    {
        string input = "Fun exam right";
        List<string> words = new List<string>();
        words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        int wordBestLenght = 0;
        for (int i = 0; i < words.Count; i++)
        {
            if (wordBestLenght < words[i].Length)
            {
                wordBestLenght = words[i].Length;
            }

        }



        StringBuilder sb = new StringBuilder();

        for (int let = 0; let < wordBestLenght; let++)
        {
            for (int i = 0; i < words.Count; i++)
            {
                int index = words[i].Length - 1 - let;

                if (index>=0)
                {
                    sb.Append(words[i][index]);
                }
            }
        }
        // moving
        for (int i = 0; i < sb.Length; i++)
        {
            char letter = sb[i];
            int ind = char.ToLower(letter)+ 1 - 'a';
            
            
            sb.Remove(i, 1);
            int position = ind  % (sb.Length );
            sb.Insert(position, letter);
        }


    }
}