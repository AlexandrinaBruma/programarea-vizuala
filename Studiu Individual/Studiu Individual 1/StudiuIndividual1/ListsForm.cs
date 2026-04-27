using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static StudiuIndividual1.homeForm;

namespace StudiuIndividual1
{
    public partial class ViewForm : Form
    {
    public ViewForm()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PetShop;Integrated Security=True";
        private void infoText_Click(object sender, EventArgs e)
        {

        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void animalListButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Animal";
            LoadData(query);
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
        }

        private void clientListButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Client";
            LoadData(query);
        }

        private void servicesListButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Serviciu";
            LoadData(query);
        }

        private void campListButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Tabara_de_zi";
            LoadData(query);
        }

        private void shopsListButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Magazin";
            LoadData(query);
        }


        private void LoadData(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dataGridView1.DataSource = null; 
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
