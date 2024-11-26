namespace Week_3_Challenge_Labs._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumLength("ABFCACDB")); 
            Console.WriteLine(MinimumLength("ACBBD"));
        }

        static int MinimumLength(string s)
        {
            bool foundSubstrings = true;

            while (foundSubstrings)
            {
                string newString = s.Replace("AB", "").Replace("CD", "");

                if (newString == s)
                {
                    foundSubstrings = false;
                }
                else
                {
                    s = newString;
                }
            }

            return s.Length;
        }
    }
}
