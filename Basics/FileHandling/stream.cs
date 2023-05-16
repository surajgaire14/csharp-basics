namespace MyNameSpace.streamReadAndWrite
{
    class StreamReadandWrite
    {
        const string fileName = "test2.txt";

        string fullPath = Path.GetFullPath(fileName);

        public void CreateFile()
        {
            using (StreamWriter textWriter = File.CreateText(fullPath))
            {
                textWriter.Write("This is some random text from streamwriter");
            }
        }

        public void ReadFromFile()
        {
            using (StreamReader textReader = File.OpenText(fullPath))
            {
                System.Console.WriteLine(textReader.ReadLine());
            }
        }
    }
}