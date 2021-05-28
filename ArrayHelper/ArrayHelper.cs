using System;

namespace ArrayHelper
{
    public static class ArrayHelper
    {
        public static string NumberOfGoodPairsinArray(int[] array)
        {
            int noOfGoodPairs = 0;
            string IndexesofGoodPairs = " The indexes of the good pairs are: ";

            for(int i =0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        noOfGoodPairs++;
                        IndexesofGoodPairs = string.Concat(IndexesofGoodPairs,$"({i},{j}), ");
                    }
                }
            }

            return string.Concat(noOfGoodPairs.ToString(), IndexesofGoodPairs);
        }
    }
}
