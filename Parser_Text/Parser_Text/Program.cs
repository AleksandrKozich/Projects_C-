using System;
using System.IO;

namespace Parser_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            
            var file = @"D:/New/sample1.txt";

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    var text = sr.ReadToEnd();

                    string[] words = text.Split(new char[] {'.', '?', ';', '!', ';', '?', '\r', '\n'},

                        StringSplitOptions.RemoveEmptyEntries);
                   
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }
            
        }

       public static void Run()
        {
            string gotor = "D:\\Old";
            
            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = gotor;

            watcher.NotifyFilter = NotifyFilters.LastAccess  
                                   | NotifyFilters.LastWrite 
                                   | NotifyFilters.FileName 
                                   | NotifyFilters.DirectoryName;

            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanget);

            watcher.Created += new FileSystemEventHandler(OnChanget);

            watcher.Deleted += new FileSystemEventHandler(OnDelete);

            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press q to exit");

            while (Console.Read() != 'q') ;
        }

        private static void OnChanget(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("New file sends" + e.Name+ "Deystvie s nim" + e.ChangeType);
          
           Console.WriteLine("\nIn Time  " + DateTime.UtcNow);

            var file2 = (@"D:/New/"+ e.Name);

           {  
                string filePath = @"D:\NEW\1.txt";

               
                string text = ("\n New file sends" + e.Name + "\n Deystvie s nim" + e.ChangeType + "\n In Time:  " + DateTime.UtcNow);

                FileStream fileStream = null;

                
                if (!File.Exists(filePath))

                    fileStream = File.Create(filePath); 

                else

                    fileStream = File.Open(filePath, FileMode.Append); 

         
                StreamWriter output = new StreamWriter(fileStream);

                
                output.Write(text);

               
                output.Close();
            }
        }

        private static void OnDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Delete File" + e.Name + "\n In Time:  " + DateTime.UtcNow);
            }

        private static void OnRenamed(object sender, RenamedEventArgs e)
            {
        Console.WriteLine("Renamed Filed" + e.Name  + "\n In Time:  " + DateTime.UtcNow);

        }
        }
    }



    

