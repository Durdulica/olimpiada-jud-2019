using System;

namespace olimpiada_jud_2019
{
    public class Imprumut
    {
        public int id_imprumut { get; set; }
        public int id_carte {  get; set; }
        public string email {  get; set; }
        public string data_imprumut { get; set; }

        public Imprumut(int id_imprumut, int id_carte, string email, string data_imprumut)
        {
            this.id_imprumut = id_imprumut;
            this.id_carte = id_carte;
            this.email = email;
            this.data_imprumut = data_imprumut;
        }
    }
}
