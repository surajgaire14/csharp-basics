namespace MyNameSpace.constructors.copyConstructor
{
    class Person
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public Person(Person PreviousPerson)
        {
            Name = PreviousPerson.Name;
            Age = PreviousPerson.Age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Details()
        {
            return $"{Name} is {Age}";
        }

    }
}