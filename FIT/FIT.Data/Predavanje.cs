using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    public class Predavanje
    {

        int Godina;

        public int GetGodina() { return Godina; }
        public void SetGodina(int godina) { Godina = godina; }

        public string Tema { get; set; }

        public Predavanje(string tema, int godina)
        {
            Godina = godina;
            Tema = tema;
        }
    }
}
