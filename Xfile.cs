using System;
using System.IO;

public static class XFile
{
    public static void DeliteFile(string path)
    {
        FileInfo file = new FileInfo(path);
        if (file.Exists)
        {
            file.Delete();
            
        }
        DirectoryInfo directory = new DirectoryInfo(path);
        if (directory.Exists)
            directory.Delete(true);
    }
}
