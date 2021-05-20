using System;
using System.IO;
using System.Text;

namespace u2
{
    public class Facade
    {
        
        public string Transform(int sequence, string text)
        {

            TextToUpper textToUpper;
            FirstCharToUpper firstCharToUpper;
            switch (sequence)
            {
                case 1:
                    using (var sw = new StreamWriter("test.txt", false, Encoding.UTF8))
            {
                        textToUpper = new TextToUpper(text);
                        sw.WriteLine(textToUpper.Transform());
            }
                    using (var sr = new StreamReader("test.txt", Encoding.UTF8))
                    {
                       firstCharToUpper = new FirstCharToUpper(sr.ReadToEnd());
                    }
                    return firstCharToUpper.Transform();

                case 2:
                    using (var sw = new StreamWriter("test.txt", false, Encoding.UTF8))
                    {
                        firstCharToUpper = new FirstCharToUpper(text);
                        sw.WriteLine(firstCharToUpper.Transform());
                    }
                    using (var sr = new StreamReader("test.txt", Encoding.UTF8))
                    {
                        textToUpper = new TextToUpper(sr.ReadToEnd());
                    }
                    return textToUpper.Transform();
                default:
                    throw new ArgumentException("You can choose only 2 types of combination");
            }

        }
    }
}
