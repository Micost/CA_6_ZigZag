using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_6_ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "PAYPALISHIRING";
            Solution s1 = new Solution();
            Console.Write(s1.Convert(input,3));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length <= numRows)
            {
                return s;
            }
            List<Char> sList = new List<char>();
            int j = 0; 
            int k = 0;
            sList.Add(s[0]);
            for (int i = 1; i < s.Length; i++ )
            {
                if ( j == 0 )
                {
                    sList.Add(s[i]);
                    k++;
                    if (k == numRows - 1)
                    {
                        j++;
                        k = 0;
                    }
                }
                else
                {
                    for ( int l = 0; l < numRows -2; l++)
                    {
                        sList.Add('\0');
                    }
                    j++;
                    sList.Add(s[i]);
                    if ( j == numRows )
                    {
                        j = 0; 
                    }
                }
            }
            string result = null;
            int t = 0;
            int r = 0;
            while(true)
            {
                if (t * numRows + r < sList.Count)
                {
                    char temp = sList[t * numRows + r];
                    t++;
                    if (temp != '\0')
                    {
                        result = result + temp;
                    }
                }
                else
                {
                    t = 0;
                    r++;
                }
                if (r == numRows)
                    break;

            }
            return result;
        }
    }
}
