namespace MyNameSpace.genericNamespace
{
    class Generics
    {
        public T add<T>(T a, T b)
        {
            dynamic? x = a;
            dynamic? y = b;
            return x + y;
        }
        public void displayElemets<T>(T[] array)
        {
            foreach (T item in array)
            {
                System.Console.WriteLine(item + " ");
            }
        }

    }
}