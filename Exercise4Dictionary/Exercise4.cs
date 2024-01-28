using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise4Dictionary
{
    internal class Exercise4
    {
        public static Dictionary<string, int> WordCounter(string text)
        {
            string cleanedText = Regex.Replace(text, @"[^\w\s]", "").ToLower();

            string[] words = cleanedText.Split();

            Dictionary<string, int> wordCounted = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounted.ContainsKey(word))
                {
                    wordCounted[word]++;
                }
                else
                {
                    wordCounted.Add(word, 1);
                }
            }

            return wordCounted;
        }
    }
}
