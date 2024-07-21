using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Pizza
    {
        private readonly string[] marimi = { "Mica", "Medie", "Mare" };
        private readonly Dictionary<string, float> preturi = new Dictionary<string, float>()
        {
            {"Margherita",30 },
            {"Quattro Stagioni",32 },
            {"Diavola", 36},
            {"Pepperoni", 34},
            {"Quatro Formaggi", 30}
        };

        public string NumePizza { get; set; }
        public float Pret { get; set; }

        public string Marime { get; set; }

        public Pizza(string numePizza, string marime)
        {
            NumePizza = numePizza;
            Marime = marime;

            if (marime == "Mica")
                Pret = preturi[numePizza];
            else if (marime == "Medie")
                Pret = preturi[numePizza] + 5;
            else
                Pret = preturi[numePizza] + 10;
        }

        public Pizza(string pizza)
        {
            string[] pizzaSplit = pizza.Split(',');
            NumePizza = pizzaSplit[0].Split(' ')[1];
            Marime = pizzaSplit[1].Split(' ')[2];
            Pret = float.Parse(pizzaSplit[2].Split(' ')[2]);
        }

        public override string ToString()
        {
            return string.Format("Denumire: {0}, Marime: {1}, Pret: {2}",NumePizza, Marime, Pret);
        }
    }
}
