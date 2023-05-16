using System.Text;

namespace MyNameSpace.binaryFileOperation
{
    class BinaryFileOperation
    {
        const string filename = "data.dat";

        public void writeToFile()
        {
            using (var stream = File.Open(filename, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write("Suraj Gaire");
                    writer.Write(30);
                }
            }
        }

        public void diplayData()
        {
            string Name;
            int roll_no;
            if (File.Exists(filename))
            {

                using (var stream = File.Open(filename, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        Name = reader.ReadString();
                        roll_no = reader.ReadInt32();
                    }
                }
                System.Console.WriteLine($"Name is {Name}");
                System.Console.WriteLine($"Roll No is {roll_no}");
            }
        }
    }
}