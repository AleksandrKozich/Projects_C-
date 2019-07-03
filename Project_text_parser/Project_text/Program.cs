using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace Project_text
{
    class Program
    {
        /*
•  Распарсить предложенный документ на:  
o  Предложения 
o  Слова 
o  Знаки препинания 
•  Вывести в другой файл слова в алфавитном порядке, с указанием 
количества использований данного слова. 
•  В ещё один файл вывести с новой строки 
o  самое длинное предложение по количеству символов 
o  самое короткое предложение по количеству слов 
o  самую встречающуюся букву 

 */
        private static void Main(string[] args)

        {

            string line = "=============================================================";

            IFileReader r = new TextReader(@"D:/New/sample1.txt");

            List<string> listSentences = new List<string>();      

            IParser<Text> parser = new TextParser();
            
            listSentences = r.Read();
            
            {

                string writePath = @"D:\New\1.txt";

              //  string text1 = "kjgjhghghj";
                try
                {
                  
                    /*1. Вывести в другой файл слова в алфавитном порядке, с указанием
                количества использований данного слова.*/
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        var file = @"D:/New/sample.txt";
                        try
                        {
                            using (StreamReader sr = new StreamReader(file))
                            {
                                var text1 = sr.ReadToEnd();

                                 var allwords = text1.Split(new char[] { ' ', '-', '\'', '.', '=', ',', '"', ' ', '!', ';', '?', '\r', '\n', '#','$','&','_','*','@' ,'~','(',')', '{', '}', '[', ']', '|', '/', ':', '+', ';', '<','>',}, StringSplitOptions.RemoveEmptyEntries);
                                  var unique =
                                      (from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
                                  foreach (var word in unique)
                                  {
                                     int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
                                     sw.WriteLine("Word: {0} - {1}", word, cnt);

                                  }
                                  //2. самое длинное предложение по количеству символов
                                sw.WriteLine("Word with max length: " + text1.Split(new Char[] { '.', ':', '!', '?', ';', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(s => s.Length).First());
                                //3. самое короткое предложение по количеству слов
                                sw.WriteLine("Word with min length: " + text1.Split(new Char[] { '.', ':', '!', '?', ';', '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(s => s.Length).First());
                                //4. самую встречающуюся букву 
                               sw.WriteLine(text1.Select(x => new { Symbol = x, Count = text1.Count(y => y == x) }).OrderByDescending(x => x.Count).First().Symbol);

                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }

                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

            Console.WriteLine(line);
            
            Console.ReadKey();

        }

    }

}