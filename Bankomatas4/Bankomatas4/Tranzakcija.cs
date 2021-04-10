using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas4
{
    class Tranzakcija
    {
        public string Valiuta;
        public decimal Suma;
        public string MokėjimoPaskirtis;
        public DateTime Data;


        public void Informacija()
        {
            string irasas = $"\n{Suma} {Valiuta} \nMokejimo paskirtis: {MokėjimoPaskirtis} \n{Data} \n";
            Console.WriteLine(irasas);

        }
        public void InformacijaEN()
        {
            string irasas = $"\n{Suma} {Valiuta} \nPurpose: {MokėjimoPaskirtis} \n{Data} \n";
            Console.WriteLine(irasas);

        }
        public void InformacijaRU()
        {
            string irasas = $"\n{Suma} {Valiuta} \nНазначение: {MokėjimoPaskirtis} \n{Data} \n";
            Console.WriteLine(irasas);

        }




    }
}
