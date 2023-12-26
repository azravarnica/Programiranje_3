namespace FIT.Data
{
   public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public abstract void Info();
        public void PredstaviSe()
        {
            Console.WriteLine("Student");
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}