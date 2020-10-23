using NotesClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class AddNoteForm : Form
    {
        private Note UpdatedNote = null;
        public AddNoteForm(Context context, NotesAppForm form)
        {
            this.form = form;
            this.Cont = context;
            InitializeComponent();
        }
        private readonly NotesAppForm form;

        public AddNoteForm(Context context, Note note, NotesAppForm form) : this(context, form)
        {
            this.UpdatedNote = note;
            TextOfNoteBox.Text = note.Text;
            HeaderTextBox.Text = note.Header;

        }

        public Context Cont { get; }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            if (UpdatedNote != null)
            {
                Context.GetContext().NotesCollection.RemoveNote(UpdatedNote);
            }
            string header = HeaderTextBox.Text;
            string text = TextOfNoteBox.Text;
            Note note = new Note(text)
            {
                Header = header
            };
            Cont.NotesCollection.AddNote(note);
            form.RefreshNotePanels();
            this.Close();
        }
    }
}
