using SportLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExercisesBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        BookOfSport book;

        private void MainForm_Load(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            book = saver.GetBookFile(Directory.GetCurrentDirectory() + "/BookSave.json");
            if (book.Exercises == null || book.Exercises.Count == 0) {
                book = new BookOfSport();
            }
            listBoxChest.SelectedValueChanged += new EventHandler(Clicked);
            listBoxArms.SelectedValueChanged += new EventHandler(Clicked);
            listBoxBack.SelectedValueChanged += new EventHandler(Clicked);
            listBoxButt.SelectedValueChanged += new EventHandler(Clicked);
            listBoxLegs.SelectedValueChanged += new EventHandler(Clicked);
            listBoxNeck.SelectedValueChanged += new EventHandler(Clicked);
            listBoxOther.SelectedValueChanged += new EventHandler(Clicked);
            listBoxPress.SelectedValueChanged += new EventHandler(Clicked);

            PopulateListBoxes();
        }

        public void PopulateListBoxes()
        {
            PopulateListBox(book.FindByCategory(ExerciseCategory.Chest), listBoxChest);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Arms), listBoxArms);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Back), listBoxBack);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Butt), listBoxButt);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Legs), listBoxLegs);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Neck), listBoxNeck);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Press), listBoxPress);
            PopulateListBox(book.FindByCategory(ExerciseCategory.Other), listBoxOther);
        }
        public void PopulateListBox(List<Exercise> exercises, ListBox listBox)
        {
            //https://www.codeproject.com/Questions/348044/mouseclick-event-on-listbox-item-in-csharp-visual
            
            listBox.Items.Clear();
            listBox.Font = new Font(listBox.Font.Name, 18);
            foreach (var ex in exercises)
            {
                listBox.Items.Add(ex.NameOfExercise);
            }
            
        }

        void Clicked(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            if (listbox.SelectedItem != null)
            {
                var show = new ShowExerciseForm(book.FindByName(listbox.SelectedItem.ToString()), book, this);
                show.NameImmune(true);
                show.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string catString = tabControl1.SelectedTab.Name;
            //https://stackoverflow.com/questions/23563960/how-to-get-enum-value-by-string-or-int
            ExerciseCategory category = (ExerciseCategory) Enum.Parse(typeof(ExerciseCategory), catString);
            var show = new ShowExerciseForm(new Exercise(category, "My new exercise"), book, this);
            show.NameImmune(true);
            show.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            saver.SaveToFile(book, Directory.GetCurrentDirectory() + "/BookSave.json");
            MessageBox.Show("Book saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();

            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
            saveFileDialog1.Filter = "Json files (*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var myStream = saveFileDialog1.OpenFile();
                if ( myStream!= null)
                {
                    string fileName = saveFileDialog1.FileName;
                    saver.writeDataToFile(fileName, book);
                    myStream.Close();
                }
            }
            MessageBox.Show("Book saved to " +saveFileDialog1.FileName);
        }
    }
}
