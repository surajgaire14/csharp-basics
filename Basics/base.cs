namespace MyNameSpace.BaseNameSpace
{
    // base class for class rectangle
    class Shape
    {
        protected int width, height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        // public Shape(int w,int h){
        //     this.width = w;
        //     this.height = h;
        // }
    }
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class Animal
    {
        protected string color = "white";

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

        // Dynamic polymorphism - method overriding
        public override void showColor()
        {
            base.showColor();
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