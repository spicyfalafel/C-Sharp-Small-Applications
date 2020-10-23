namespace Schedule
{
    partial class ScheduleForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.todayPanel = new System.Windows.Forms.Panel();
            this.TodayCheckedList = new Schedule.CheckedListWithWhiteItems();
            this.todayGroup = new System.Windows.Forms.GroupBox();
            this.todaySubmitButton = new System.Windows.Forms.Button();
            this.todayTaskText = new System.Windows.Forms.TextBox();
            this.taskLabel = new Schedule.CustomLabel();
            this.yesterdayPanel = new System.Windows.Forms.Panel();
            this.YesterdayCheckedList = new Schedule.CheckedListWithWhiteItems();
            this.yesterdayGroup = new System.Windows.Forms.GroupBox();
            this.yesterdaySubmit = new System.Windows.Forms.Button();
            this.yesterdayText = new System.Windows.Forms.TextBox();
            this.customLabel4 = new Schedule.CustomLabel();
            this.yesterdayLabel = new Schedule.CustomLabel();
            this.todayLabel = new Schedule.CustomLabel();
            this.tomorrowLabel = new Schedule.CustomLabel();
            this.tomorrowPanel = new System.Windows.Forms.Panel();
            this.TomorrowCheckedList = new Schedule.CheckedListWithWhiteItems();
            this.tomorrowGroup = new System.Windows.Forms.GroupBox();
            this.tomorrowTaskText = new System.Windows.Forms.TextBox();
            this.tomorrowSubmitButton = new System.Windows.Forms.Button();
            this.customLabel1 = new Schedule.CustomLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.history = new System.Windows.Forms.ToolStripMenuItem();
            this.personalTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.todayPanel.SuspendLayout();
            this.todayGroup.SuspendLayout();
            this.yesterdayPanel.SuspendLayout();
            this.yesterdayGroup.SuspendLayout();
            this.tomorrowPanel.SuspendLayout();
            this.tomorrowGroup.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.todayPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yesterdayPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.yesterdayLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.todayLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tomorrowLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tomorrowPanel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            
            // 
            // todayPanel
            // 
            this.todayPanel.Controls.Add(this.TodayCheckedList);
            this.todayPanel.Controls.Add(this.todayGroup);
            this.todayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayPanel.Location = new System.Drawing.Point(265, 47);
            this.todayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayPanel.Name = "todayPanel";
            this.todayPanel.Size = new System.Drawing.Size(252, 474);
            this.todayPanel.TabIndex = 13;
            // 
            // TodayCheckedList
            // 
            this.TodayCheckedList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TodayCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodayCheckedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TodayCheckedList.ForeColor = System.Drawing.Color.White;
            this.TodayCheckedList.FormattingEnabled = true;
            this.TodayCheckedList.Location = new System.Drawing.Point(0, 0);
            this.TodayCheckedList.Margin = new System.Windows.Forms.Padding(4);
            this.TodayCheckedList.Name = "TodayCheckedList";
            this.TodayCheckedList.Size = new System.Drawing.Size(252, 352);
            this.TodayCheckedList.TabIndex = 8;
            this.TodayCheckedList.SelectedIndexChanged += new System.EventHandler(this.TodayCheckedList_SelectedIndexChanged);
            // 
            // todayGroup
            // 
            this.todayGroup.Controls.Add(this.todaySubmitButton);
            this.todayGroup.Controls.Add(this.todayTaskText);
            this.todayGroup.Controls.Add(this.taskLabel);
            this.todayGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.todayGroup.Location = new System.Drawing.Point(0, 352);
            this.todayGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayGroup.Name = "todayGroup";
            this.todayGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayGroup.Size = new System.Drawing.Size(252, 122);
            this.todayGroup.TabIndex = 7;
            this.todayGroup.TabStop = false;
            this.todayGroup.Text = "Add task";
            // 
            // todaySubmitButton
            // 
            this.todaySubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todaySubmitButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.todaySubmitButton.Location = new System.Drawing.Point(101, 79);
            this.todaySubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todaySubmitButton.Name = "todaySubmitButton";
            this.todaySubmitButton.Size = new System.Drawing.Size(68, 30);
            this.todaySubmitButton.TabIndex = 5;
            this.todaySubmitButton.Text = "Submit";
            this.todaySubmitButton.UseVisualStyleBackColor = true;
            this.todaySubmitButton.Click += new System.EventHandler(this.TodaySubmitButton_Click);
            // 
            // todayTaskText
            // 
            this.todayTaskText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayTaskText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.todayTaskText.Location = new System.Drawing.Point(16, 49);
            this.todayTaskText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayTaskText.Multiline = true;
            this.todayTaskText.Name = "todayTaskText";
            this.todayTaskText.Size = new System.Drawing.Size(220, 24);
            this.todayTaskText.TabIndex = 4;
            // 
            // taskLabel
            // 
            this.taskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.taskLabel.ForeColor = System.Drawing.Color.White;
            this.taskLabel.Location = new System.Drawing.Point(105, 23);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(60, 25);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Task";
            // 
            // yesterdayPanel
            // 
            this.yesterdayPanel.Controls.Add(this.YesterdayCheckedList);
            this.yesterdayPanel.Controls.Add(this.yesterdayGroup);
            this.yesterdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesterdayPanel.Location = new System.Drawing.Point(5, 47);
            this.yesterdayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesterdayPanel.Name = "yesterdayPanel";
            this.yesterdayPanel.Size = new System.Drawing.Size(252, 474);
            this.yesterdayPanel.TabIndex = 12;
            // 
            // YesterdayCheckedList
            // 
            this.YesterdayCheckedList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.YesterdayCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YesterdayCheckedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.YesterdayCheckedList.ForeColor = System.Drawing.Color.White;
            this.YesterdayCheckedList.FormattingEnabled = true;
            this.YesterdayCheckedList.Location = new System.Drawing.Point(0, 0);
            this.YesterdayCheckedList.Margin = new System.Windows.Forms.Padding(4);
            this.YesterdayCheckedList.Name = "YesterdayCheckedList";
            this.YesterdayCheckedList.Size = new System.Drawing.Size(252, 352);
            this.YesterdayCheckedList.TabIndex = 9;
            this.YesterdayCheckedList.SelectedIndexChanged += new System.EventHandler(this.CheckedListWithWhiteItems3_SelectedIndexChanged);
            // 
            // yesterdayGroup
            // 
            this.yesterdayGroup.Controls.Add(this.yesterdaySubmit);
            this.yesterdayGroup.Controls.Add(this.yesterdayText);
            this.yesterdayGroup.Controls.Add(this.customLabel4);
            this.yesterdayGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yesterdayGroup.Location = new System.Drawing.Point(0, 352);
            this.yesterdayGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesterdayGroup.Name = "yesterdayGroup";
            this.yesterdayGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesterdayGroup.Size = new System.Drawing.Size(252, 122);
            this.yesterdayGroup.TabIndex = 7;
            this.yesterdayGroup.TabStop = false;
            this.yesterdayGroup.Text = "Add task";
            // 
            // yesterdaySubmit
            // 
            this.yesterdaySubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yesterdaySubmit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.yesterdaySubmit.Location = new System.Drawing.Point(91, 79);
            this.yesterdaySubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesterdaySubmit.Name = "yesterdaySubmit";
            this.yesterdaySubmit.Size = new System.Drawing.Size(68, 30);
            this.yesterdaySubmit.TabIndex = 4;
            this.yesterdaySubmit.Text = "Submit";
            this.yesterdaySubmit.UseVisualStyleBackColor = true;
            this.yesterdaySubmit.Click += new System.EventHandler(this.YesterdaySubmit_Click);
            // 
            // yesterdayText
            // 
            this.yesterdayText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yesterdayText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.yesterdayText.Location = new System.Drawing.Point(16, 49);
            this.yesterdayText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesterdayText.Multiline = true;
            this.yesterdayText.Name = "yesterdayText";
            this.yesterdayText.Size = new System.Drawing.Size(220, 24);
            this.yesterdayText.TabIndex = 3;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.Location = new System.Drawing.Point(105, 23);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(60, 25);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Task";
            // 
            // yesterdayLabel
            // 
            this.yesterdayLabel.AutoSize = true;
            this.yesterdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesterdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yesterdayLabel.ForeColor = System.Drawing.Color.White;
            this.yesterdayLabel.Location = new System.Drawing.Point(5, 2);
            this.yesterdayLabel.Name = "yesterdayLabel";
            this.yesterdayLabel.Size = new System.Drawing.Size(252, 41);
            this.yesterdayLabel.TabIndex = 5;
            this.yesterdayLabel.Text = "Yesterday";
            this.yesterdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(265, 2);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(252, 41);
            this.todayLabel.TabIndex = 4;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.AutoSize = true;
            this.tomorrowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tomorrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tomorrowLabel.ForeColor = System.Drawing.Color.White;
            this.tomorrowLabel.Location = new System.Drawing.Point(525, 2);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(252, 41);
            this.tomorrowLabel.TabIndex = 3;
            this.tomorrowLabel.Text = "Tomorrow";
            this.tomorrowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tomorrowPanel
            // 
            this.tomorrowPanel.Controls.Add(this.TomorrowCheckedList);
            this.tomorrowPanel.Controls.Add(this.tomorrowGroup);
            this.tomorrowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tomorrowPanel.Location = new System.Drawing.Point(525, 47);
            this.tomorrowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tomorrowPanel.Name = "tomorrowPanel";
            this.tomorrowPanel.Size = new System.Drawing.Size(252, 474);
            this.tomorrowPanel.TabIndex = 11;
            // 
            // TomorrowCheckedList
            // 
            this.TomorrowCheckedList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TomorrowCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TomorrowCheckedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TomorrowCheckedList.ForeColor = System.Drawing.Color.White;
            this.TomorrowCheckedList.FormattingEnabled = true;
            this.TomorrowCheckedList.Location = new System.Drawing.Point(0, 0);
            this.TomorrowCheckedList.Margin = new System.Windows.Forms.Padding(4);
            this.TomorrowCheckedList.Name = "TomorrowCheckedList";
            this.TomorrowCheckedList.Size = new System.Drawing.Size(252, 352);
            this.TomorrowCheckedList.TabIndex = 9;
            this.TomorrowCheckedList.SelectedIndexChanged += new System.EventHandler(this.TomorrowCheckedList_SelectedIndexChanged);
            // 
            // tomorrowGroup
            // 
            this.tomorrowGroup.Controls.Add(this.tomorrowTaskText);
            this.tomorrowGroup.Controls.Add(this.tomorrowSubmitButton);
            this.tomorrowGroup.Controls.Add(this.customLabel1);
            this.tomorrowGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tomorrowGroup.Location = new System.Drawing.Point(0, 352);
            this.tomorrowGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tomorrowGroup.Name = "tomorrowGroup";
            this.tomorrowGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tomorrowGroup.Size = new System.Drawing.Size(252, 122);
            this.tomorrowGroup.TabIndex = 7;
            this.tomorrowGroup.TabStop = false;
            this.tomorrowGroup.Text = "Add task";
            // 
            // tomorrowTaskText
            // 
            this.tomorrowTaskText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tomorrowTaskText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tomorrowTaskText.Location = new System.Drawing.Point(21, 53);
            this.tomorrowTaskText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tomorrowTaskText.Multiline = true;
            this.tomorrowTaskText.Name = "tomorrowTaskText";
            this.tomorrowTaskText.Size = new System.Drawing.Size(212, 24);
            this.tomorrowTaskText.TabIndex = 6;
            // 
            // tomorrowSubmitButton
            // 
            this.tomorrowSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tomorrowSubmitButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tomorrowSubmitButton.Location = new System.Drawing.Point(99, 79);
            this.tomorrowSubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tomorrowSubmitButton.Name = "tomorrowSubmitButton";
            this.tomorrowSubmitButton.Size = new System.Drawing.Size(68, 30);
            this.tomorrowSubmitButton.TabIndex = 5;
            this.tomorrowSubmitButton.Text = "Submit";
            this.tomorrowSubmitButton.UseVisualStyleBackColor = true;
            this.tomorrowSubmitButton.Click += new System.EventHandler(this.TomorrowSubmitButton_Click);
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(104, 25);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(60, 25);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "Task";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options,
            this.history});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(782, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // options
            // 
            this.options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(46, 24);
            this.options.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveToFileToolStripMenuItem.Text = "Save to file...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // history
            // 
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(70, 24);
            this.history.Text = "History";
            this.history.Click += new System.EventHandler(this.AndHereToolStripMenuItem_Click);
            // 
            // personalTaskBindingSource
            // 
            this.personalTaskBindingSource.DataSource = typeof(ScheduleLib.PersonalTask);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScheduleForm";
            this.Text = "Scheduler";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.todayPanel.ResumeLayout(false);
            this.todayGroup.ResumeLayout(false);
            this.todayGroup.PerformLayout();
            this.yesterdayPanel.ResumeLayout(false);
            this.yesterdayGroup.ResumeLayout(false);
            this.yesterdayGroup.PerformLayout();
            this.tomorrowPanel.ResumeLayout(false);
            this.tomorrowGroup.ResumeLayout(false);
            this.tomorrowGroup.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomLabel tomorrowLabel;
        private CustomLabel yesterdayLabel;
        private CustomLabel todayLabel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripMenuItem history;
        private System.Windows.Forms.Panel tomorrowPanel;
        private System.Windows.Forms.GroupBox tomorrowGroup;
        private CustomLabel customLabel1;
        private System.Windows.Forms.Panel yesterdayPanel;
        private System.Windows.Forms.GroupBox yesterdayGroup;
        private CustomLabel customLabel4;
        private System.Windows.Forms.Button yesterdaySubmit;
        private System.Windows.Forms.TextBox yesterdayText;
        private System.Windows.Forms.TextBox tomorrowTaskText;
        private System.Windows.Forms.Button tomorrowSubmitButton;
        private System.Windows.Forms.Panel todayPanel;
        private System.Windows.Forms.GroupBox todayGroup;
        private System.Windows.Forms.Button todaySubmitButton;
        private System.Windows.Forms.TextBox todayTaskText;
        private CustomLabel taskLabel;
        private System.Windows.Forms.BindingSource personalTaskBindingSource;
        private CheckedListWithWhiteItems TodayCheckedList;
        private CheckedListWithWhiteItems YesterdayCheckedList;
        private CheckedListWithWhiteItems TomorrowCheckedList;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}