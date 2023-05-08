namespace MyNameSpace.PartialClassNamespace
{
    /*
* @ Partial class - split the definition of class, struct or interface
*/
    public partial class PartialClass
    {
        private int x, y;

        public PartialClass(int a, int b)
        {
            this.x = a;
            this.y = b;
        }
    }
    public partial class PartialClass
    {
        public void print()
        {
            System.Console.WriteLine("x  = {0}, y = {1}", x, y);
        }
    }
}