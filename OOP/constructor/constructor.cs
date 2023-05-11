namespace MyNameSpace.constructors
{
    class Point
    {
        int x, y;

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
            Console.WriteLine("x: = {0} , y: = {1}", x, y);
        }

        // static constructor
        public static DateTime examTime;

        static Point()
        {
            examTime = DateTime.Now;

            System.Console.WriteLine("Static constructor sets the exam time to {0}", examTime.ToString());
        }



        // public void show()
        // {
        //     Console.WriteLine("x: = {0},y:={1}", x, y);
        // }
    }
}