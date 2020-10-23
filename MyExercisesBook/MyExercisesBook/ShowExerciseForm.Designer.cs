namespace MyExercisesBook
{
    partial class ShowExerciseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Sets = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TimesNumber = new System.Windows.Forms.NumericUpDown();
            this.SetsNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TimesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // Sets
            // 
            this.Sets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sets.AutoSize = true;
            this.Sets.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sets.Location = new System.Drawing.Point(363, 173);
            this.Sets.Name = "Sets";
            this.Sets.Size = new System.Drawing.Size(80, 41);
            this.Sets.TabIndex = 2;
            this.Sets.Text = "Sets:";
            // 
            // Times
            // 
            this.Times.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Times.AutoSize = true;
            this.Times.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Times.Location = new System.Drawing.Point(535, 173);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(103, 41);
            this.Times.TabIndex = 2;
            this.Times.Text = "Times:";
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description.Location = new System.Drawing.Point(91, 257);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(547, 120);
            this.Description.TabIndex = 3;
            this.Description.Text = "";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmButton.Location = new System.Drawing.Point(363, 397);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(94, 29);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(91, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(547, 61);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimesNumber
            // 
            this.TimesNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimesNumber.Location = new System.Drawing.Point(633, 187);
            this.TimesNumber.Name = "TimesNumber";
            this.TimesNumber.Size = new System.Drawing.Size(52, 27);
            this.TimesNumber.TabIndex = 6;
            // 
            // SetsNumber
            // 
            this.SetsNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetsNumber.Location = new System.Drawing.Point(438, 187);
            this.SetsNumber.Name = "SetsNumber";
            this.SetsNumber.Size = new System.Drawing.Size(52, 27);
            this.SetsNumber.TabIndex = 6;
            // 
            // ShowExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetsNumber);
            this.Controls.Add(this.TimesNumber);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Sets);
            this.Controls.Add(this.label2);
            this.Name = "ShowExerciseForm";
            this.Text = "Exercise";
            this.Load += new System.EventHandler(this.ShowExerciseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sets;
        private System.Windows.Forms.Label Times;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown TimesNumber;
        private System.Windows.Forms.NumericUpDown SetsNumber;
    }
}