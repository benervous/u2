using System;
using System.Linq;

namespace u2
{
    public class FirstCharToUpper : ITransform
    {
        public string text { get; set; }
        public FirstCharToUpper(string text)
        {
            this.text = text;
        }
        public string Transform()
        {
            return char.ToUpper(text.First()) + text.Substring(1).ToLower();
        }
    }
}
