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
            var inputValues = new Dictionary<string, string>()
            {
                {   "Title",titleBox.Text},
                { "Description", descriptionBox.Text},
                { "Due Date",dueDateBox.Text },
                {"Status",statusBox.Text},
                {"Priority",priorityLevelBox.Text },
                {"Tags",tagBox.Text},
                {"Reminders",reminderBox.Text}

            };
            object[] rowValues = new object[dataGridView1.Columns.Count];
            
            for(int i =0; i<dataGridView1.Columns.Count; i++) 
                {
                    string columnName = dataGridView1.Columns[i].Name;
                    if (inputValues.ContainsKey(columnName))
                    {
                        rowValues[i] = inputValues[columnName];
                    }
                }

             dataGridView1.Rows.Add(rowValues);

            
        }
    }
}
