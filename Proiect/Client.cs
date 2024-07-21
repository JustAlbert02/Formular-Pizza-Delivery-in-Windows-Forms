using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public class Client
    {
        public Adresa adresa;
        public BindingList<Pizza> pizze;

        public string pizzeToString()
        {
            string pizzeString = "";
            foreach (Pizza pizza in pizze)
            {
                pizzeString += pizza.ToString() + ";";
            }
            return pizzeString;
        }

        

        public Client()
        {
            adresa=new Adresa();
            pizze=new BindingList<Pizza>();
        }

        public Client(Adresa adresa, string nume, string prenume, string telefon)
        {
            this.adresa = adresa;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
        }

        public int Id { get; set; }

        public string Nume { get; set; }
        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public Adresa AdresaClient { get =>adresa; set=>adresa=value; }

        public BindingList<Pizza> Pizze { get=>pizze; set=>pizze=value; }


    }
}
