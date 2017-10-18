using System;
using System.IO;

namespace remove_string_from_files
{
    class Program
    {
        public static int numoffiles;
        static void Main(string[] args)
        {
            //Query string to remove
            Console.Write("Enter string to remove from files: ");
            string remove_this = Console.ReadLine();

            //Get string array of files
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            //For each file...
            foreach (string File in files)
            {
                //Check if file contains string. If it does, move file to new name, removing the string.
                if (File.Contains(remove_this)) {
                    numoffiles = numoffiles + 1;
                    string new_name = File.Replace(remove_this, "");
                    Console.WriteLine("'"+File+"' ===> '"+new_name+"'");
                    Directory.Move(File, new_name);
                }

            }
            if (numoffiles == 0) { Console.WriteLine("No files with the string were found."); }
            Console.WriteLine("Action completed.");
        }
    }
}
