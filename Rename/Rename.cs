internal class Rename
{
    private static void Main(string[] args)
    {
        
        Controller controller1 = new Controller();

        for (int i = 0; i < controller1.GetPathFiles().Length; i++)
        {
            Console.WriteLine(controller1.GetPathFiles()[i]);
        }
        

        }
    
}