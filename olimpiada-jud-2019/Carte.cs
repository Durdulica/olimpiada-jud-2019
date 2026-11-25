using System;

namespace olimpiada_jud_2019
{
    public class Carte
    {
        public int id_carte { get; set; }
        public string titlu { get; set; }
        public string autor { get; set; }
        public string gen {  get; set; }

        public Carte(int id_carte, string titlu, string autor, string gen)
        {
            this.id_carte = id_carte;
            this.titlu = titlu;
            this.autor = autor;
            this.gen = gen;
        }
    }
}
