using System;
using System.IO;

public static class XFile
{
    public static void DeliteFile(string path)
    {

        DirectoryInfo fileAndDirectory = new DirectoryInfo(path);

        var delay = 30;
        if (!fileAndDirectory.Exists)
        {
            Console.WriteLine("папка по заданному адресу не существует");
        }
        else
        {
            foreach (FileInfo f in fileAndDirectory.GetFiles())
            {

                if (f.LastWriteTime < DateTime.Now.AddMinutes(-delay))
                {
                    try
                    {
                        f.Delete();
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine("Отсутствует доступ к файлу. Ошибка: " + e.Message);
                    }
                }

            }

            foreach (DirectoryInfo d in fileAndDirectory.GetDirectories())
            {

                if (d.LastWriteTime < DateTime.Now.AddMinutes(-delay))
                {
                    DeliteFile(d.FullName);

                    try
                    {
                        d.Delete();
                    }

                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine("Отсутствует доступ к папке. Ошибка: " + e.Message);
                    }

                }
            }
        }
    }
}
