namespace MyNameSpace.indexers
{
    class IndexersClass
    {
        private int[] ids = new int[5];

        private string[] names = new string[5];

        // int type indexers
        // public int this[int i]
        // {
        //     get
        //     {
        //         return ids[i];
        //     }
        //     set
        //     {
        //         ids[i] = value;
        //     }
        // }


        public string this[int index]{
            get{
                return names[index];
            }
            set {
                names[index] = value;
            }
        }

    }
}