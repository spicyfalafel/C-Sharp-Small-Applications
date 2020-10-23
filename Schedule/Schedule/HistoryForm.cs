using ScheduleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class HistoryForm : Form
    {
        private readonly Manager manager;
        public HistoryForm(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var allTasks = manager.History.AllTasks;
            dataGridView1.DataSource = allTasks; 
        }
    }
}
