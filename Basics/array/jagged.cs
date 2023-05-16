namespace MyNameSpace.array.jagged
{
    class JaggedArray
    {
        public void displayJaggedArray(int[][] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine($"Elements ({i}) :");
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    System.Console.WriteLine(numbers[i][j]);
                }
            }
        }
    }
}