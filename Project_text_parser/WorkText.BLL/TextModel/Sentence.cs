using System.Collections.Generic;
using System.Text;

namespace Project_text
{
    public class Sentence : ISentence
    {

        private readonly List<ISentenceElement> _sententenceElements;
        
        public Sentence()
        {
            _sententenceElements = new List<ISentenceElement>();
            
        }

       
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_sententenceElements[0].Value);
            for (int i = 1; i < _sententenceElements.Count; i++)
            {
                if (_sententenceElements[i].SentenceElementType == SentenceElementType.Word)
                {
                    builder.Append(" ");
                }
                builder.Append(_sententenceElements[i].Value);
            }
            return builder.ToString();
        }

        public int GetWordsCount()
        {
            throw new System.NotImplementedException();
        }
    }
}