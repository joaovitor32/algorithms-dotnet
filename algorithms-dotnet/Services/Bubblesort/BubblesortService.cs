using System;
using System.Reflection;
using algorithms_dotnet.Utils;

namespace algorithms_dotnet.Services.Bubblesort
{
    public class BubblesortService : IBubblesortService
    {
        public int[] Sort(int[] array)
        {
            for (int index = 0; index < array.Length - 1; index++)
            {
                for (int j = 0; j < array.Length - index - 1; j++)
                {
                    if (Utilities.checkIfIsBigger(array[j], array[j + 1]))
                    {
                        array = Utilities.swap(array, j);
                    }
                }
            }

            return array;
        }
    }
}
