using FIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.ConsoleApp.Nastava
{
    public class P1
    {
        public static void Pokreni()
        {
            //TipoviPodataka();
            //Pokazivaci();
            //Klase();
            VrsteTipova();

        }

        private static void VrsteTipova()
        {
            //VALUE TIP
            int indeks1 = 0;
            int indeks2 = new int();
            if(indeks1 == 230032) Console.WriteLine("Student Azra Ajanovic");
            if(indeks2 == 230032) Console.WriteLine("Student Azra Ajanovic");

            //REFERENCE TIP
            Predmet prII_1 = new Predmet();
            Predmet prII_2 = prII_1;

            prII_2.Semestar = 4;
        }

        private static void Klase()
        {
            Predavanje prIII = new Predavanje("C# intro", 2);
            prIII.Tema += " u Windows formi";
            Console.WriteLine(prIII.GetGodina() + " " + prIII.Tema);
        }

        private static void Pokazivaci()
        {
            int indeks = 20220;
            unsafe
            {
                int* pIndeks = &indeks;
            }
        }

        private static void TipoviPodataka()
        {
            int indeks = 20220;
            string naziv = "Programiranje III";
            bool aktivan = true;

            Console.WriteLine(indeks + " " + naziv + " " + aktivan);
            Console.WriteLine($"{indeks} je polozio {naziv} i student je aktivan {aktivan}");
        }
    }
}
