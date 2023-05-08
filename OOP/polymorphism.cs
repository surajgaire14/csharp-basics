namespace MyNameSpace.PolymorphismNamespace
{
/*  
* @polymorphism - having many forms
*/

    // Static polymorphism
    class PrintData
    {
        public void print()
        {
            System.Console.WriteLine("Print method");
        }

        public void print(int a)
        {
            System.Console.WriteLine("int : {0}", a);
        }

        public void print(string a)
        {
            System.Console.WriteLine("string :{0}", a);
        }
    }
}