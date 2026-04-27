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
using static StudiuIndividual1.ViewForm;

namespace StudiuIndividual1
{
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS;Database=PetShop;Integrated Security=True";

        private void AnimalForm_Load(object sender, EventArgs e)
        {

        }

        private void introText_Click(object sender, EventArgs e)
        {

        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ownerTextBox.Text, out int IdStapan))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "ID-ul stăpânului trebuie să fie un număr.";
                statusLabel.Show();
                return;
            }

            string nume = nameTextBox.Text.Trim();
            string specia = speciesTextBox.Text.Trim();
            string contraindicatii = intollerancesTextBox.Text.Trim();
            DateTime dataNasterii = birthBox.Value;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(specia))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Numele și specia sunt obligatorii.";
                statusLabel.Show();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Client WHERE ID_client = @IdStapan";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IdStapan", IdStapan);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Nu există un client cu acest ID.";
                            statusLabel.Show();
                            return;
                        }
                    }

                    string query = @"INSERT INTO Animal (Nume, Data_nasterii, Specie, Contraindicatii, Stapan)
                             VALUES (@Nume, @Data_nasterii, @Specie, @Contraindicatii, @Stapan)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cmd.Parameters.AddWithValue("@Data_nasterii", dataNasterii);
                        cmd.Parameters.AddWithValue("@Specie", specia);
                        cmd.Parameters.AddWithValue("@Contraindicatii", contraindicatii);
                        cmd.Parameters.AddWithValue("@Stapan", IdStapan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            statusLabel.ForeColor = Color.Green;
                            statusLabel.Text = "Animalul a fost adăugat cu succes!";
                            statusLabel.Show();
                            ClearFields();
                        }
                        else
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Inserarea a eșuat. Încearcă din nou.";
                            statusLabel.Show();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "SQL Error"); 
                statusLabel.Text = "Eroare: " + ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Error");
                statusLabel.Text = "Eroare: " + ex.Message;
            }


            Console.WriteLine("Button clicked");
        }

        private void ClearFields()
        {
            nameTextBox.Clear();
            speciesTextBox.Clear();
            intollerancesTextBox.Clear();
            ownerTextBox.Clear();
            birthBox.Value = DateTime.Today;
        }
    }
}
