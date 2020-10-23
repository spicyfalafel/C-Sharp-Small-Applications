using CookClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCookingBook
{
    public partial class Main : Form
    {
        public static CookBook BOOK;
        public Main()
        {
            InitializeComponent();
            
            BOOK = CookBook.GetFromJson();
            if(BOOK == null)
            {
                BOOK = new CookBook();
            }
            SetItemsInTree();
        }

        public void SetItemsInTree()
        {
            foreach (var rec in BOOK.recipes)
            {
                AddInTreeRecipeName(rec.category, rec.Name);
            }
        }

        private void AddInTreeRecipeName(DishCategory category, string name)
        {
            string c = category.ToString();
            TreeNode[] nodes = treeView1.Nodes.Find(c, true);
            if (nodes.Length > 0)
            {
                nodes[0].Nodes.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeForm addNewRecipe = new RecipeForm();
            addNewRecipe.Show();
            addNewRecipe.FormClosed += new FormClosedEventHandler(AddedClosed);
        }

        private void AddedClosed(object sender, FormClosedEventArgs e)
        {
            SetItemsInTree();
            //Things when closed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filter = textBox1.Text;
            if(filter != "")
            {
                foreach(var node in treeView1.Nodes)
                {
                    if (RecursiveSearch((TreeNode)node, filter)) break;
                }
            }
        }


        //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-iterate-through-all-nodes-of-a-windows-forms-treeview-control?view=netframeworkdesktop-4.8
        private bool RecursiveSearch(TreeNode node, string filter)
        {
            var nodename = node.Text.ToLower();
            if (nodename.StartsWith(filter.ToLower()))
            {
                SelectNode(node);
                return true;
            }
            foreach(TreeNode tn in node.Nodes)
            {
                string nodetxt = tn.Text.ToLower();
                if (nodetxt.StartsWith(filter.ToLower()))
                {
                    SelectNode(tn);
                    return true;
                }
                RecursiveSearch((TreeNode) tn, filter);
            }
            return false;
        }

        private void SelectNode(TreeNode node)
        {
            treeView1.Focus();
            treeView1.SelectedNode = (TreeNode)node;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BOOK.ToJson();
            MessageBox.Show("Saved in save.json file");
        }
    }
}
