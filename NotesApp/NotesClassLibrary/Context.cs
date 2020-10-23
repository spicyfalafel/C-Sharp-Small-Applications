using System;
using System.Collections.Generic;
using System.Text;

namespace NotesClassLibrary
{

    public class Context
    {
        public NotesCollection NotesCollection { get; set; }

        private static Context instance = null;
        private static readonly object padlock = new object();

        Context()
        {
            NotesCollection = new NotesCollection(MyNotesFileHandler.GetFromFileDefault());
        }

        //https://csharpindepth.com/articles/singleton
        public static Context GetContext()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Context();
                }
                return instance;
            }
        }

    }
}
