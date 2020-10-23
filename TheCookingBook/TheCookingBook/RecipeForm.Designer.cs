namespace TheCookingBook
{
    partial class RecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IngredientsList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ingredient = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AmountNumber = new System.Windows.Forms.NumericUpDown();
            this.AmountWhat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.AddRecipe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CategoryChoose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipe";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Coral;
            this.groupBox3.Controls.Add(this.IngredientsList);
            this.groupBox3.Location = new System.Drawing.Point(360, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 197);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of ingredients";
            // 
            // IngredientsList
            // 
            this.IngredientsList.FormattingEnabled = true;
            this.IngredientsList.ItemHeight = 20;
            this.IngredientsList.Location = new System.Drawing.Point(17, 25);
            this.IngredientsList.Name = "IngredientsList";
            this.IngredientsList.Size = new System.Drawing.Size(357, 164);
            this.IngredientsList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Coral;
            this.groupBox2.Controls.Add(this.ingredient);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.AmountNumber);
            this.groupBox2.Controls.Add(this.AmountWhat);
            this.groupBox2.Location = new System.Drawing.Point(17, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 197);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add ingredient";
            // 
            // ingredient
            // 
            this.ingredient.Location = new System.Drawing.Point(41, 19);
            this.ingredient.Name = "ingredient";
            this.ingredient.Size = new System.Drawing.Size(191, 27);
            this.ingredient.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(41, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(191, 46);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add ingredient";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AmountNumber
            // 
            this.AmountNumber.Location = new System.Drawing.Point(41, 59);
            this.AmountNumber.Name = "AmountNumber";
            this.AmountNumber.Size = new System.Drawing.Size(58, 27);
            this.AmountNumber.TabIndex = 5;
            this.AmountNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AmountWhat
            // 
            this.AmountWhat.FormattingEnabled = true;
            this.AmountWhat.Location = new System.Drawing.Point(160, 58);
            this.AmountWhat.Name = "AmountWhat";
            this.AmountWhat.Size = new System.Drawing.Size(72, 28);
            this.AmountWhat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose category";
            // 
            // CategoryChoose
            // 
            this.CategoryChoose.FormattingEnabled = true;
            this.CategoryChoose.Location = new System.Drawing.Point(191, 30);
            this.CategoryChoose.Name = "CategoryChoose";
            this.CategoryChoose.Size = new System.Drawing.Size(151, 28);
            this.CategoryChoose.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of dish";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(6, 97);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(291, 30);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here you can describe how to cook a meal";
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(360, 69);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(393, 135);
            this.Description.TabIndex = 0;
            this.Description.Text = "";
            // 
            // AddRecipe
            // 
            this.AddRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddRecipe.BackColor = System.Drawing.Color.Coral;
            this.AddRecipe.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddRecipe.Location = new System.Drawing.Point(28, 455);
            this.AddRecipe.Name = "AddRecipe";
            this.AddRecipe.Size = new System.Drawing.Size(736, 61);
            this.AddRecipe.TabIndex = 1;
            this.AddRecipe.Text = "Add my cool recipe";
            this.AddRecipe.UseVisualStyleBackColor = false;
            this.AddRecipe.Click += new System.EventHandler(this.AddRecipe_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.AddRecipe);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "RecipeForm";
            this.Text = "AddNewRecipe";
            this.Load += new System.EventHandler(this.Recipe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox AmountWhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoryChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox IngredientsList;
        private System.Windows.Forms.NumericUpDown AmountNumber;
        private System.Windows.Forms.Button AddRecipe;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ingredient;
    }
}