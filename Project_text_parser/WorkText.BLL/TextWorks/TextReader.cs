using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Project_text
{
    public class TextReader : IFileReader
    {
        private string _fileName;
        private string _bufLine = string.Empty;

        public TextReader(string fName)
        {
            this._fileName = fName;
        }

        public List<string> Read()
        {
            FileStream stream = new FileStream(_fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream, Encoding.Default);
            List<string> result = new List<string>();

            string str = string.Empty;
            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
              
            }
            reader.Close();
            return result;
        }
       

    }
}
