//using System.IO;

namespace MethodLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
        }

        static void WriteFile() // File IO --> Writing files
        {
            StreamWriter writer = new StreamWriter("some-file.txt"); // replace 'some-file.txt' with desired file name
            writer.WriteLine("Each 'WriteLine' will save a string to the above file.");
            writer.Close();
        }

        static void ReadFile() // File IO --> Reading files
        {
            StreamReader reader = new StreamReader("some-file.txt");

            while(reader.EndOfStream == true)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}