namespace MyNameSpace.BaseNameSpace
{

    class Animal
    {
        protected string color = "white";

        public Animal(){
            System.Console.WriteLine("base class constructor");
        }

        // for method overriding use virtual keyword
        public virtual void showColor()
        {
            Console.WriteLine("Show Color base method:");
        }

        public void display()
        {
            Console.WriteLine("base class display method");
        }

    }

    class Cat : Animal
    {
        new string color = "black";

        public Cat() : base() {
            System.Console.WriteLine("derived class constructor");
        }

        // Dynamic polymorphism - method overriding
        public override void showColor()
        {
            // accessing base class method
            base.showColor();
            // accessing base class field 
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }

        // method hiding

        public new void display()
        {
            Console.WriteLine("derived class method");
        }
    }
}