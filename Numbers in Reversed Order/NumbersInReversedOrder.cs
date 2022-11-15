namespace Numbers_in_Reversed_Order
{
    internal class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            var num = decimal.Parse(Console.ReadLine());

            var reversedNum = reversedNumDigits(num);
            Console.WriteLine(reversedNum);
        }

         static decimal reversedNumDigits(decimal num)
        {
           var numToString = num.ToString();

            var result = string.Empty;

            for (int i = numToString.Length -1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);
        }
    }
}