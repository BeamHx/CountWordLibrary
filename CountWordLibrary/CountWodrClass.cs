using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordLibrary
{
    public class CountWodrClass
    {
        public static int WordCount(string textString, string word)
        {
            if(textString.Length < 2 || String.IsNullOrWhiteSpace(textString))
            {
                throw new Exception();
            }
                
            string[] arrayWords = textString.Split(' ');
            int count = 0;

            foreach (string item in arrayWords)
            {
                if(item == word)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
