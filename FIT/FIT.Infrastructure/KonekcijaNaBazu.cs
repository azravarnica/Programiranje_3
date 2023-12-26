using FIT.Data;

namespace FIT.Infrastructure
{
    public class KonekcijaNaBazu
    {

    }

    //ovo ide u Servise dio ali sad je tu radi primjera samo

    public class StudentService
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();

        public cStudent GetByIndeks (string indeks)
        {
            cStudent student = new cStudent()
            {
                Indeks = indeks,
                Ime = "Ime",
                Prezime = "Prezime"

            };
            return student;
        }
    }
}