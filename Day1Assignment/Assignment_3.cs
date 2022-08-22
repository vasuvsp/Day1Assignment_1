
namespace Day1Assignment
{
    internal class Assignment_3
    {
        public static bool isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'E' ||
                    ch == 'I' || ch == 'O' ||
                                  ch == 'U');
        }
        public static int countVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            string str = "abc de";
            Console.WriteLine(countVowels(str));
        }

    }
}
