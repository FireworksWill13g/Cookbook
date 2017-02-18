namespace Cookbook
{
    partial class FormMain
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
            this.lblRecipes = new System.Windows.Forms.Label();
            this.listRecipes = new System.Windows.Forms.ListBox();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.buttonUpdateName = new System.Windows.Forms.Button();
            this.listBoxAllIngredients = new System.Windows.Forms.ListBox();
            this.labelAllIngredients = new System.Windows.Forms.Label();
            this.buttonAddToRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(39, 132);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(46, 13);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(42, 148);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(153, 82);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(42, 258);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(153, 225);
            this.listIngredients.TabIndex = 3;
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(39, 242);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(59, 13);
            this.labelIngredients.TabIndex = 2;
            this.labelIngredients.Text = "Ingredients";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(42, 90);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecipe.TabIndex = 4;
            this.buttonAddRecipe.Text = "Add Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.Location = new System.Drawing.Point(42, 64);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(197, 20);
            this.textBoxRecipeName.TabIndex = 5;
            // 
            // buttonUpdateName
            // 
            this.buttonUpdateName.Location = new System.Drawing.Point(123, 90);
            this.buttonUpdateName.Name = "buttonUpdateName";
            this.buttonUpdateName.Size = new System.Drawing.Size(116, 23);
            this.buttonUpdateName.TabIndex = 6;
            this.buttonUpdateName.Text = "Update Name";
            this.buttonUpdateName.UseVisualStyleBackColor = true;
            this.buttonUpdateName.Click += new System.EventHandler(this.buttonUpdateName_Click);
            // 
            // listBoxAllIngredients
            // 
            this.listBoxAllIngredients.FormattingEnabled = true;
            this.listBoxAllIngredients.Location = new System.Drawing.Point(263, 148);
            this.listBoxAllIngredients.Name = "listBoxAllIngredients";
            this.listBoxAllIngredients.Size = new System.Drawing.Size(153, 225);
            this.listBoxAllIngredients.TabIndex = 8;
            // 
            // labelAllIngredients
            // 
            this.labelAllIngredients.AutoSize = true;
            this.labelAllIngredients.Location = new System.Drawing.Point(260, 132);
            this.labelAllIngredients.Name = "labelAllIngredients";
            this.labelAllIngredients.Size = new System.Drawing.Size(59, 13);
            this.labelAllIngredients.TabIndex = 7;
            this.labelAllIngredients.Text = "Ingredients";
            // 
            // buttonAddToRecipe
            // 
            this.buttonAddToRecipe.Location = new System.Drawing.Point(341, 379);
            this.buttonAddToRecipe.Name = "buttonAddToRecipe";
            this.buttonAddToRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToRecipe.TabIndex = 9;
            this.buttonAddToRecipe.Text = "Add To Recipe";
            this.buttonAddToRecipe.UseVisualStyleBackColor = true;
            this.buttonAddToRecipe.Click += new System.EventHandler(this.buttonAddToRecipe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 540);
            this.Controls.Add(this.buttonAddToRecipe);
            this.Controls.Add(this.listBoxAllIngredients);
            this.Controls.Add(this.labelAllIngredients);
            this.Controls.Add(this.buttonUpdateName);
            this.Controls.Add(this.textBoxRecipeName);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Name = "FormMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox listRecipes;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.TextBox textBoxRecipeName;
        private System.Windows.Forms.Button buttonUpdateName;
        private System.Windows.Forms.ListBox listBoxAllIngredients;
        private System.Windows.Forms.Label labelAllIngredients;
        private System.Windows.Forms.Button buttonAddToRecipe;
    }
}

