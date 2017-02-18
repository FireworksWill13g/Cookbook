using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cookbook
{
    public partial class FormMain : Form
    {
        string connectionString;
        SqlConnection connection;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateIngredients();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);
                listRecipes.DisplayMember = "Name";
                listRecipes.ValueMember = "Id";
                listRecipes.DataSource = recipeTable;               
            }

            
        }

        private void PopulateIngredients()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingredient", connection))
            {
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);
                listBoxAllIngredients.DisplayMember = "Name";
                listBoxAllIngredients.ValueMember = "Id";
                listBoxAllIngredients.DataSource = ingredientTable;
            }


        }

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIngredients();
        }
        

        private void GetIngredients()
        {
            string query =  "SELECT a.Name FROM Ingredient a " +
                            "JOIN RecipeIngredient b on a.Id = b.IngredientId "+
                            "WHERE b.RecipeId = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);
                listIngredients.DisplayMember = "Name";
                listIngredients.ValueMember = "Id";
                listIngredients.DataSource = ingredientTable;
            }


        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES(@RecipeName, 80, 'textHere')";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open(); //needed because no data adapter***
                command.Parameters.AddWithValue("@RecipeName", textBoxRecipeName.Text);
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }

        //to be turned into right click context menu, reusable based on object clicked.
        private void buttonUpdateName_Click(object sender, EventArgs e)
        {
            string query =  "UPDATE Recipe SET Name  = @RecipeName "+
                            "WHERE Id = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open(); //needed because no data adapter***
                command.Parameters.AddWithValue("@RecipeName", textBoxRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }

        private void buttonAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient VALUES(@RecipeId, @IngredientId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open(); //needed because no data adapter***
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listBoxAllIngredients.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }
    }
}
