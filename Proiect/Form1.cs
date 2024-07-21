using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        
        public Form2 form2;
        public Client client;

        private string connectionString = "Data Source=database.db";

        public Form1(Client _client)
        {
            InitializeComponent();
            client = _client;
            cbOptiuniPizza.SelectedIndex = 0;
            cbMarimiPizza.SelectedIndex = 0;
            dgvPizzeAlese.DataSource = client.pizze;
            
            form2=new Form2();
            form2.loadComenzi();
        }
        public Form1()
        {
            InitializeComponent();
            client = new Client();

            cbOptiuniPizza.SelectedIndex = 0;
            cbMarimiPizza.SelectedIndex = 0;

            dgvPizzeAlese.DataSource = client.pizze;
            
            form2=new Form2();
            form2.loadComenzi();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void numberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))//poti introduce doar cifre
            { 
                e.Handled = true; 
            }
        }

        private void stringTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))//poti introduce doar litere
            {
                e.Handled = true;
            }
        }

        private void tbNume_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text.Length<2)
            {
                errorProvider1.SetError(textBox, "Trebuie sa existe minim 2 caractere");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }
        private void tbTelefon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if(tbTelefon.Text.Length!=10)
            {
                errorProvider1.SetError(tbTelefon, "Numarul de telefon trebuie sa contina 10 cifre");
                e.Cancel = true;
            }
            else if (!tbTelefon.Text.StartsWith("07"))
            {
                errorProvider1.SetError(tbTelefon, "Numarul de telefon trebuie sa inceapa cu 07");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTelefon, null);
            }
        }

        private void btnAdaugarePizza_Click(object sender, EventArgs e)
        {
            var verificare = ValidateChildren();
            if (!verificare)
            {
                MessageBox.Show("Formularul nu a fost completat corect!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            client.pizze.Add(new Pizza(cbOptiuniPizza.Text, cbMarimiPizza.Text));
        }

        private void btnComenziAnterioare_Click(object sender, EventArgs e)
        {
            
            form2.ShowDialog();
        }


        private void tbEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Campul trebuie completat");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        
        
        public void btnFinalizare_Click(object sender, EventArgs e) //se adauga clientul cu comanda in baza de date
        {

            var verificare = ValidateChildren();
            if (!verificare)
            {
                MessageBox.Show("Formularul nu a fost completat corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (client.pizze.Count == 0)
            {
                MessageBox.Show("Nu ati adaugat nicio pizza!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Adresa adresa=new Adresa(tbStrada.Text,int.Parse(tbNr.Text),tbBloc.Text,tbScara.Text,int.Parse(tbEtaj.Text),int.Parse(tbApartament.Text));
            client.AdresaClient = adresa;
            client.Nume = tbNume.Text;
            client.Prenume = tbPrenume.Text;
            client.Telefon = tbTelefon.Text;

            //----

            var query = "INSERT INTO Comenzi (nume,prenume,adresa,pizze,telefon) VALUES (@nume,@prenume,@adresa,@pizze,@telefon); SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nume", client.Nume);
                    command.Parameters.AddWithValue("@prenume", client.Prenume);
                    command.Parameters.AddWithValue("@adresa", client.AdresaClient.ToString());
                    command.Parameters.AddWithValue("@pizze", client.pizzeToString());
                    command.Parameters.AddWithValue("@telefon", client.Telefon);

                    connection.Open();
                    client.Id = Convert.ToInt32(command.ExecuteScalar());

                    form2.adaugaComandaInLog(client);                    
                }
            }

            tbNume.Text = "";
            tbPrenume.Text = "";
            tbTelefon.Text = "";
            tbStrada.Text = "";
            tbNr.Text = "";
            tbBloc.Text = "";
            tbScara.Text = "";
            tbEtaj.Text = "";
            tbApartament.Text = "";
            client = new Client();
            dgvPizzeAlese.DataSource= client.pizze;
        }

        public void finalizareEditare_Click(object sender, EventArgs e) //se editeaza detaliile comenzii ale clientului in baza de date
        {
            var verificare = ValidateChildren();
            if (!verificare)
            {
                MessageBox.Show("Formularul nu a fost completat corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (client.pizze.Count == 0)
            {
                MessageBox.Show("Nu ati adaugat nicio pizza!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Adresa adresa = new Adresa(tbStrada.Text, int.Parse(tbNr.Text), tbBloc.Text, tbScara.Text, int.Parse(tbEtaj.Text), int.Parse(tbApartament.Text));
            client.AdresaClient = adresa;
            client.Nume = tbNume.Text;
            client.Prenume = tbPrenume.Text;
            client.Telefon = tbTelefon.Text;
            //----
            var query = "UPDATE Comenzi SET nume=@nume,prenume=@prenume,adresa=@adresa,pizze=@pizze,telefon=@telefon WHERE idClient=@id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nume", client.Nume);
                    command.Parameters.AddWithValue("@prenume", client.Prenume);
                    command.Parameters.AddWithValue("@adresa", client.AdresaClient.ToString());
                    command.Parameters.AddWithValue("@pizze", client.pizzeToString());
                    command.Parameters.AddWithValue("@telefon", client.Telefon);
                    command.Parameters.AddWithValue("@id", client.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
