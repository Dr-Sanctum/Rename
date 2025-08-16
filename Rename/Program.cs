
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        string myPath = Directory.GetCurrentDirectory();
        string[] arrPath = Directory.GetFiles(myPath);
        

        for (int i = 0; i < arrPath.Length; i++)
        {
            Console.WriteLine(arrPath[i]);
        }
        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile("111.txt","222.txt");

        arrPath = Directory.GetFiles(myPath);

        for (int i = 0; i < arrPath.Length; i++)
        {
            Console.WriteLine(arrPath[i]);
        }
    }
}