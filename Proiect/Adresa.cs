using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Adresa
    {
        public string Strada { get; set; }
        public int Nr { get; set; }
        public string Bloc { get; set; }
        public string Scara { get; set; }
        public int Etaj { get; set; }
        public int Apartament { get; set; }

        public Adresa(string strada, int nr, string bloc, string scara, int etaj, int apartament)
        {
            Strada = strada;
            Nr = nr;
            Bloc = bloc;
            Scara = scara;
            Etaj = etaj;
            Apartament = apartament;
        }

        public Adresa()
        {

        }
        public Adresa(string adresa)
        {
            string[] adresaSplit = adresa.Split(',');

            Strada = "";
            string[] stradaSplit = adresaSplit[0].Split(' ');
            //foreach(string str in stradaSplit)
            //{
            //    if (str != "Strada")
            //        Strada += str + " ";
            //}
            for(int i=0;i<stradaSplit.Length;i++)
            {
                if(i==stradaSplit.Length-1)
                    Strada += stradaSplit[i];
                else if (stradaSplit[i] != "Strada")
                    Strada += stradaSplit[i] + " ";
            }

            string[] nrSplit = adresaSplit[1].Split(' ');
            Nr = int.Parse(nrSplit[2]);

            string[] blocSplit = adresaSplit[2].Split(' ');
            Bloc = blocSplit[2];

            string[] scaraSplit = adresaSplit[3].Split(' ');
            Scara = scaraSplit[2];

            string[] etajSplit = adresaSplit[4].Split(' ');
            Etaj = int.Parse(etajSplit[2]);

            string[] apartamentSplit = adresaSplit[5].Split(' ');
            Apartament = int.Parse(apartamentSplit[2]);


        }

        public override string ToString()
        {
            string adresa = string.Format("Strada {0}, nr. {1}, bl. {2}, sc. {3}, et. {4}, ap. {5}", Strada, Nr, Bloc, Scara, Etaj, Apartament);
            return adresa;
        }
    }
}
