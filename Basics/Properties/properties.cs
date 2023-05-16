namespace MyNameSpace.propertiesNamespace
{
    class Properties
    {
        private int id;

        public void SetId(int Id)
        {
            this.id = Id;
        }

        public int GetId()
        {
            return id;
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

    }
}