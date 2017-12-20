using System;

namespace Codewars_FakeBinary
{
    public class Kata
    {
        public string FakeBin(string input)
        {
            var inputArray = input.ToCharArray();
            var result = string.Empty;
            foreach (var c in inputArray)
            {
                result += judgeChar(c);
            }
            return result;
        }

        private string judgeChar(char c)
        {
            return int.Parse(c.ToString()) < 5 ? "0" : "1";
        }
    }
}
