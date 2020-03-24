using System;
using System.Linq;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 =  Console.ReadLine();
            var input1Array = input1.Split(' ');
            int arraySize = Convert.ToInt32(input1Array[0]);
            int numberOfElementsToBeRotated = Convert.ToInt32(input1Array[1]);

            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] copiedArray = new int[initialArray.Length];

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (i < numberOfElementsToBeRotated)
                {
                    copiedArray[i] = initialArray[i];
                }
                if (numberOfElementsToBeRotated + i < initialArray.Length)
                {
                    initialArray[i] = initialArray[numberOfElementsToBeRotated + i];
                }
            }
            for (int i = 0; i < numberOfElementsToBeRotated; i++)
            {
                initialArray[(initialArray.Length -  numberOfElementsToBeRotated) + i] = copiedArray[i];
            }
            for(int i=0;i<initialArray.Length;i++)
            {
                Console.Write(initialArray[i]);
                Console.Write(' ');
            }
        }
    }
}
