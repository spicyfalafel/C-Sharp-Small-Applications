using NotesClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class NotesAppForm : Form
    {
        private Context Context;
        public NotesAppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Context = Context.GetContext();
            RefreshNotePanels();
        }

        public void RefreshNotePanels()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach(var note in Context.NotesCollection.Notes){
                flowLayoutPanel1.Controls.Add(new NotePanel(note));
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        //just save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyNotesFileHandler.SerializeToXmlDefault(Context.NotesCollection.Notes);
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void NoteStripMenu_Click(object sender, EventArgs e)
        {
            new AddNoteForm(Context, (NotesAppForm) this.FindForm()).Show();
        }
    }
}
