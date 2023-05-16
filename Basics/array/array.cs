using MyNameSpace.array.matrixMul;

namespace MyNameSpace.array
{
    class Array
    {

        public void GetArray(string[] names)
        {
            System.Console.WriteLine("give user inputs:");
            for (int i = 0; i < names.Length; i++)
            {
                // ! is to specifies that console.readline doesnot return null, for more details see, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference
                names[i] = Console.ReadLine()!;
            }
        }

        public void displayNames(string[] names)
        {
            System.Console.WriteLine($"given user input names are:");
            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine($"{names[i]}\n");
            }
        }

        public void MatrixMultiplication()
        {
            int m, n, p, q;

            System.Console.WriteLine("Enter the rows and column of first Matrix:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the rows and column of second Matrix:");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[m, n];
            int[,] b = new int[p, q];

            MatrixMul ml = new MatrixMul();
            System.Console.WriteLine("Enter first matrix:");
            ml.GetArray(a, m, n);

            System.Console.WriteLine("Enter second Matrix");
            ml.GetArray(b, p, q);

            System.Console.WriteLine("first Matrix:");
            ml.displayMatrix(m, n, a);

            System.Console.WriteLine("second Matrix:");
            ml.displayMatrix(p, q, b);

            if (n != p)
            {
                System.Console.WriteLine("Matrix multiplication is not possible");
            }
            else
            {
                int[,] c = new int[m, q];
                ml.ProductofTwoMatrix(m, q, n, a, b, c);
                System.Console.WriteLine("product of two matrix is:");
                ml.displayMatrix(m, n, c);
            }
        }


    }
}