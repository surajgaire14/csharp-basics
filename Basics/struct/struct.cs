namespace MyNameSpace.structNamespace
{
    struct StructExample
    {
        private int id;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public void display()
        {
            System.Console.WriteLine($"id is {id}");
        }

    }
}