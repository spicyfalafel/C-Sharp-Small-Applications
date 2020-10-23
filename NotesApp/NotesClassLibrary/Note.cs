using System;

namespace NotesClassLibrary
{
    public class Note
    {
        public long Id { get; }

        public string Header { get; set; }
        public  string Text { get; set; }
        
        public Note(string text)
        {
            this.Text = text;
            this.Id = GenerateID();
            this.Header = "";
        }

        public Note()
        {
            this.Text = "";
            this.Id = GenerateID();
            this.Header = "";
        }

        private static long IdToGenerate = 0;
        private static long GenerateID()
        {
            return IdToGenerate++;
        }
    }
}
