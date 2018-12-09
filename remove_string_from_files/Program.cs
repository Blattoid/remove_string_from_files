using System;
using System.Collections.Generic;
using System.IO;

namespace remove_string_from_files
{
    class Program
    {
        public static bool Verbose;
        public static bool WantsHelp;
        public static bool Recursive;
        public static int numoffiles;

        static void Main(string[] args)
        {
            //Query string to remove
            Console.Write("Enter string to remove from files: ");
            string remove_this = Console.ReadLine();

            //Get an array of files
            List<string> files = new List<string>();
            foreach (string i in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                files.Add(Path.GetFileName(i));
            }

            //For each file...
            foreach (string File in files)
            {
                //Check if file contains string. If it does, move file to new name, removing the string.
                if (File.Contains(remove_this))
                {
                    numoffiles = numoffiles + 1;
                    string new_name = File.Replace(remove_this, "");

                    Console.WriteLine("'" + File + "' ===> '" + new_name + "'");
                    Directory.Move(File, new_name);
                }

            }
            if (numoffiles == 0) { Console.WriteLine("No files with the string were found."); }
            Console.WriteLine("Action completed.");
            Console.ReadLine();
        }
    }
}
