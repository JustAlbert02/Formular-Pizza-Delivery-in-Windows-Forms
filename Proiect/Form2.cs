using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form2 : Form
    {
        BindingList<Client> comenzi;
        string connectionString = "Data Source=database.db";
        public Form2()
        {
            InitializeComponent();
            comenzi = new BindingList<Client>();
            dgvLogComenzi.DataSource = comenzi;
            
        }

        public void adaugaComandaInLog(Client client)
        {
            comenzi.Add(client);
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void loadComenzi()
        {
            var query = "SELECT * FROM Comenzi";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string nume = (string)reader["nume"];
                            string prenume = (string)reader["prenume"];
                            Adresa adresa = new Adresa((string)reader["adresa"]);
                            string[] pizze = ((string)reader["pizze"]).Split(';');
                            BindingList<Pizza> listaPizze = new BindingList<Pizza>();
                            foreach (string pizza in pizze)
                            {
                                if (pizza == "")
                                    continue;

                                string detaliiPizza = pizza;
                                listaPizze.Add(new Pizza(pizza));
                            }
                            string telefon = (string)reader["telefon"];
                            Client client = new Client(adresa, nume, prenume, telefon);
                            client.pizze = listaPizze;
                            int id = int.Parse(reader["idClient"].ToString());
                            client.Id = id;

                            this.adaugaComandaInLog(client);
                        }
                    }
                }
            }
        }

        public void reloadComenzi()
        {
            comenzi.Clear();
            loadComenzi();
        }

        private void btnStergereComanda_Click(object sender, EventArgs e)
        {
            if (dgvLogComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o linie");
                return;
            }

            var query = "DELETE FROM Comenzi WHERE idClient=@idClient";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@idClient", ((Client)dgvLogComenzi.SelectedRows[0].DataBoundItem).Id);
                    command.ExecuteNonQuery();
                }
            }

            Client clientDeSters = (Client)dgvLogComenzi.SelectedRows[0].DataBoundItem;
            comenzi.Remove(clientDeSters);
            
        }



        private void btnEditareComanda_Click(object sender, EventArgs e)
        {
            if (dgvLogComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o linie");
                return;
            }

            Form1 form1 = new Form1((Client)dgvLogComenzi.SelectedRows[0].DataBoundItem);
            form1.form2 = null;
            form1.btnComenziAnterioare.Enabled = false;
            form1.Text = "Editare comanda";
            form1.Titlu.Text = "Editeaza comanda";

            form1.btnFinalizare.Text = "Finalizare editare";
            form1.btnFinalizare.Click -= form1.btnFinalizare_Click;
            form1.btnFinalizare.Click += form1.finalizareEditare_Click;
            form1.btnFinalizare.DialogResult = DialogResult.OK;


            form1.tbNume.Text = form1.client.Nume;
            form1.tbPrenume.Text = form1.client.Prenume;
            form1.tbTelefon.Text = form1.client.Telefon;

            form1.tbStrada.Text = "";
            string strada = form1.client.AdresaClient.ToString().Split(',')[0];
            string[] stradaSplit=strada.Split(' ');
            for(int i=1;i<stradaSplit.Length;i++)
            {
                if(i == stradaSplit.Length - 1)
                    form1.tbStrada.Text += stradaSplit[i];
                else
                    form1.tbStrada.Text+= stradaSplit[i] + " ";
            }

            form1.tbNr.Text = form1.client.AdresaClient.Nr.ToString();
            form1.tbBloc.Text = form1.client.AdresaClient.Bloc;
            form1.tbScara.Text = form1.client.AdresaClient.Scara;
            form1.tbApartament.Text = form1.client.AdresaClient.Apartament.ToString();
            form1.tbEtaj.Text = form1.client.AdresaClient.Etaj.ToString();

            form1.ShowDialog();
            this.reloadComenzi();
        }

        private void btnVeziPizze_Click(object sender, EventArgs e)
        {
            if (dgvLogComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o linie");
                return;
            }
            Client client = (Client)dgvLogComenzi.SelectedRows[0].DataBoundItem;
            string[] pizzeClient = client.pizzeToString().Split(';');
            string mesaj = "";
            foreach(string pizza in pizzeClient)
            {
                mesaj += pizza + "\n";
            }
            MessageBox.Show(mesaj,"Pizze Client");
            
        }
    }
}
