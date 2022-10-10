using System;
using System.Linq;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        {
            string result = String.Empty;
            
            for (int i = 0; i < str.Length; i +=2)
            {
                for (int j =0; j < Char.GetNumericValue(str[i+1]);j++)
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}
