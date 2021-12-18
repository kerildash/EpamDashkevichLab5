using System;

namespace Ex2
{

    //calculate product of the array elements between first and last zero 

    class Program
    {
        // arrays for tests
        public static double[] _Array1 = { -66.80, 7.54, -70.79, 0, 36.60, -8.20, -93.12, 0, -10.63, 74.51 };
        public static double[] _Array2 = { -66.80, 0, -70.79, -62.06, 36.60, -8.20, -93.12, -91.31, -10.63, 74.51 };
        public static double[] _Array3 = { -66.80, 7.54, -70.79, -62.06, 36.60, -8.20, -93.12, -91.31, -10.63, 74.51 };
        public static double[] _Array4 = { -66.80, 0, -70.79, -62.06, 0, -8.20, -93.12, -91.31, 0, 74.51 };
        public static double[] _Array5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static double[] _Array6 = { -66.80, 7.54, -70.79, -62.06, 36.60, -8.20, -93.12, -91.31, -10.63, 74.51 };
        public static double[] _Array7 = { -66.80 };
        public static double[] _Array8 = { };
        public static double[] _Array9;
        static void Main(string[] args)
        {
            //check how method works with every array
            double[][] arrays = { _Array1, _Array2, _Array3, _Array4, _Array5, _Array6, _Array7, _Array8, _Array9 };
            foreach (double[] array in arrays)
            {
                try
                {
                    Console.WriteLine(ProductOfElementsBetweenZeros(array));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static double ProductOfElementsBetweenZeros(double[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException("Array is Null");
            }
            if (array.Length <= 2) // no elements => no zeros
                                   // need for two zeros, so 1-2 elements => no elements between zeros (if zeros even exist)
            {
                throw new Exception("Array with no data to handle");
            }
            int IndexOfFirstZero = Array.FindIndex(array, x => x == 0);
            int IndexOfLastZero = Array.FindLastIndex(array, x => x == 0);
            if( IndexOfFirstZero == -1 || IndexOfLastZero == IndexOfFirstZero
                || IndexOfLastZero == IndexOfFirstZero + 1)
            {
                throw new Exception("Array with no data to handle");
            }
            int betweenZerosLength = (IndexOfLastZero - 1) - (IndexOfFirstZero + 1) + 1;
            double[] betweenZeros = new double[betweenZerosLength];
            Array.Copy(array, IndexOfFirstZero + 1, betweenZeros, 0, betweenZerosLength);

            double product = 1;
            if (Array.FindIndex(betweenZeros, x => x == 0) != -1)
            {
                return product = 0; // 0 in array => prod. = 0 
            }
            foreach (double number in betweenZeros)
            {
                product *= number;
            }
            return product;
        }
    }
}
