using FIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Infrastructure
{
    public class InMemoryDb
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();
        public static List<Student> Studenti = GenerisiStudente();
        public static List<Semestar> Semestri = GenerisiSemestre();
        public static List<Predmet> Predmeti = GenerisiPredmete();

        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>() {
                new Predmet() { Id = 1, Naziv = " Programiranje I", Semestar = 1 },
                new Predmet() { Id = 2, Naziv = " Programiranje II", Semestar = 2 },
                new Predmet() { Id = 3, Naziv = " Racunarske mreze", Semestar = 1 },
                new Predmet() { Id = 4, Naziv = " Matematika II", Semestar = 2}

            };
        }

        private static List<Semestar> GenerisiSemestre()
        {
            return new List<Semestar>() {
                new Semestar() { Id = 1, Aktivan = true, Oznaka = "1. SEM", Opis = "Prvi semestar I ciklusa studija" },
                new Semestar() { Id = 2, Aktivan = true, Oznaka = "2. SEM", Opis = "Drugi semestar I ciklusa studija" },
                new Semestar() { Id = 3, Aktivan = true, Oznaka = "3. SEM", Opis = "Treci semestar I ciklusa studija" },
                new Semestar() { Id = 4, Aktivan = true, Oznaka = "4. SEM", Opis = "Cetvrti semestar I ciklusa studija" }

            };
        }

        private static List<Student> GenerisiStudente()
        {
            return new List<Student>(){
                new Student()
                    {
                        Id = 1,
                        Aktivan = true,
                        Email = "denis@edu.fit.ba",
                        Ime = "Denis",
                        Prezime = "Music",
                        Indeks = "IB230032",
                        Lozinka = "denis",
                        DatumRodjenja = new DateTime(2000,2,2),
                        Semestar = 1,
                        Slika = null
                    },
                 new Student()
                    {
                        Id = 2,
                        Aktivan = true,
                        Email = "azra.ajanovic@edu.fit.ba",
                        Ime = "Azra",
                        Prezime = "Ajanovic",
                        Indeks = "IB230033",
                        Lozinka = "azra",
                        DatumRodjenja = new DateTime(2000,1,1),
                        Semestar = 2,
                        Slika = null
                    }
            };
        }

        private static List<Korisnik> GenerisiKorisnike()
        {
            //var korisnik = new Korisnik()
            //{
            //    Id = 1,
            //    Aktivan = true,
            //    Email = "admin@edu.fit.ba",
            //    Ime = "Azra",
            //    KorisnickoIme = "admin",
            //    Lozinka = "admin",
            //    Prezime = "Ajanovic"
            //};
            //List<Korisnik> lista = new List<Korisnik>();
            //lista.Add(korisnik);
            //return lista;

            return new List<Korisnik>()
            {
                new Korisnik()
                {
                    Id = 1,
                    Aktivan = true,
                    Email = "admin@edu.fit.ba",
                    Ime = "Azra",
                    KorisnickoIme = "admin",
                    Lozinka = "admin",
                    Prezime = "Ajanovic"
                }
            };
        }
    }
}
