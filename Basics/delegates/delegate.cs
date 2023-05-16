namespace MyNameSpace.delegateNamespace
{
    class Delegates
    {
        public delegate void stringDelegate(string text);

        public static void ToUpperCase(string text) => System.Console.WriteLine(text.ToUpper());

        public delegate void addDelegate(int a, int b);

        public delegate void stringDel(string s);
        public void sum(int x, int y)
        {
            System.Console.WriteLine("sum of two number is {0}", x + y);
        }
        public void Hello(string s)
        {
            System.Console.WriteLine($"Hello , {s}");
        }
        public void GoodBye(string s)
        {
            System.Console.WriteLine($"GoodBye , {s}");
        }
    }
}