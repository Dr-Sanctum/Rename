using System.Security.Cryptography.X509Certificates;

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
        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(nameFile.FullName, startNumberFile.ToString() + nameFile.Extension);
    }

    public void RenameFileAll()
    {
        FileInfo[] AllFiles = GetFiles();

        foreach (var item in AllFiles)
        {
            Console.WriteLine(item.Name);
        }

        SortArrayFileInfoByName(AllFiles);

        foreach (var item in AllFiles)
        {
            Console.WriteLine(item.Name);
        }

        /*
        for (int i = 0; i < AllFiles.Length; i++)
        {
            bool temp = String.Equals(i.ToString() + AllFiles[i].Extension, AllFiles[i].Name);
            if (temp)
            {
                continue;
            }
            RenameFile(AllFiles[i], i);
        }
        */
    }

    public void SortArrayFileInfoByName(FileInfo[] arrayFileInfo)
    {
        Array.Sort(arrayFileInfo, (f1, f2) =>
        int.Parse(f1.Name.Replace(f1.Extension, ""))
        .CompareTo
        (int.Parse(f2.Name.Replace(f2.Extension, ""))));
    }
}