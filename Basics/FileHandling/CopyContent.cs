using System.Text;

namespace MyNameSpace.copyFileContent
{
    class CopyFileContent
    {
        const string fileName = "data.dat";
        const string copiedFile = "copy.dat";

        public void CopyFromFile()
        {
            using (FileStream stream = File.OpenRead(Path.GetFullPath(fileName)))
            using (FileStream writeStream = File.OpenWrite(Path.GetFullPath(copiedFile)))
            {

                BinaryReader binaryReader = new BinaryReader(stream);
                BinaryWriter binaryWriter = new BinaryWriter(writeStream);

                // creating the buffer to hold the bytes
                byte[] buffer = new Byte[1024];
                int bytesRead;

                // while the read method returns bytes
                // keep writing them to the output stream
                while ((bytesRead =
                        stream.Read(buffer, 0, 1024)) > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                }


            }
        }

        public void ReadFromCopiedFile()
        {
            string Name;
            int roll_no;
            if (File.Exists(copiedFile))
            {
                using (var reader = new BinaryReader(File.Open(copiedFile, FileMode.Open), Encoding.UTF8, false))
                {

                    Name = reader.ReadString();
                    roll_no = reader.ReadInt32();
                }
                System.Console.WriteLine($"Name is {Name}");
                System.Console.WriteLine($"Roll no is {roll_no}");
            }
        }
    }
}