using System.Text;

namespace MyNameSpace.writeToFile
{
    class WriteToFile
    {
        const string fileName = "input.txt";

        string fullPath = Path.GetFullPath(fileName);
        string? line;
        public void GetUserInputAndWriteToFile()
        {
            System.Console.WriteLine("Enter a string");
            line = Console.ReadLine()!;

            using (FileStream fileStream = File.Create(fileName))
            {
                AddText(fileStream, line);
                for (int i = 1; i < 120; i++)
                {
                    AddText(fileStream, Convert.ToChar(i).ToString());
                }
            }

        }

        public void ReadFromFile()
        {
            if (File.Exists(fullPath))
            {
                using (FileStream fs = File.OpenRead(fileName))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                    {
                        Console.WriteLine(temp.GetString(b, 0, readLen));
                    }
                }
            }
        }

        public void AddText(FileStream fileStream, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fileStream.Write(info, 0, info.Length);
        }
    }
}