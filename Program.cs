#define StartVersion
#define FinalVersion
using MyNameSpace.constructors;
using MyNameSpace.constructors.privateConstructor;
using MyNameSpace.constructors.instanceConstructor;
using MyNameSpace.constructors.copyConstructor;
using MyNameSpace.array.jagged;
using MyNameSpace.array.matrixMul;
using MyNameSpace.structNamespace;
using MyNameSpace.delegateNamespace.action;
using MyNameSpace.delegateNamespace.anonymous;
using MyNameSpace.ReverseStringNamepace;
using MyNameSpace.propertiesNamespace;
using MyNameSpace.interfaceExample;
using MyNameSpace.genericNamespace;
using MyNameSpace.CollectionNamespace;
using MyNameSpace.PartialClassNamespace;
using MyNameSpace.delegateNamespace;
using MyNameSpace.PolymorphismNamespace;
using MyNameSpace.BaseNameSpace;
using MyNameSpace.RefNamespace;
using MyNameSpace.CollectionNamespace.nongeneric;
using MyNameSpace.genericNamespace.genericClass;
using MyNameSpace.genericNamespace.genericField;
using MyNameSpace.LamdaExpressionNamespace;
using MyNameSpace.Asynchronous;
using MyNameSpace.attribue;
using System.Diagnostics;
using System.Reflection;
using MyNameSpace.binaryFileOperation;
using MyNameSpace.fileStream;
using MyNameSpace.textReadandWrite;
using MyNameSpace.streamReadAndWrite;
using MyNameSpace.copyFileContent;
using MyNameSpace.writeToFile;

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
        delegate int PointToaddFunction(int num1, int num2);

        [Conditional("StartVersion")]
        public static void StartVersion()
        {
            System.Console.WriteLine("Start version of a function");
        }

        [Conditional("FinalVersion")]
        public static void FinalVersion()
        {
            System.Console.WriteLine("Final version of a function");
        }

        static void Main(string[] args)
        {
            /*
            @ File handling
            */
            // BinaryFileOperation binaryFileOperation = new BinaryFileOperation();
            // binaryFileOperation.writeToFile();
            // binaryFileOperation.diplayData();

            FileStreamClass fileStreamClass = new FileStreamClass();
            // fileStreamClass.deleteFileifExists();
            fileStreamClass.CreateFile();
            fileStreamClass.ReadFromFile();

            TextReadandWrite textReadandWrite = new TextReadandWrite();
            textReadandWrite.CreateFile();
            textReadandWrite.ReadFromFile();

            StreamReadandWrite streamReadandWrite = new StreamReadandWrite();
            streamReadandWrite.CreateFile();
            streamReadandWrite.ReadFromFile();

            CopyFileContent copyFileContent = new CopyFileContent();
            copyFileContent.CopyFromFile();
            copyFileContent.ReadFromCopiedFile();

            WriteToFile writeToFile = new WriteToFile();
            writeToFile.GetUserInputAndWriteToFile();
            writeToFile.ReadFromFile();

            // Constructor example
            // Point Point = new Point();

            /*
            * @Properties
            */
            // Properties properties = new Properties();
            // properties.Id = 5;
            // System.Console.WriteLine($"value of id is {properties.Id}");
            // properties.SetId(5);
            // System.Console.WriteLine($"value of id is {properties.GetId()}");
            // properties.display();

            // getting input array from users
            // string[] names = new string[5];
            // array.Array array = new array.Array();
            // array.GetArray(names);
            // Array.Sort(names);
            // array.displayNames(names);

            // jagged array

            int[][] arr = new int[2][];

            // initializing jagged array
            arr[0] = new int[3] { 0, 1, 2 };
            arr[1] = new int[4] { 3, 4, 5, 6 };

            // display the array elements
            // JaggedArray ja = new JaggedArray();
            // ja.displayJaggedArray(arr);

            /*
            * @ Matrix Multiplication
            */


            // MyNameSpace.array.Array arrObj = new MyNameSpace.array.Array();
            // arrObj.MatrixMultiplication();

            /*
            @ reverse string
            */
            // string name;
            // System.Console.WriteLine("Enter a name");
            // name = Console.ReadLine()!;
            // ReverseString rs = new ReverseString();
            // string charArray = rs.Reverse(name);
            // System.Console.WriteLine($"total number of character is: {charArray.Length}");
            // bool doesstart = charArray.StartsWith("su");
            // bool doesEnd = charArray.EndsWith("aj");
            // // doesstart ? "yes,the string starts with substring" : "the string does start with substring "
            // if (doesEnd)
            // {
            //     System.Console.WriteLine("yes,the string ends with substring"); ;
            // }
            // else
            // {
            //     System.Console.WriteLine("the string does not end with substring ");
            // }
            // System.Console.WriteLine($"{charArray}");

            // indexers.IndexersClass ids = new indexers.IndexersClass();
            // ids[0] = "gaire";
            // System.Console.WriteLine($"id is {ids[0]}");

            // StructExample sg = new StructExample();
            // sg.Id = 5;
            // sg.display();

            // // action delegates
            // ActionDelegate ad = new ActionDelegate();
            // Action<int, int> sum = ad.addTwoNum;
            // sum(5, 15);

            // // points to add function
            // // PointToaddFunction ptaf = add;

            // // anonymous delegate function
            // PointToaddFunction ptaf = delegate (int num1, int num2)
            // {
            //     return num1 + num2;
            // };

            // System.Console.WriteLine($"sum from pointed delegated function is {ptaf(5, 3)}");

            // static int add(int a, int b)
            // {
            //     return a + b;
            // }

            /*
            * @ Events using delegates
            */

            // public string welcomeUser(String username){
            //     return "Welcome " + username;
            // }

            /*
            * @ Generic Class
            */

            // GenericClass<int> obj = new GenericClass<int>();
            // obj.Key = 5;
            // System.Console.WriteLine($"Generic Key is {obj.Key}");


            // lamda expression

            // LamdaExpression le = new LamdaExpression();
            // le.displaySquare(5);
            // le.LINQWithLamdaExpression();

            // asynchronous programming

            // AsynchronousClass ac = new AsynchronousClass();
            // await ac.GetJsonData();

            // attributes
            // AttributeClass attributeClass = new AttributeClass();
            // int result = attributeClass.addNumber(5, 10);
            // System.Console.WriteLine($"sum of number is {result}");

            // List<int> numbers = new List<int>() { 10, 20, 30 };
            // int genericListResult = attributeClass.addNumber(numbers);
            // System.Console.WriteLine($"sum of number is {genericListResult}");


            // var types = from t in Assembly.GetExecutingAssembly().GetTypes()
            //             where t.GetCustomAttributes<AttributeUsageClass>().Count() > 0
            //             select t;

            // foreach(var t in types){
            //     System.Console.WriteLine(t.Name);
            // }

            // private constructor are used to prevent creating instance of a class
            // Counter c = new Counter(); , throws a error as constructor is inaccessible
            // Counter.currentCount = 1;
            // Counter.IncrementCount();
            // System.Console.WriteLine($"Current Count is : {Counter.currentCount}");

            // instance constructor
            // Coords c = new Coords();
            // System.Console.WriteLine($"Coords are {c}");

            // Coords c1 = new Coords(4, 5);
            // System.Console.WriteLine($"Coords at c1 are {c1}");

            // Person p = new Person("Padam", 25);

            // creating another instance of a person, copying p
            // Person p2 = new Person(p);

            // System.Console.WriteLine(p2.Details());

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

            // non generic collections
            // NonGenericClass ngc = new NonGenericClass();
            // ngc.ShowNonGenericList();

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
            // c.showColor();
        }
    }
}