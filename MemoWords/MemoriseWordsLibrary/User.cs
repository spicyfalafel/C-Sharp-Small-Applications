using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoriseWordsLibrary
{
    public class User
    {
        public string Login;
        public string Password;

        private List<Word> _words;
        public List<Word> Words
        {
            get
            {
                return _words.OrderByDescending(x => x.TimesAnswered).ToList();
            }
            set => _words = value.OrderByDescending(x => x.TimesAnswered).ToList();
        }

        public void AddWord(Word word)
        {
            _words.Add(word);
        }

        public User() {
            Words = new List<Word>();
        }
        public User(string log, string pass)
        {
            Words = new List<Word>();
            this.Login = log;
            this.Password = pass;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Login == user.Login &&
                   Password == user.Password;
        }

        public override int GetHashCode()
        {
            int hashCode = -1780185382;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }
    }
}
