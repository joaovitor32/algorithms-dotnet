namespace algorithms_dotnet.Utils
{
    public static class Utilities
    {
        public static int[] swap(int[] array, int index)
        {
            var oldValue = array[index];
            array[index] = array[index + 1];
            array[index + 1] = oldValue;
            return array;
        }
        public static bool checkIfIsBigger(int a, int b)
        {
            return a > b;
        }
    }
}
