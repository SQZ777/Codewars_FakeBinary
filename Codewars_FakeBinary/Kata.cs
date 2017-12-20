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
                if (int.Parse(c.ToString()) < 5)
                {
                    result += 0;
                }
            }
            return result;
        }
    }
}
