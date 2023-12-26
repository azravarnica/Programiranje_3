using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    public class BazniEntitet
    {
        public DateTime Kreiran { get; set; }
        public int KreiraoID { get; set; }
        public DateTime Modifikovan { get; set; }
        public int ModifikovaoID { get; set; }
    }
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
