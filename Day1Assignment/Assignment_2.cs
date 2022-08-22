namespace Day1Assignment
{
    internal class Assignment_2
    {
        static void Main(string[] args)
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int minnmbr;
            if (m < n)
            {
                minnmbr = m;
            }
            else
            {
                minnmbr = n;
            }
            Console.WriteLine("Minimum number is: " + minnmbr);
            Console.ReadKey();
        }

    }
}
