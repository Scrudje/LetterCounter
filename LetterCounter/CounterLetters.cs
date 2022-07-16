using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    public static class CounterLetters
    {
        public static int Count(string text, string dict)
        {
            int count = 0;
            foreach (var item in text)
            {
            if (dict.Contains(item)) count++;
            }

            return count;
        }


    }
}
