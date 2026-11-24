using System;

namespace olimpiada_jud_2019
{
    public class Carte
    {
        public Guid id_carte { get; set; }
        public string titlu { get; set; }
        public string autor { get; set; }
        public string gen {  get; set; }

        public Carte(string titlu, string autor, string gen)
        {
            id_carte = Guid.NewGuid();
            this.titlu = titlu;
            this.autor = autor;
            this.gen = gen;
        }
    }
}
