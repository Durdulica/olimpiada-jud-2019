namespace olimpiada_jud_2019
{
    public class Utilizator
    {
        public string email {  get; set; }
        public string parola {  get; set; }
        public string nume {  get; set; }
        public string prenume {  get; set; }

        public Utilizator(string email, string parola, string nume, string prenume)
        {
            this.email = email;
            this.parola = parola;
            this.nume = nume;
            this.prenume = prenume;
        }
    }
}
