using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Program p = new Program();
            string path = @"C:\testfolder\";
            p.PrintFiles(path);
            p.PrintFolders(path);

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        string PrintFolders(string a)
        {
            Program p = new Program();
            DirectoryInfo folders = new DirectoryInfo(a);
            DirectoryInfo[] current = folders.GetDirectories();
            for (int str = 0; str < current.Length; str++)
             {
                Console.WriteLine(current[str].FullName);
                PrintFiles(current[str].FullName);
                PrintFolders(current[str].FullName);
            }
            return null;
        }

        string PrintFiles(string a)
        {
            string[] files = Directory.GetFiles(a);
            foreach (string str in files)
            {
                Console.WriteLine(str);
            }
            return null;
        }
    }
}