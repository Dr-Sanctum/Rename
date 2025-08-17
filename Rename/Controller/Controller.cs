class Controller
{
    
    public string GetLocalPath()
    {
        string LocalPath = Directory.GetCurrentDirectory();
        
        return LocalPath;
    }

    public string[] GetPathFiles(string localPath)
    {

        string[] arrPath = Directory.GetFiles(localPath);
        return arrPath;
    }
}