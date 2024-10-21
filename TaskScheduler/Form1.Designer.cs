namespace TaskScheduler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priorityLevelLabel = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.dueDateBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.priorityLevelBox = new System.Windows.Forms.TextBox();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.reminderBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dueDateBox);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.titleBox);
            this.groupBox1.Controls.Add(this.dueDateLabel);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reminderBox);
            this.groupBox2.Controls.Add(this.tagBox);
            this.groupBox2.Controls.Add(this.priorityLevelBox);
            this.groupBox2.Controls.Add(this.statusBox);
            this.groupBox2.Controls.Add(this.reminderLabel);
            this.groupBox2.Controls.Add(this.tagsLabel);
            this.groupBox2.Controls.Add(this.priorityLevelLabel);
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Location = new System.Drawing.Point(498, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(16, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(16, 47);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(75, 16);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(16, 75);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(64, 16);
            this.dueDateLabel.TabIndex = 2;
            this.dueDateLabel.Text = "Due Date";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(20, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status";
            // 
            // priorityLevelLabel
            // 
            this.priorityLevelLabel.AutoSize = true;
            this.priorityLevelLabel.Location = new System.Drawing.Point(20, 47);
            this.priorityLevelLabel.Name = "priorityLevelLabel";
            this.priorityLevelLabel.Size = new System.Drawing.Size(84, 16);
            this.priorityLevelLabel.TabIndex = 1;
            this.priorityLevelLabel.Text = "Priority Level";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Location = new System.Drawing.Point(20, 75);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(39, 16);
            this.tagsLabel.TabIndex = 2;
            this.tagsLabel.Text = "Tags";
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Location = new System.Drawing.Point(23, 105);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(73, 16);
            this.reminderLabel.TabIndex = 3;
            this.reminderLabel.Text = "Reminders";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(109, 11);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(176, 22);
            this.titleBox.TabIndex = 3;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(109, 40);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(176, 22);
            this.descriptionBox.TabIndex = 4;
            // 
            // dueDateBox
            // 
            this.dueDateBox.Location = new System.Drawing.Point(109, 68);
            this.dueDateBox.Name = "dueDateBox";
            this.dueDateBox.Size = new System.Drawing.Size(176, 22);
            this.dueDateBox.TabIndex = 5;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(133, 10);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(175, 22);
            this.statusBox.TabIndex = 4;
            // 
            // priorityLevelBox
            // 
            this.priorityLevelBox.Location = new System.Drawing.Point(133, 40);
            this.priorityLevelBox.Name = "priorityLevelBox";
            this.priorityLevelBox.Size = new System.Drawing.Size(175, 22);
            this.priorityLevelBox.TabIndex = 5;
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(133, 68);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(175, 22);
            this.tagBox.TabIndex = 6;
            // 
            // reminderBox
            // 
            this.reminderBox.Location = new System.Drawing.Point(133, 105);
            this.reminderBox.Name = "reminderBox";
            this.reminderBox.Size = new System.Drawing.Size(175, 22);
            this.reminderBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(18, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1026, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleCol,
            this.DescCol,
            this.Column3,
            this.statusCol,
            this.priorityCol,
            this.categoryCol,
            this.tagCol,
            this.reminderCol,
            this.createdDateCol,
            this.lastModifiedDateCol});
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TitleCol
            // 
            this.TitleCol.HeaderText = "Title";
            this.TitleCol.MinimumWidth = 6;
            this.TitleCol.Name = "TitleCol";
            this.TitleCol.Width = 125;
            // 
            // DescCol
            // 
            this.DescCol.HeaderText = "Description";
            this.DescCol.MinimumWidth = 6;
            this.DescCol.Name = "DescCol";
            this.DescCol.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Due Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "Status";
            this.statusCol.MinimumWidth = 6;
            this.statusCol.Name = "statusCol";
            this.statusCol.Width = 125;
            // 
            // priorityCol
            // 
            this.priorityCol.HeaderText = "Priority";
            this.priorityCol.MinimumWidth = 6;
            this.priorityCol.Name = "priorityCol";
            this.priorityCol.Width = 125;
            // 
            // categoryCol
            // 
            this.categoryCol.HeaderText = "Category";
            this.categoryCol.MinimumWidth = 6;
            this.categoryCol.Name = "categoryCol";
            this.categoryCol.Width = 125;
            // 
            // tagCol
            // 
            this.tagCol.HeaderText = "Tags";
            this.tagCol.MinimumWidth = 6;
            this.tagCol.Name = "tagCol";
            this.tagCol.Width = 125;
            // 
            // reminderCol
            // 
            this.reminderCol.HeaderText = "Reminders";
            this.reminderCol.MinimumWidth = 6;
            this.reminderCol.Name = "reminderCol";
            this.reminderCol.Width = 125;
            // 
            // createdDateCol
            // 
            this.createdDateCol.HeaderText = "Created Date";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.Width = 125;
            // 
            // lastModifiedDateCol
            // 
            this.lastModifiedDateCol.HeaderText = "Last Modified Date";
            this.lastModifiedDateCol.MinimumWidth = 6;
            this.lastModifiedDateCol.Name = "lastModifiedDateCol";
            this.lastModifiedDateCol.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Task Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.Label priorityLevelLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox dueDateBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox reminderBox;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.TextBox priorityLevelBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label reminderLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDateCol;
    }
}

