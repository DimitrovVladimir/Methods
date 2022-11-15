namespace Primes_in_Given_Range
{
    internal class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var primes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(String.Join(", ", primes));
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currendNum = startNum; currendNum < endNum; currendNum++)
            {
                if (IsPrime(currendNum))
                {
                    primes.Add(currendNum);
                }
            }
            return primes;
        }

        static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }

            for (int currentNum = 2; currentNum < num; currentNum++)
            {
                if (num % currentNum == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }

}