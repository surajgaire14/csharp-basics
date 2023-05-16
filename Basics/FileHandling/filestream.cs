using System.Text;

namespace MyNameSpace.fileStream
{
    class FileStreamClass
    {
        const string fileName = "test.txt";
        string fullPath = Path.GetFullPath(fileName);

        public void deleteFileifExists()
        {
            try
            {

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
            }
            catch (FileNotFoundException e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
        public void CreateFile()
        {
            try
            {
                using (FileStream fileStream = File.Create(fileName))
                {
                    AddText(fileStream, "This is some text");

                    for (int i = 1; i < 120; i++)
                    {
                        AddText(fileStream, Convert.ToChar(i).ToString());
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                System.Console.WriteLine(e.ToString());
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