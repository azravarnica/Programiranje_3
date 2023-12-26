using System.Collections;

namespace FIT.Data
{
   public class cStudent : Osoba, IEnumerable, IDisposable
    {
        // dozvoljeno je nasljedjivanje samo jedne klase pa zato pisemo base umjesto Osoba
        // jer se zna koja je bazna klasa
        public cStudent():base(Vrijednosti.NotSet, Vrijednosti.NotSet)
        {
            Indeks = Vrijednosti.NotSet;
        }
       public cStudent(string index, string ime, string prezime): base(ime, prezime)
        {
            Indeks = index;
        }
        public string Indeks { get; set; }
    public override string ToString()
        {
            return $"{Indeks} {base.ToString()}";
        }

        public override void Info()
        {
            Console.WriteLine("Hello from Info");
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Ocjene.Length; i++) yield return Ocjene[i];
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose ->" + ToString());
        }

        public int[] Ocjene = new int[] { 6, 6, 8, 9, 7 };
        //preklopljeni operator []
        public int this[int lokacija]
        {
            get { return Ocjene[lokacija]; }
        }
    }

    public struct sStudent
    {
        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
    }
}