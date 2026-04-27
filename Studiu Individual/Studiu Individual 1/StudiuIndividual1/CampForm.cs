using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static StudiuIndividual1.homeForm;
using static StudiuIndividual1.ViewForm;

namespace StudiuIndividual1
{
    public partial class CampForm : Form
    {
        public CampForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS;Database=PetShop;Integrated Security=True";

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int animal;
            int tabara;
            DateTime data;
            TimeSpan oraInceput;
            TimeSpan oraSfarsit;
            bool sedereNoapte;

            if (!int.TryParse(petTextBox.Text, out animal))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "ID-ul animalului trebuie să fie un număr.";
                statusLabel.Show();
                return;
            }

            if (!int.TryParse(campIDTextBox.Text, out tabara))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "ID-ul taberei trebuie să fie un număr.";
                statusLabel.Show();
                return;
            }

            animal = int.Parse(petTextBox.Text);
            tabara = int.Parse(campIDTextBox.Text);
            data = dateTimePicker.Value;
            oraInceput = hour1.Value.TimeOfDay;
            oraSfarsit = hour2.Value.TimeOfDay;
            sedereNoapte = overNightCheckBox.Checked;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQueryPet = "SELECT COUNT(*) FROM Animal WHERE ID_animal = @animal";
                    string checkQueryCamp = "SELECT COUNT(*) FROM Tabara_de_zi WHERE ID_tabara = @tabara";

                    using (SqlCommand checkCmd = new SqlCommand(checkQueryPet, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@animal", animal);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Nu există un animal cu acest ID.";
                            statusLabel.Show();
                            return;
                        }
                    }

                    using (SqlCommand checkCmd = new SqlCommand(checkQueryCamp, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@tabara", tabara);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Nu există o tabără cu acest ID.";
                            statusLabel.Show();
                            return;
                        }
                    }

                    string query = @"INSERT INTO Camp_appointment (Animalul, Tabara, Ora_de_inceput, Ora_de_sfarsit, Data_programarii, Sedere_pe_noapte)
                             VALUES (@animal, @tabara, @oraInceput, @oraSfarsit, @data, @sedereNoapte)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@animal", animal);
                        cmd.Parameters.AddWithValue("@tabara", tabara);
                        cmd.Parameters.AddWithValue("@oraInceput", oraInceput);
                        cmd.Parameters.AddWithValue("@oraSfarsit", oraSfarsit);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@sedereNoapte", sedereNoapte);

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
            petTextBox.Clear();
            campIDTextBox.Clear();
            hour1.Value = DateTime.Now;
            hour2.Value = DateTime.Now;
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
