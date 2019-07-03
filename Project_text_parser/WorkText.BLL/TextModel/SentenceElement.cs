

namespace Project_text
{
 public class SentenceElement : ISentenceElement
    {
        public string Value { get; set; }
        public SentenceElementType SentenceElementType { get; private set; } 

        public SentenceElement(string sentenceElementValue, SentenceElementType type)
        {
            
        }
        }
}