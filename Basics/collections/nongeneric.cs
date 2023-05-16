using System.Collections;

namespace MyNameSpace.CollectionNamespace.nongeneric
{
    class NonGenericClass
    {
        // non generic collectoin

        public void ShowNonGenericList()
        {
            ArrayList numbers = new ArrayList(3);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int number in numbers)
            {
                System.Console.WriteLine($"{number}");
            }
        }
    }
}