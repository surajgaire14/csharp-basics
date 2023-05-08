/* 
* @ Interfaces 
*/

namespace MyNameSpace.interfaceExample
{
    class Interfaces
    {
        interface IinterfaceSample
        {
            void display();
        }
        interface Ianotherinterface
        {
            void getValue();
        }
        class SampleClass : IinterfaceSample
        {
            public void display()
            {
                Console.WriteLine("method defined in interface");
            }
        }

        // multiple inheritance
        class AnotherSampleClass : Ianotherinterface, IinterfaceSample
        {
            public void getValue()
            {
                Console.WriteLine("Method from another interface");
            }

            public void display()
            {
                Console.WriteLine("Method from sample interface");
            }
        }
    }
}