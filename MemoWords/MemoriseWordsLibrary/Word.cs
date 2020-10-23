using System;

namespace MemoriseWordsLibrary
{
    public class Word
    {
        public string WordToLearn;
        public string Translated;
        public int TimesAnswered;

        public Word(string wordToLearn, string translated)
        {
            WordToLearn = wordToLearn;
            Translated = translated;
        }

        public Word() { }
    }
}
