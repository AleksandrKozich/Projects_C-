using System.Collections.Generic;




namespace Project_text
{
    public class TextParser : IParser<Text>
    {
        public Text Parse(List<string> sentences)
        {
            var text = new Text();
            
            foreach (var currentSentence in sentences)
            {
                var sentence = new Sentence();
               
             
                text.AddSentence(sentence);
            }
            return text;
        }
    }
}