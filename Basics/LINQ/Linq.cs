namespace MyNameSpace.LINQNamespace
{
    class LinqClass
    {
        // specifying the data source
        private static int[] scores = new int[] { 91, 95, 85, 82 };

        // define the query expressions
        IEnumerable<int> scoreQuery = from score in scores where score > 85 select score;
        public void displayScore()
        {

            foreach (int score in scoreQuery)
            {
                System.Console.WriteLine($"{score}");
            }
        }

    }
}