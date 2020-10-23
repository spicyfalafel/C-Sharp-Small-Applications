using NotesClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class NotePanel : Panel
    {
        public Note Note { get; set; }

        private Label noteText, header;
        
        //http://forum.codenet.ru/q44501/
        public NotePanel(Note note) : this()
        {
            this.Note = note;
            header = new Label
            {
                Text = Note.Header
            };
            header.AutoSize = true;
            header.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            this.Controls.Add(header);

            noteText = new Label
            {
                Text = note.Text
            };
            noteText.AutoSize = true;
            noteText.Location = new Point(5, 20);
            noteText.MaximumSize = new Size(250, 300);
            this.Controls.Add(noteText);
            Click += p_Click;
        }

        void p_Click(object sender, EventArgs e)
        {
            new AddNoteForm(Context.GetContext(), Note, (NotesAppForm) this.FindForm()).Show();
        }
        public NotePanel()
        {
            this.BackColor = Color.OldLace;
            Size = new Size(250, 300);

            string buttonImagePath = Path.Combine(Directory.GetCurrentDirectory(), "../../..") + "/close.png";
            // red X on top
            Button butt = new Button
            {
                Size = new Size(30, 30),
                BackgroundImage = Image.FromFile(buttonImagePath),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            butt.Location = new Point(250 - butt.Width, 0);
            butt.Click += Butt_Click;

            this.Controls.Add(butt);
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            Context.GetContext().NotesCollection.RemoveNote(Note);
            ((Panel)Parent).Controls.Remove(this);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
