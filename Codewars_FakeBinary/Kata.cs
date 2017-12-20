using System;

namespace Codewars_FakeBinary
{
    public class Kata
    {
        public string FakeBin(string input)
        {
            if (input.Equals(string.Empty))
            {
                return input;
            }
            if (int.Parse(input) >= 5)
            {
                return "1";
            }
            return input;
        }
    }
}
