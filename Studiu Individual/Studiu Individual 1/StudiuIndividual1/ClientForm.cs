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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS;Database=PetShop;Integrated Security=True";

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            String nume;
            String prenume;
            String telefon;
            String email;
            String adresa_resedintei;

            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Numele de familie nu poate fi gol.";
                statusLabel.Show();
                return;
            }

            if (string.IsNullOrEmpty(surnameTextBox.Text.Trim()))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Numele nu poate fi gol.";
                statusLabel.Show();
                return;
            }

            if (string.IsNullOrEmpty(phoneNumberTextBox.Text.Trim()))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Numarul de telefon nu poate fi gol.";
                statusLabel.Show();
                return;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Adresa de email nu poate fi goală.";
                statusLabel.Show();
                return;
            }

            if (string.IsNullOrEmpty(addressTextBox.Text.Trim()))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Adresa de reședință nu poate fi goală.";
                statusLabel.Show();
                return;
            }

            if (nameTextBox.Text.Trim().Any(char.IsDigit))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Numele nu poate conține cifre.";
                statusLabel.Show();
                return;
            }

            if (surnameTextBox.Text.Trim().Any(char.IsDigit))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Numele de familie nu poate conține cifre.";
                statusLabel.Show();
                return;
            }

            nume = surnameTextBox.Text;
            prenume = nameTextBox.Text;
            telefon = phoneNumberTextBox.Text;
            email = emailTextBox.Text;
            adresa_resedintei = addressTextBox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Client (Nume, Prenume, Telefon, Email, Adresa_resedintei)
                             VALUES (@nume, @prenume, @telefon, @email, @adresa_resedintei)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nume", nume);
                        cmd.Parameters.AddWithValue("@prenume", prenume);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@adresa_resedintei", adresa_resedintei);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            statusLabel.ForeColor = Color.Green;
                            statusLabel.Text = "Înregistrarea a fost făcută cu succes!";
                            statusLabel.Show();
                            ClearFields();
                        }
                        else
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Înregistrarea a eșuat. Încearcă din nou.";
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
            surnameTextBox.Clear();
            nameTextBox.Clear();
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();
        }
    }
}
