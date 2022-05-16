using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public static class RomanToInt
    {
        private static readonly Dictionary<char, int> _numbers = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int FromRomanToInt(this string s)
        {
            var r = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var c = _numbers[s[i]];
                var n = (i == s.Length-1) ? 0 : _numbers[s[i+1]];

                if (c < n) r -= c;
                else if (c >= n) r += c;
            }

            return r;
        }
    }
}

