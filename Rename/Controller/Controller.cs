class Controller
{
    string localPath;
    DirectoryInfo directoryInfo;
    public Controller()
    {
        localPath = Directory.GetCurrentDirectory() + @"\folder";
        directoryInfo = new DirectoryInfo(localPath);
    }



    public FileInfo[] GetFiles()
    {
        return directoryInfo.GetFiles();
    }

    public void RenameFile(FileInfo nameFile, int startNumberFile)
    {
        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(nameFile.Name,startNumberFile.ToString());
    }
}