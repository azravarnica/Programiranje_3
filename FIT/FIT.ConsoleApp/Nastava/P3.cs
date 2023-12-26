using FIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.ConsoleApp.Nastava
{
    public class AppData
    {
        public const string Naziv = "FITApp";
        public readonly string Autor;

        public AppData(string autor)
        {
            //ovdje inicijalizujemo konstantu Autor, readonly znaci odgodjeno inicijaliziranje konstante
            // i to se moze uraditi samo u konsturktoru
            Autor = autor;
        }
    }
    public interface ISMSServis
    {
        bool Posalji(string broj, string poruka);
        bool Dostupan(string broj);
    }
    public class BHTelecomSMSServis : ISMSServis
    {
        public bool Dostupan(string broj)
        {
            return true; ;
        }

        public bool Posalji(string broj, string poruka)
        {
            Console.WriteLine($"BHTELECOM -> {broj}: {poruka}");
            return true;
        }
    }
    public class TestSMSServis : ISMSServis
    {
        public bool Dostupan(string broj)
        {
            return true; ;
        }

        public bool Posalji(string broj, string poruka)
        {
            Console.WriteLine($"TESTSMSServis -> {broj}: {poruka}");
            return true;
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        const string Putanja = @"C:\logs\log.txt";
        public void Log(string message)
        {
            Console.WriteLine($"FILE LOG {Putanja} -> {message}");
        }
    }

    public class DBLogger : ILogger
    {
        const string Putanja = @"Server=192.168.1.18;database=Logger;user=azra;pass=test";
        public void Log(string message)
        {
            Console.WriteLine($"DB LOG {Putanja} -> {message}");
        }
    }
    public class P3
    {
        public static void Pokreni()
        {
            // Parms();
            // Indekseri();
            // Nasjedjivanje();
            Interfejsi();
        }

        private static void Interfejsi()
        {
            // ISMSServis bhtelecom = new BHTelecomSMSServis();
            // ISMSServis testServis = new TestSMSServis();
            // ILogger logger = new FileLogger();
            // P3_1.Pokreni(testServis, logger);
            cStudent azra = new cStudent("IB123", "Azra", "Ajanovic");
            foreach(var ocjena in azra)//azra.GetEnumerator()
            {
                Console.WriteLine(ocjena);
            }

            using (cStudent azra2 = new cStudent("IB123", "Azra", "Ajanovic"))
            {

            }//garancija da ce se pozvati azra.Dispose()
        }

        private static void Nasjedjivanje()
        {
           // Osoba nn = new Osoba("Neko", "Nekic");
            cStudent azra = new cStudent("IB123", "Azra", "Ajanovic");
           // OsobaInfo(nn);
            OsobaInfo(azra);
        }

        private static void OsobaInfo(Osoba osoba)
        {
            if(osoba is cStudent)
            {
                cStudent student1 = (cStudent)osoba;
                cStudent student2 = osoba as cStudent;
                Console.WriteLine(student2);
                student2.Info();

            }
            else
            {
                Console.WriteLine(osoba);
            }
        }

        private static void Indekseri()
        {
            cStudent azra = new cStudent("IB123","Azra", "Ajanovic");
            Console.WriteLine(azra[1]);
        }

        private static void Parms()
        {
            Console.WriteLine($"Suma1 -> {Sumiraj(new int[] { 2, 6, 9, 8, 22, 66 })}");
            Console.WriteLine($"Suma2 -> {Sumiraj( 2, 6, 9, 8, 22, 66, 1, 55)}");

            var noviString = string.Join(" - ", 2, 6, 9, "FIT", 22);
            Console.WriteLine(noviString);
        }

        private static int Sumiraj(params int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++) suma += niz[i];

            return suma;
        }
    }
}
