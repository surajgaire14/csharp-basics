namespace MyNameSpace.genericNamespace.genericClass
{
    public class GenericClass<T>
    {

        // generic field
        private T? key;

        public T Key
        {
            get
            {
                return key!;
            }
            set
            {
                key = value;
            }
        }
    }
}