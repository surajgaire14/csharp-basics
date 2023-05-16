namespace MyNameSpace.attribue
{

    // attribute applied to class
    [AttributeUsage(AttributeTargets.Class)]
    class AttributeUsageClass : Attribute {
        public string? Name { get; set; }
    }

    [AttributeUsageClass(Name = "John")]
    public class TestCustomAttribute {
        public int MyProperty { get; set; }
    }

    class AttributeClass
    {
        [Obsolete("use addNumber(List<int> numbers) method")]
        public int addNumber(int a, int b)
        {
            return a + b;
        }
        
        public int addNumber(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}