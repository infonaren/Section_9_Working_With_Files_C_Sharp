using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9_Working_With_Files_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = System.IO.Path.GetDirectoryName(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));
            var downloadFilePath = System.IO.Path.Combine(filePath, @"Downloads\sample.txt");

            //Write a C# program that reads a text file and displays the number of words.



            // Write a C# program that reads a text file and displays the longest word in the file.

            try
            {
                string text = File.ReadAllText(downloadFilePath);
                string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                Console.WriteLine($"Number of words in the file: {wordCount}");
                string longestWord = "";

                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
                Console.WriteLine($"Longest word in the file: {longestWord}");
                Console.WriteLine($"Longest word char count: {longestWord.Length}");


            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please check the file path.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

/*
       File.Copy(@"C:\Users\NAREN BAGAVATHY\Downloads\UiARD-demo.pdf",@"E:\UiPath_UiADP",true);
   var file1 = @"C:\Users\NAREN BAGAVATHY\Downloads\UiARD-demo.pdf";
   File.Delete(file1);
   if (File.Exists(file1))
   {
   //
   }
   
   var content = File.ReadAllText(file1);
   
   var fileInfo = new FileInfo(file1);
   
   fileInfo.CopyTo(@"E:\UiPath_UiADP", true);
   fileInfo.Delete(file1);
   if (fileInfo.Exists)
   {
   //
   }
    Directory.CreateDirectory(@"E:\UiPath_UiADP\NewFolder1");
   var files = Directory.GetFiles(@"E:\UiPath_UiADP\NewFolder1","*.*",SearchOption.AllDirectories);
   
   foreach (var file in files)
   {
   Console.WriteLine(file);
   }
   
   var directories = Directory.GetDirectories(@"E:\UiPath_UiADP\NewFolder1", "*.*", SearchOption.AllDirectories);
   foreach (var directory in directories)
   Console.WriteLine(directory);
   
   Directory.Exists("....");
   
   var directoryInfo = new DirectoryInfo("...");
   directoryInfo.GetFiles();
   directoryInfo.GetDirectories();
   
   var filePath = @"E:\UiPath_UiADP\NewFolder1\New Text Document.txt";
   
   var dotIndex = filePath.IndexOf('.');
   var extension = filePath.Substring(dotIndex);
   
   Console.WriteLine("File Extension: "+ Path.GetExtension(filePath));
   Console.WriteLine("File Name: " + Path.GetFileName(filePath));
   Console.WriteLine("File Name Without Extension: " + Path.GetFileNameWithoutExtension(filePath));
   Console.WriteLine("Directory Name: " + Path.GetDirectoryName(filePath));
   
   
   
  
 */
