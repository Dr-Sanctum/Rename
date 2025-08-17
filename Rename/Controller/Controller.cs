class Controller
{
    string localPath;
    public Controller()
    {
        localPath = Directory.GetCurrentDirectory();
    }


    public string[] GetPathFiles()
    {
        string[] arrPath = Directory.GetFiles(localPath);
        return arrPath;
    }

    public void RenameFile(string nameFile, string startNumberFile)
    {
        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile("nameFile","newNameFile");
    }
}