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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS;Database=PetShop;Integrated Security=True";

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enrollToCampButton_Click(object sender, EventArgs e)
        {
            CampForm campForm = new CampForm();

            campForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int serviciu;
            int animal;
            int IDclient;
            TimeSpan oraInceput;
            TimeSpan oraSfarsit;
            DateTime dataProgramarii;

            if (!int.TryParse(ownerIDTextBox.Text, out IDclient))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "ID-ul stăpânului trebuie să fie un număr.";
                statusLabel.Show();
                return;
            }

            if (!int.TryParse(petNameTextBox.Text, out animal))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "ID-ul animaului trebuie să fie un număr.";
                statusLabel.Show();
                return;
            }

            if (!int.TryParse(serviceTextBox.Text, out serviciu))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "ID-ul serviciului trebuie să fie un număr.";
                statusLabel.Show();
                return;
            }

            serviciu = int.Parse(serviceTextBox.Text);
            animal = int.Parse(petNameTextBox.Text);
            IDclient = int.Parse(ownerIDTextBox.Text);
            oraInceput = hour1.Value.TimeOfDay;
            oraSfarsit = hour2.Value.TimeOfDay;
            dataProgramarii = dateBox.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQueryOwner = "SELECT COUNT(*) FROM Client WHERE ID_client = @IDclient";
                    string checkQueryPet = "SELECT COUNT(*) FROM Animal WHERE ID_animal = @animal";
                    string checkQueryService = "SELECT COUNT(*) FROM Serviciu WHERE ID_serviciu = @serviciu";

                    using (SqlCommand checkCmd = new SqlCommand(checkQueryOwner, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IDclient", IDclient);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Nu există un client cu acest ID.";
                            statusLabel.Show();
                            return;
                        }
                    }

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

                    using (SqlCommand checkCmd = new SqlCommand(checkQueryService, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@serviciu", serviciu);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Nu există un serviciu cu acest ID.";
                            statusLabel.Show();
                            return;
                        }
                    }

                    string query = @"INSERT INTO Appointment (Serviciul, Animalul, Clientul, Ora_de_inceput, Ora_de_sfarsit, Data_programarii)
                             VALUES (@serviciu, @animal, @IDclient, @oraInceput, @oraSfarsit, @dataProgramarii)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@serviciu", serviciu);
                        cmd.Parameters.AddWithValue("@animal", animal);
                        cmd.Parameters.AddWithValue("@IDclient", IDclient);
                        cmd.Parameters.AddWithValue("@oraInceput", oraInceput);
                        cmd.Parameters.AddWithValue("@oraSfarsit", oraSfarsit);
                        cmd.Parameters.AddWithValue("@dataProgramarii", dataProgramarii);

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
            serviceTextBox.Clear();
            petNameTextBox.Clear();
            ownerIDTextBox.Clear();
            hour1.Value = DateTime.Now;
            hour2.Value = DateTime.Now;
            dateBox.Value = DateTime.Now;
        }
    }
}
