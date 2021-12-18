using System;

namespace Ex3
{
    //in matrix, count number of columns with zeros
    
    class Program
    {

        //matrices for test

        //no zeros
        //expected: 0
        public static double[,] _Matrix1 =
        {
            { -2.84, 1.16, 9.53, -0.71, 2.79, 2.76, -7.21},
            { 4.77, 0.63, -7.94, 7.45, 1.17, -6.06, 8.40},
            { -5.12, 8.42, -3.38, -8.71, -1.46, 9.96, -0.27},
            { -0.58, -7.21, 8.62, 3.39, 6.67, -3.49, -1.16},
            { -7.53, 9.42, -1.63, 3.47, 0.59, 6.43, 0.46}
        };

        //some zeros
        //expected: 2
        public static double[,] _Matrix2 =
        {
            { -5.94,  6.68,  3.72,     0 },
            {  1.07,     0,  4.14, -1.85 },
            {  3.92, -0.64, -9.96,  1.36 }
        };

        //zeros in every column
        //expected: 4
        public static double[,] _Matrix3 =
        {
            {     0,  6.68,  3.72,     0 },
            {  1.07,     0,     0, -1.85 },
            {     0, -0.64, -9.96,  1.36 }
        };

        //expected: 4
        public static double[,] _Matrix4 =
        {
            {     0,     0,     0,     0 },
            {     0,     0,     0,     0 },
            {     0,     0,     0,     0 }
        };

        //expected: 0
        public static double[,] _Matrix5 =
        {
            {  1.07 }
        };

        //expected: 1
        public static double[,] _Matrix6 =
        {
            {     0 }
        };

        //expected: Empty matrix
        public static double[,] _Matrix7 =
        {
            {       }
        };

        //expected: Matrix is Null
        public static double[,] _Matrix8;

        static void Main(string[] args)
        {
            //check how method works with every array
            double[][,] matrices = { _Matrix1, _Matrix2, _Matrix3, _Matrix4, _Matrix5, _Matrix6, _Matrix7, _Matrix8 };
            foreach (double[,] matrix in matrices)
            {
                try
                {
                    Console.WriteLine(NumberOfColumnsWithZero(matrix));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static double NumberOfColumnsWithZero(double[,] matrix)
        {
            if (matrix == null)
            {
                throw new NullReferenceException("Matrix is Null");
            }
            if (matrix.Length == 0)
            {
                throw new Exception("Empty matrix");
            }
            int zeroedColumns = 0;

            for (int j = 0; j <= matrix.GetUpperBound(1); j++)
            {
                bool isZeroed = false;
                for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                {
                    
                    if (matrix[i,j] == 0)
                    {
                        isZeroed = true;
                    }
                }
                if (isZeroed)
                {
                    zeroedColumns++;
                }
            }

            return zeroedColumns;
        }
    }
}
