using System.Text;

namespace MyNameSpace.textReadandWrite
{
    class TextReadandWrite
    {
        const string fileName = "test1.txt";

        string fullPath = Path.GetFullPath(fileName);

        public void CreateFile()
        {
            using (TextWriter textWriter = File.CreateText(fullPath))
            {
                textWriter.Write("This is some random text");
            }
        }

        public void ReadFromFile()
        {
            using (TextReader textReader = File.OpenText(fullPath))
            {
                System.Console.WriteLine(textReader.ReadLine());
            }
        }
    }
}