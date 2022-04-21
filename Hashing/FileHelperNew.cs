using System;
using System.IO;

namespace ConsoleApp134
{
    static class FileHelperNew
    {
        public static void EnumerateFile(string InputFilePath, string OutPutFileText)
        {
            string text;
            int index = 1;
            using (StreamReader reader = new StreamReader(InputFilePath))
            {
                StreamWriter writer = new StreamWriter(OutPutFileText);
                while (reader.Peek() != -1)
                {
                    text = reader.ReadLine();
                    writer.WriteLine(index + ". " + text);
                    index++;
                }
                
                reader.Close();
                writer.Close();
            }
        }

        public static void ReadText(string InputFilePath)
        {
            StreamReader reader = new StreamReader(InputFilePath);
            while (reader.Peek() != -1)
            {
                int code = reader.Read();
                Console.Write((char)code);
            }

            reader.Close();
        }

        public static void WriteText(string path, string text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(text);

            writer.Close();
        }
    }
}
