using System;

namespace GoodPairs_Lab10Assign3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = ArrayHelper.ConsoleHelper.ReadNumberFromConsole("please write the length of the array: ", 5, 0);

            int[] array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = ArrayHelper.ConsoleHelper.ReadNumberFromConsole("Please write a number: ", 3, 0);
            }

            ArrayHelper.ConsoleHelper.PrintArray("The given array is: ", array);

            string noOfGoodPairs=ArrayHelper.ArrayHelper.NumberOfGoodPairsinArray(array);
            Console.WriteLine(noOfGoodPairs);
        }
    }
}
