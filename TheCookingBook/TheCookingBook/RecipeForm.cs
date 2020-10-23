using CookClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheCookingBook
{
    public partial class RecipeForm : Form
    {
        public RecipeForm()
        {
            InitializeComponent();
        }

        private readonly List<Ingredient> list = new List<Ingredient>();

        private void Recipe_Load(object sender, EventArgs e)
        {
            CategoryChoose.DataSource = Enum.GetValues(typeof(DishCategory));
            AmountWhat.DataSource = Enum.GetValues(typeof(Measure));
        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            string desc = Description.Text;
            DishCategory cat = (DishCategory) Enum.Parse(typeof(DishCategory), CategoryChoose.Text);
            Recipe rec = new Recipe(name, cat, list);
            rec.Description = desc;
            Main.BOOK.recipes.Add(rec);
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try { 
                string name = ingredient.Text;
                Measure m = (Measure) AmountWhat.SelectedItem;
                int num = (int) AmountNumber.Value;
                Ingredient i = new Ingredient(name, m, num);
                IngredientsList.Items.Add(i);
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter all information. Also error is" + ex.Message);
            }
        }
    }
}
