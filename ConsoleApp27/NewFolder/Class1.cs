using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27.NewFolder
{
   public static class Class1
    {
        public static bool Word(this string word)
        {
            string[] letter = word.Split(' ');

            if (word == "")
            {
                return false;
            }
            for (int i = 0; i < letter.Length; i++)
            {
                if (i == 0)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
