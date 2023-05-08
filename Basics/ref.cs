namespace MyNameSpace.RefNamespace
{
    class RefExample
    {
        public void getSwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}