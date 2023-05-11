namespace MyNameSpace.inheritanceNamespace
{
    class Rectangle
    {
        protected double length, width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double getArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Area: {0}", getArea());
        }
    }

    class TableTop : Rectangle
    {
        private double cost;

        public TableTop(double l, double w) : base(l, w) { }

        public double GetCost()
        {
            // double cost;
            cost = getArea() * 20;
            return cost;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
}