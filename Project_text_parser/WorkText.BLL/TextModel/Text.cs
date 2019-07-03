using System;
using System.Collections.Generic;


namespace Project_text
{
    public class Text
    {
        private List<ISentence> _sentences;
       
        public Text()
        {
            _sentences = new List<ISentence>();
          
        }
        public void AddSentence(ISentence sentence)
        {
            _sentences.Add(sentence);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, _sentences);
        }

       

        public static object Split(char[] v, StringSplitOptions removeEmptyEntries)
        {
            throw new NotImplementedException();
        }
    }
}
