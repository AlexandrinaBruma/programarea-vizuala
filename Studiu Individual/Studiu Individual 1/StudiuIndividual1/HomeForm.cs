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
using Microsoft.Data.SqlClient;
using static StudiuIndividual1.homeForm;
using static StudiuIndividual1.ViewForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StudiuIndividual1
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=.\\SQLEXPRESS;Database=PetShop;Integrated Security=True;";

        public class Magazin
        {
            public int ID_magazin { get; set; }
            public String Nume{ get; set; }
            public String Adresa { get; set; }
            public DateTime dataDeschiderii { get; set; }
            public int Servicii { get; set; }
            public int Tabara_de_zi { get; set; }
            public int Produse { get; set; }

            public Magazin(string nume, string adresa, DateTime dataDeschiderii, int servicii, int tabara_de_zi, int produse)
            {
                this.Nume = nume;
                this.Adresa = adresa;
                this.dataDeschiderii = dataDeschiderii;
                this.Servicii = servicii;
                this.Tabara_de_zi = tabara_de_zi;
                this.Produse = produse;
            }
        }

        public class Client
        {
            public int ID_client { get; set; }
            public String Nume { get; set; }
            public String Prenume { get; set; }
            public String Telefon { get; set; }
            public String Email { get; set; }
            public String Adresa_resedintei { get; set; }

            public Client(string nume, string prenume, string telefon, string email, string adresa_resedintei)
            {
                this.Nume = nume;
                this.Prenume = prenume;
                this.Telefon = telefon;
                this.Email = email;
                this.Adresa_resedintei = adresa_resedintei;
            }
        }

        public class Animal
        {
            public int ID_animal { get; set; }
            public String Nume { get; set; }
            public DateTime dataNasterii { get; set; }
            public String Specie { get; set; }
            public String Contraindicatii { get; set; }
            public int Stapan { get; set; }

        public Animal(string nume, DateTime dataNasterii, string specie, string contraindicatii, int stapan)
            {
                this.Nume = nume;
                this.dataNasterii = dataNasterii;
                this.Specie = specie;
                this.Contraindicatii = contraindicatii;
                this.Stapan = stapan;
            }
        }

        public class Appointment
        {
            public int ID { get; set; }
            public int serviciul { get; set; }
            public int animalul { get; set; }
            public int clientul { get; set; }
            public TimeSpan oraInceput { get; set; }
            public TimeSpan oraSfarsit { get; set; }

            public Appointment (int serviciul, int animalul, int clientul, TimeSpan oraInceput, TimeSpan oraSfarsit)
            {
                this.serviciul = serviciul;
                this.animalul = animalul;
                this.clientul = clientul;
                this.oraInceput = oraInceput;
                this.oraSfarsit = oraSfarsit;
            }
        }
        public class CampAppointment
        {
            public int ID { get; set; }
            public int animalul { get; set; }
            public int idTabara { get; set; }
            public DateTime data { get; set; }
            public TimeSpan oraInceput { get; set; }
            public TimeSpan oraSfarsit { get; set; }
            public bool sedereNoapte { get; set; }

            public CampAppointment(int animal, int idTabara, DateTime data, TimeSpan oraInceput, TimeSpan oraSfarsit, bool sedereNoapte)
            {
                this.animalul = animal;
                this.idTabara = idTabara;
                this.data = data;
                this.oraInceput = oraInceput;
                this.oraSfarsit = oraSfarsit;
                this.sedereNoapte = sedereNoapte;
            }
        }

        public class Serviciu
        {
            public int ID_serviciu { get; set; }
            public String Nume { get; set; }

            public Serviciu(string nume)
            {
                this.Nume = nume;
            }
        }

        public class Produs
        {
            public int ID_produs { get; set; }
            public String Nume { get; set; }
            public String Producator { get; set; }
            public DateTime dataProducerii { get; set; }
            public DateTime dataExpirarii { get; set; }

            public Produs(string nume, string producator, DateTime dataProducerii, DateTime dataExpirarii)
            {
                this.Nume = nume;
                this.Producator = producator;
                this.dataProducerii = dataProducerii;
                this.dataExpirarii = dataExpirarii;
            }
        }

        public class Tabara_de_zi
        {
            //public int ID_tabara;
            public String Nume { get; set; }
            public int Animale { get; set; }
            public int CapacitateaMaxima { get; set; }
            public TimeSpan oraDeInceput { get; set; }
            public TimeSpan oraDeSfarsit { get; set; }

        public Tabara_de_zi(string nume, int animale, int capacitateaMaxima, TimeSpan oraInceput, TimeSpan oraSfarsit)
            {
                this.Nume= nume;
                this.Animale = animale;
                this.CapacitateaMaxima = capacitateaMaxima;
                this.oraDeInceput = oraInceput;
                this.oraDeSfarsit = oraSfarsit;
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();

            viewForm.Show();
        }

        private void addAnimal_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm();

            animalForm.Show();
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();

            appointmentForm.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();

            clientForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
