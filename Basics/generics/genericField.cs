namespace MyNameSpace.genericNamespace.genericField
{
    class GenericClassForField<T>
    {
        // private T[] data = new T[5];

        public void showData(T[] data)
        {
            foreach (T t in data)
            {
                System.Console.WriteLine($"{t}");
            }
        }
    }
}