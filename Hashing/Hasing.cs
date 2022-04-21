using ConsoleApp134;
using GR07_29032022;
using System.Security.Cryptography;
using System.Text;

static class hashing
{
    public static string HashAndStore(string s, string inputFilePath)
    {
        var text = s;
        var algo = HashAlgorithm.Create("sha256");
        var hash = algo.ComputeHash(Encoding.UTF8.GetBytes(text));
        var output = BitConverter.ToString(hash);
        FileHelperNew.WriteText(inputFilePath, output);

        return output;
    }

    public static string HashAndCheck(string s, string inputFilePath)
    {
        var text = s;
        var algo = HashAlgorithm.Create("sha256");
        var hash = algo.ComputeHash(Encoding.UTF8.GetBytes(text));
        var output = BitConverter.ToString(hash);
        FileHelperNew.WriteText(inputFilePath, output);
        string? original;
        string? input;
        original = FileHelper.ReadText(@"C:\Users\(Your User)\Desktop\Hashing\Hashing\passwords.txt");
        input = FileHelper.ReadText(@"C:\Users\(Your User)\Desktop\Hashing\Hashing\checkpasswords.txt");
        if (input == original)
        {
            Console.WriteLine("input password was right!");
        }

        return output;
    }
}
