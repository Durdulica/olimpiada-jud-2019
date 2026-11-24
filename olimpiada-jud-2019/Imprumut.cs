using System;

namespace olimpiada_jud_2019
{
    public class Imprumut
    {
        public Guid id_imprumut { get; set; }
        public Guid id_carte {  get; set; }
        public string email {  get; set; }
        public DateTime data_imprumut { get; set; }

        public Imprumut(Guid id_carte, string email, DateTime data_imprumut)
        {
            id_imprumut = Guid.NewGuid();
            this.id_carte = id_carte;
            this.email = email;
            this.data_imprumut = data_imprumut;
        }
    }
}
