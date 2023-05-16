namespace MyNameSpace.array.matrixMul
{
    class MatrixMul
    {
        int i, j;

        public void GetArray(int[,] arr, int m, int n)
        {
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
        }

        public void displayMatrix(int m, int n, int[,] a)
        {
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    System.Console.Write(a[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        public void ProductofTwoMatrix(int m, int q,int n, int[,] a, int[,] b,int [,] c)
        {
           
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < q; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
        }
    }
}