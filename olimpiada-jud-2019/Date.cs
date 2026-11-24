using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace olimpiada_jud_2019
{
    public static class Date
    {
        public static List<Utilizator> CitesteUtilizatori(string cale)
        {
            List<Utilizator> lista = new List<Utilizator>();
            var reader = new StreamReader(Path.Combine(cale, "utilizatori.txt"));
            string linie;

            while ((linie = reader.ReadLine()) != null) 
            {
                string[] date = linie.Split('*');
                Utilizator u = new Utilizator(date[0], date[1], date[2], date[3]);
                lista.Add(u);
            }

            return lista;
        }

        public static List<Carte> CitesteCarti(string cale) 
        {
            List<Carte> carti = new List<Carte>();
            var reader = new StreamReader(Path.Combine(cale, "carti.txt"));
            string linie;

            while((linie = reader.ReadLine()) != null)
            {
                string[] date = linie.Split('*');
                Carte c = new Carte(date[0], date[1], date[2]);
                carti.Add(c);
            }

            return carti;
        }

        public static List<Imprumut> CitesteImprumuturi(string cale, List<Carte> carti)
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            var reader = new StreamReader(Path.Combine(cale, "imprumuturi.txt"));
            string linie;

            while ((linie = reader.ReadLine()) != null)
            {
                string[] date = linie.Split('*');

                var carte = carti.FirstOrDefault(x => x.titlu == date[0]);
                if (carte != null)
                {
                    Imprumut imp = new Imprumut(carte.id_carte, date[1], DateTime.Parse(date[2]));
                    imprumuturi.Add(imp);
                }
            }

            return imprumuturi;
        }
    }
}
