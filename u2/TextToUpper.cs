using System;
namespace u2
{
    public class TextToUpper : ITransform
    {
        public string text { get; set; }
        public TextToUpper(string text)
        {
            this.text = text;
        }
        public string Transform()
        {
            return text.ToUpper();
        }
    }
}
