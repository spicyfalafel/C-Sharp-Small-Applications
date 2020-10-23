using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotesClassLibrary
{
    public class NotesCollection
    {
        public List<Note> Notes { get; set; }
        public void AddNote(Note note)
        {
            this.Notes.Add(note);
        }
        public NotesCollection(List<Note> notes)
        {
            this.Notes = notes;
        } 

        public void RemoveNote(Note note)
        {
            this.Notes.Remove(note);
        }
        public void RemoveNoteById(long id)
        {
            Notes.Where(note => note.Id == id)
                .ToList()
                .ForEach(note => Notes.Remove(note));
        }
    }
}
