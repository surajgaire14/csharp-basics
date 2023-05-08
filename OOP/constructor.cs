namespace MyNameSpace.constructors
{
    class Point
    {
        int x, y;

        // public int X
        // {
        //     get { return x; }
        //     set { x = value; }
        // }

        // public int Y
        // {
        //     get { return y; }
        //     set { y = value; }
        // }

        // default constructor
        public Point()
        {
            Console.WriteLine("Default Constructor");
        }

        // parametarized constructor
        public Point(int a, int b)
        {
            this.x = a;
            this.y = b;
            // Console.WriteLine("a: = {0}", a);
        }

        public void show()
        {
            Console.WriteLine("x: = {0},y:={1}", x, y);
        }
    }
}