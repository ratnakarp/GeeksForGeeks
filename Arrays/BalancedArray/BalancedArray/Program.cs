using System;

namespace BalancedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            var count1 = 0;
            var count2 = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if (i < arr.Length /2)
                {
                    count1 += arr[i];
                }
                else
                {
                    count2 += arr[i];
                }
            }
            if (count1 < count2) {
                Console.WriteLine(count2 - count1);
            }
            else
            {
                Console.WriteLine(count1 - count2);
            }
        }
    }
}
