namespace Prime_Checker
{
    internal class PrimeChecker
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());

            var isPrime = IsPrime(num);
            Console.WriteLine(isPrime);
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
                if(num % currentNum == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
            
    }
}