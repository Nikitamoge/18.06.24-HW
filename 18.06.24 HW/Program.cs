using System.Linq;
namespace _18._06._24_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.Write("Enter the sum from 1 up to 9999: ");
            //int amount = Convert.ToInt32(Console.ReadLine());

            //if (amount < 1 || amount > 9999) 
            //{
            //    Console.WriteLine("Error!");
            //    return;
            //}

            //string currency = "Euro";
            //if (amount % 10 == 1 && amount % 100 != 11)
            //{
            //    currency += "";
            //}
            //else if (amount % 10 >= 2 && amount % 10 <= 4 && (amount % 100 < 10 || amount % 100 >= 20))
            //{
            //    currency += "o";
            //}
            //else
            //{
            //    currency += "s";
            //}

            //Console.WriteLine($"{amount} {currency}");


            //Task 2
            //Console.Write("Enter your number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool isPrime = number >= 2 && Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(i => number % i != 0);

            //Console.WriteLine(isPrime ? $"{number}: is a prime number." : $"{number}: is not a prime number.");


            //Task 3
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Numbers reversed: ");
            //while (number > 0)
            //{
            //    Console.Write(number % 10 + " ");
            //    number /= 10;
            //}


            //Task 4
            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    int originalNumber, remainder, result = 0, n = 0;
            //    originalNumber = number;

            //    while (originalNumber != 0)
            //    {
            //        originalNumber /= 10;
            //        ++n;
            //    }

            //    originalNumber = number;

            //    for (; originalNumber != 0; originalNumber /= 10)
            //    {
            //        remainder = originalNumber % 10;
            //        result += (int)Math.Pow(remainder, n);
            //    }

            //    if (result == number)
            //        Console.WriteLine($"{number}: Is an Armstrong number.");
            //    else
            //        Console.WriteLine($"{number} - Is not an Armstrong number.");
            //}


            //Task 5
            Console.Write("Enter the interest rate: ");
            double P = Convert.ToDouble(Console.ReadLine());

            double deposit = 10000;
            int K = 0;

            while (deposit <= 11000)
            {
                deposit += deposit * P / 100;
                K++;
            }

            Console.WriteLine($"After {K}months the deposit amount will exceed UAH 11000 and will amount to {deposit:F2} UAH.");
        }
    }
}