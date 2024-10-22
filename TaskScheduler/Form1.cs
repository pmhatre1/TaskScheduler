using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }
        
        private void ConfigureDataGridView()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string description = descriptionBox.Text;
            string dueDate = dueDateBox.Text;
            string status = statusBox.Text;
            string priorityLevel = priorityLevelBox.Text;
            string tags = tagBox.Text;
            string reminders = reminderBox.Text;
       
        dataGridView1.Rows.Add(title,description,dueDate,status,priorityLevel,tags,reminders);
        
        }
    }
}
