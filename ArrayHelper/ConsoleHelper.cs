using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    public static class ConsoleHelper
    {
        public static int ReadNumberFromConsole(string label, int maxAttempts, int defaultValue)
        {
            label = label ?? "Please enter a number";

            int attempts = 0;
            while (attempts <= maxAttempts)
            {
                Console.WriteLine(label);
                string value = Console.ReadLine();

                if(int.TryParse(value, out int result))
                {
                    return result;
                }

                attempts++;
                Console.WriteLine($"{value} is not a number! You have {maxAttempts - attempts} attempts left!");
            }

            return defaultValue;
        }

        public static void PrintArray( string label ,int[] array)
        {
            label = label ?? "The array is: ";
            string resultedArray = string.Join(", ", array ?? new int[0]);
            Console.WriteLine($"{label} {resultedArray}");
        }
    }
}
