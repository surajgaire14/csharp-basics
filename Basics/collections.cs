namespace MyNameSpace.CollectionNamespace
{
    class collections
    {
        // var names = new List<String> { "Suraj", "Padam", "Nishan", "Riwaj" };
        public void collectionFunction()
        {
            var names = new List<String>();
            names.Add("Suraj");
            names.Add("Padam");
            names.Add("Nishan");
            names.Add("Riwaj");

            foreach (var name in names)
            {
                System.Console.WriteLine($"{name} ");
            }
        }
    }
}