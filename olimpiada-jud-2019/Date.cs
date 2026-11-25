using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                Utilizator u = new Utilizator(date[0].Trim(), date[1].Trim(), date[2].Trim(), date[3].Trim());
                lista.Add(u);
            }

            return lista;
        }

        public static List<Carte> CitesteCarti(string cale) 
        {
            List<Carte> carti = new List<Carte>();
            var reader = new StreamReader(Path.Combine(cale, "carti.txt"));
            string linie;
            int index = 1;
            while((linie = reader.ReadLine()) != null)
            {
                string[] date = linie.Split('*');
                Carte c = new Carte(index++, date[0].Trim(), date[1].Trim(), date[2].Trim());
                carti.Add(c);
            }

            return carti;
        }

        public static List<Imprumut> CitesteImprumuturi(string cale, List<Carte> carti)
        {
            List<Imprumut> imprumuturi = new List<Imprumut>();
            var reader = new StreamReader(Path.Combine(cale, "imprumuturi.txt"));
            string linie;
            int index = 1;
            while ((linie = reader.ReadLine()) != null)
            {
                string[] date = linie.Split('*');
                
                var carte = carti.FirstOrDefault(x => x.titlu.ToLower() == date[0].ToLower());
                if (carte != null)
                {
                    Imprumut imp = new Imprumut(index++, carte.id_carte, date[1].Trim(), date[2].Trim());
                    imprumuturi.Add(imp);
                }
                else
                {
                    //todo:
                }
            }

            return imprumuturi;
        }
    }
}
