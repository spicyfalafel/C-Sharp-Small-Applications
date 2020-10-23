using System.Collections.Generic;
using System.Linq;

namespace MemoriseWordsLibrary
{
    public class Quiz
    {
        public User user;
        public Word CurrentWord { get; set; }
        public int CurrentWordIndex = -1;
        public int CurrentWordTimesAnswered;

        public Quiz(User user)
        {
            this.user = user;
            if(user.Words.Count != 0)
            {
                CurrentWord = user.Words[0];
            }
            else
            {
                CurrentWord = new Word("No words. Add them!", "Really, add them!");
            }
        }
        public void NextWord()
        {
            if (CurrentWordIndex+1 >= user.Words.Count) return;
            CurrentWordIndex++;
            CurrentWord = user.Words[CurrentWordIndex];
        }

        /// 
        public bool Guess(string answer)
        {
            bool correct = answer == CurrentWord.Translated;
            if (correct)
            {
                AddToWord();
            }
            else
            {
                MinusOneToWord();
            }
            return correct;
        }

        public void AddToWord()
        {
            if (CurrentWord.TimesAnswered < 10)
            {
                CurrentWord.TimesAnswered++;
            }
        }
        public void MinusOneToWord()
        {
            if (CurrentWord.TimesAnswered < 10)
            {
                CurrentWord.TimesAnswered--;
            }
        }

        public Quiz()
        {
        }
    }
}