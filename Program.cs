using System;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 5, 17, 25, 38, 44 };
            int low = 0;
            int searched = 38;
            int high = numbers.Length - 1;
            int mid;
            while (low <= high)
                
            {
                mid = (low + high) / 2;
                if (searched == numbers[mid])
                {
                    Console.WriteLine("Aranan değer dizinin {0}.elemanıdır", mid);
                    break;
                }

                else if (searched < numbers[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            Console.ReadKey();

        }
    }
}
