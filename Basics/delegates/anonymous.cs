namespace MyNameSpace.delegateNamespace.anonymous
{
    class AnonymousDelegate
    {
        public delegate int PointToaddFunction(int num1, int num2);


        public static int add(int a, int b)
        {
            return a + b;
        }

    }
}