using MyNameSpace.constructors;
using MyNameSpace.constructors.privateConstructor;
using MyNameSpace.constructors.instanceConstructor;
using MyNameSpace.constructors.copyConstructor;
using MyNameSpace.interfaceExample;
using MyNameSpace.genericNamespace;
using MyNameSpace.CollectionNamespace;
using MyNameSpace.PartialClassNamespace;
using MyNameSpace.delegateNamespace;
using MyNameSpace.PolymorphismNamespace;
using MyNameSpace.BaseNameSpace;
using MyNameSpace.RefNamespace;
/*
* @Abstract Class
*/

abstract class Vehicle
{
    public void moving()
    {
        Console.WriteLine("Vechile is moving");
    }
}

// class Car : Vehicle
// {
//     int maxSpedd = 100;
// }

/*
* Sealed Class , class cannot be extended i.e inherited if it is sealed
*/

sealed class SealedClass { }

class IndexersClass
{
    public string[] names = new string[10];

    public string this[int i]
    {
        get { return names[i]; }
        set { names[i] = value; }
    }
}

namespace MyNameSpace
{
    class Program
    {
        enum Days
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        };

        static void Main(string[] args)
        {
            // Constructor example
            Point Point = new Point();

            // private constructor are used to prevent creating instance of a class
            // Counter c = new Counter(); , throws a error as constructor is inaccessible

            Counter.currentCount = 1;
            Counter.IncrementCount();
            System.Console.WriteLine($"Current Count is : {Counter.currentCount}");

            // instance constructor
            Coords c = new Coords();
            // System.Console.WriteLine($"Coords are {c}");

            Coords c1 = new Coords(4,5);
            System.Console.WriteLine($"Coords at c1 are {c1}");

            Person p = new Person("Padam",25);

            // creating another instance of a person, copying p
            Person p2 = new Person(p);

            System.Console.WriteLine(p2.Details());

            // delegates example
            // delegates delegates = new delegates();
            // delegates.stringDelegate stringDelegate = delegates.ToUpperCase;
            // stringDelegate("This is transformed to uppercase");
            // delegates.addDelegate addDelegate = delegates.sum;
            // addDelegate(5, 4);
            // delegates.stringDelegate stringDelegate1, sd, multidel;
            // stringDelegate1 = delegates.Hello;
            // sd = delegates.GoodBye;
            // multidel = stringDelegate1 + sd;
            // multidel("A");

            // generics example 
            // int[] items = { 1, 2, 3, 4, 5 };
            // double[] doubleItems = { 1.0, 2.0, 3.0, 4.0 };
            // Generics g = new Generics();
            // var addedValue = g.add(5, 4.5);
            // g.displayElemets(items);
            // System.Console.WriteLine($"sum of two generic value is {addedValue}");

            //partial class example 
            // PartialClass pc = new PartialClass(10, 15);
            // pc.print();

            /* 
            ** @Enums
            */
            // int StartOfWeek = (int)Days.Sun;
            // Console.WriteLine("Start of the week is : {0}", StartOfWeek);

            // polymorphism 
            // PrintData p = new PrintData();
            // p.print();
            // p.print(5);
            // p.print("hello");

            // exceptional handling
            // exception.ExceptionExample exception = new exception.ExceptionExample();
            // exception.exceptionExample();

            // indexers example 
            // IndexersClass indexers = new IndexersClass();
            // indexers[0] = "suraj";
            // System.Console.WriteLine(indexers[0]);

            // pass value by reference
            // int i = 1, j = 2;
            // Console.WriteLine("Before Swapping: i = {0} j = {1}", i, j);
            // RefExample refObj = new RefExample();
            // refObj.getSwapRef(ref i,ref j);
            // Console.WriteLine("After Swapping: i = {0} j = {1}", i, j);

            // namespace example
            // namespaces.firstNamespace.sameClass obj1 = new namespaces.firstNamespace.sameClass();
            // obj1.func();

            // namespaces.secondNamespace.sameClass obj2 = new namespaces.secondNamespace.sameClass();
            // obj2.func();


            // interface and multiple inheritance examples
            // Interfaces interfaces = new Interfaces();

            // collection and generics
            // collections collection = new collections();
            // collection.collectionFunction();

            // example of method overriding and method hiding
            // Cat c = new Cat();
            // c.display();

        }
    }
}