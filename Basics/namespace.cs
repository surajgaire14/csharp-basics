
/**
*   @Namespace Example
**/

namespace MyNameSpace.namespaces
{
    namespace firstNamespace
    {
        class sameClass
        {
            public void func()
            {
                Console.WriteLine("Inside second Namespace");
            }
        }
    }

    namespace secondNamespace
    {
        class sameClass
        {
            public void func()
            {
                Console.WriteLine("Inside first namespace");
            }
        }
    }
}