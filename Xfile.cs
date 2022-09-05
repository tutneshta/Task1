using System;
using System.IO;

public static class XFile
{
    public static void DeliteFile(string path)
    {
        DirectoryInfo file = new DirectoryInfo(path);
        foreach (FileInfo f in file.GetFiles())
        {

            f.Delete();
        }
        foreach (DirectoryInfo d in file.GetDirectories())
        {
            d.Delete();
        }
        //DirectoryInfo directory = new DirectoryInfo(path);
        //if (directory.Exists)
        //    directory.Delete(true);
    }
}
