using SportLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyExercisesBook
{
    public partial class ShowExerciseForm : Form
    {
        public ShowExerciseForm()
        {
            InitializeComponent();
        }

        Exercise current;
        BookOfSport book;
        MainForm form;
        ExerciseCategory chosen = ExerciseCategory.Other; // TODO 
        public ShowExerciseForm(Exercise ex, BookOfSport book, MainForm form): this()
        {
            this.form = form;
            this.book = book;
            current = ex;
        }

        public void NameImmune(bool yes)
        {
            NameTextBox.Enabled = yes;
        }

        private void ShowExerciseForm_Load(object sender, EventArgs e)
        {
            if (current != null)
            {
                TimesNumber.Value = current.timesInSet;
                SetsNumber.Value = current.sets;
                NameTextBox.Text = current.NameOfExercise;
                Description.Text = current.Description;
            }
            
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(current == null)
            {
                current = new Exercise(chosen, "");
            }
            current.Description = Description.Text;
            current.NameOfExercise = NameTextBox.Text;
            current.sets = (int) SetsNumber.Value;
            current.timesInSet = (int)TimesNumber.Value;
            book.AddExercise(current);
            form.PopulateListBoxes();
            this.Close();
        }
    }
}
