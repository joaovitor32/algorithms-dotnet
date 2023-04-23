using System;
using System.Reflection;

namespace algorithms_dotnet.Services.InsertionSort
{
    public class InsertionService : IInsertionService
    {
        public int[] Sort(int[] array)
        {
            for (int index = 0; index < array.Length - 1; index++)
            {
                int key = array[index];
                int j = index - 1;
                while (j >=0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            return array;
        }
    }
}
