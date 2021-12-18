using System;

namespace Ex1
{

    // calculate sum of array elements with odd indices
    class Program
    {
        //4 arrays for tests
        public static double[] _Array1 = { -66.80, 7.54, -70.79, -62.06, 36.60, -8.20, -93.12, -91.31, -10.63, 74.51 };
        public static double[] _Array2 = { -66.80 };
        public static double[] _Array3 = { };
        public static double[] _Array4;

        static void Main(string[] args)
        {
            //check how method works with every array
            double[][] arrays = { _Array1, _Array2, _Array3, _Array4 };
            foreach (double[] array in arrays)
            {
                try
                {
                    Console.WriteLine(OddIndexedElementsSum(array));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }
        static double OddIndexedElementsSum(double[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException("Array is Null");
            }
            if (array.Length <= 1) // no elements => no odd-indexed elements
                                   // 1 element is 0st => no odd-indexed elements
            {
                throw new Exception("No odd-indexed elements");
            }
            
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
