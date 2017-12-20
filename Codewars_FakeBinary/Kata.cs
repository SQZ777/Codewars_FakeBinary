using System;
using System.Linq;

namespace Codewars_FakeBinary
{
    public class Kata
    {
        public string FakeBin(string input)
        {
            return input.ToCharArray().Aggregate(string.Empty, (current, c) => current + judgeChar(c));
        }

        private string judgeChar(char c)
        {
            return int.Parse(c.ToString()) < 5 ? "0" : "1";
        }
    }
}
