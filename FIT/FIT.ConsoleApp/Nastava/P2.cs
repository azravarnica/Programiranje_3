using FIT.Data;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.ConsoleApp.Nastava
{
    public class P2
    {
        public static void Pokreni()
        {
            //BazniTip();
            //Override();
            //Slojevi();
            //VrijednostiReference();
            Nizovi();
        }

        private static void Nizovi()
        {
            sStudent[] prvaGodina = new sStudent[3];
            cStudent[] drugaGodina = new cStudent[3];

            for(int i=0; i<prvaGodina.Length; i++)
            {
                prvaGodina[i].Indeks = $"50ST{i}";
                prvaGodina[i].Ime = $"Ime{i}";
                prvaGodina[i].Prezime = $"Prezime{i}";
            }

            for (int i = 0; i < drugaGodina.Length; i++)
            {
                drugaGodina[i] = new cStudent();
                drugaGodina[i].Indeks = $"50ST{i}";
                drugaGodina[i].Ime = $"Ime{i}";
                drugaGodina[i].Prezime = $"Prezime{i}";
            }
        }

        private static void VrijednostiReference()
        {
            //klasa
            cStudent azra1 = new cStudent()
            {
                Indeks = "50ST",
                Ime = "Azra",
                Prezime = "Prezime"

            };
            cStudent azra2 = azra1;
            azra2.Indeks = "50";

            Console.WriteLine(azra1);
            Console.WriteLine(azra2);

            //struktura
            sStudent eli1 = new sStudent()
            {
                Indeks = "50ST",
                Ime = "Azra",
                Prezime = "Prezime"

            };
            sStudent eli2 = eli1;
            eli2.Indeks = "50";
            Console.WriteLine(eli1);
            Console.WriteLine(eli2);
        }

        private static void Slojevi()
        {
            StudentService ss = new StudentService();
            cStudent student = ss.GetByIndeks("12345");
            Console.WriteLine(student);
        }

        private static void Override()
        {
            cStudent azra = new cStudent();
            azra.Indeks = "230033";
            azra.Ime = "Azra";
            azra.Prezime = "Ajanovic";
            Console.WriteLine(azra);
            Console.WriteLine(azra.ToString());
        }

        private static void BazniTip()
        {
            int godina = 2023;
            cStudent azra = new cStudent();
              object oGodina = godina;
              object oAzra = azra;

              FromObject(azra);
              FromObject(godina);
        }
        private static void FromObject(object obj)
        {
            if(obj is cStudent)
            {
                //treba uraditi kasting da bi bila dostupna metoda Predstavi se
                ((cStudent)obj).PredstaviSe();
            }
            else if(obj is int) Console.WriteLine("Int");
        }
    }

}
