internal class Rename
{
    private static void Main(string[] args)
    {
        
        Controller controller1 = new Controller();

        for (int i = 0; i < controller1.GetPathFiles(controller1.GetLocalPath()).Length; i++)
        {
            Console.WriteLine(controller1.GetPathFiles(controller1.GetLocalPath())[i]);
        }
        //Microsoft.VisualBasic.FileIO.FileSystem.RenameFile("111.txt","222.txt");

        }
    
}