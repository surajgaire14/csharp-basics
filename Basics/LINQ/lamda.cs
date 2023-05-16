// lamda expression
// (input-parameters) = expression , for eg: sq = x => x * x;
// for more details see, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

namespace MyNameSpace.LamdaExpressionNamespace
{
    class LamdaExpression
    {
        delegate int del(int i);

        public void displaySquare(int x)
        {
            del sqDelegate = x => x * x;
            int result = sqDelegate(x);
            System.Console.WriteLine($"square of {x} is {result} ");
        }

        public void LINQWithLamdaExpression()
        {
            int[] scores = new int[] { 92, 85, 67, 82 };

            IEnumerable<int> scorequery = scores.Where(s => s > 80);

            System.Console.WriteLine("score greater than 80 are");
            foreach (int score in scorequery)
            {
                System.Console.WriteLine($"{score}");
            }
        }
    }
}