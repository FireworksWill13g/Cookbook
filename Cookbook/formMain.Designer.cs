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
            this.SuspendLayout();
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(51, 188);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(46, 13);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(42, 229);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(357, 264);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(427, 229);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(357, 264);
            this.listIngredients.TabIndex = 3;
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(436, 188);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(59, 13);
            this.labelIngredients.TabIndex = 2;
            this.labelIngredients.Text = "Ingredients";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(42, 86);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecipe.TabIndex = 4;
            this.buttonAddRecipe.Text = "Add Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.Location = new System.Drawing.Point(42, 41);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecipeName.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 540);
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
    }
}

