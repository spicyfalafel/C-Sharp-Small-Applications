namespace NotesApp
{
    partial class AddNoteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextOfNoteBox = new System.Windows.Forms.RichTextBox();
            this.HeaderTextBox = new System.Windows.Forms.TextBox();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.TextOfNoteBox);
            this.panel1.Controls.Add(this.HeaderTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 407);
            this.panel1.TabIndex = 0;
            // 
            // TextOfNoteBox
            // 
            this.TextOfNoteBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextOfNoteBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextOfNoteBox.Location = new System.Drawing.Point(10, 73);
            this.TextOfNoteBox.Name = "TextOfNoteBox";
            this.TextOfNoteBox.Size = new System.Drawing.Size(780, 324);
            this.TextOfNoteBox.TabIndex = 3;
            this.TextOfNoteBox.Text = "This is sample text";
            // 
            // HeaderTextBox
            // 
            this.HeaderTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderTextBox.Location = new System.Drawing.Point(10, 10);
            this.HeaderTextBox.Name = "HeaderTextBox";
            this.HeaderTextBox.Size = new System.Drawing.Size(780, 42);
            this.HeaderTextBox.TabIndex = 2;
            this.HeaderTextBox.Text = "Header";
            this.HeaderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Location = new System.Drawing.Point(358, 413);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(94, 29);
            this.AddNoteButton.TabIndex = 1;
            this.AddNoteButton.Text = "Add Note";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.panel1);
            this.Name = "AddNoteForm";
            this.Text = "Add note";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox HeaderTextBox;
        private System.Windows.Forms.RichTextBox TextOfNoteBox;
        private System.Windows.Forms.Button AddNoteButton;
    }
}