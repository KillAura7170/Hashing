using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR07_29032022
{
	static class FileHelper
	{
		public static void EnumerateFile(string inputFilePath, string outputFilePath)
		{
			string inputText = ReadText(inputFilePath);
			string outputText = "";
			int index = 1;

			outputText += $"{index}. ";

			for (int i = 0; i < inputText.Length; i++)
			{
				if (inputText[i] == '\r')
				{
					index++;
					outputText += $"\r\n{index}. ";
					i++;
					continue;
				}
				outputText += inputText[i];
			}

			WriteText(outputFilePath, outputText);
		}

		public static void SymboleCount(string inputFilePath)
        {
			string inputText = ReadText(inputFilePath);
			int index = 1;
			int _index = 1;

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] != 13 && inputText[i] != 10)
                {
					index++;
                }
				if (inputText[i] == 13 || inputText[i] == 10)
                {
					_index++;
                }
            }
			index -= _index;
            Console.WriteLine("Symbole Count = " + index);
        }

		public static void WordCount(string InputFilePath)
        {
			string inputText = ReadText(InputFilePath);
			int index = 1;

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == 13 || inputText[i] == 10)
                {
					index++; 
                }
            }
            Console.WriteLine("Word Count = " + index);
        }

		public static void CountSymbole(string InputFilePath)
        {
			string inputText = ReadText(InputFilePath);
        }

		public static string ReadText(string path)
		{
			using (FileStream fileStream = new FileStream(path, FileMode.Open))
			{
				byte[] data = new byte[fileStream.Length];
				fileStream.Read(data, 0, data.Length);
				return GetString(data);
			}
		}

		public static void WriteText(string path, string text)
		{
			using (FileStream fileStream = new FileStream(path, FileMode.Create))
			{
				byte[] data = GetBytes(text);
				fileStream.Write(data, 0, data.Length);
			}
		}

		private static byte[] GetBytes(string text)
		{
			byte[] buffer = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				buffer[i] = (byte)text[i];
			}
			return buffer;
		}

		private static string GetString(byte[] data)
		{
			char[] buffer = new char[data.Length];
			for (int i = 0; i < data.Length; i++)
			{
				buffer[i] = (char)data[i];
			}
			return new string(buffer);
		}
	}
}
