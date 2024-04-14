using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul8_1302223023
{
    public class Program
    {
        static void Main(string[] args)
        {
            CovidConfig config = new CovidConfig();
            Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam { config.satuan_suhu}");
            double suhu = double.Parse(Console.ReadLine());

            Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?: ");
            int hariDemam = int.Parse(Console.ReadLine());

            bool suhuValid, haridemamValid;
            if(config.satuan_suhu == "celcius")
            {
                suhuValid = (suhu >= 36.5 && suhu <= 37.5);
            } else
            {
                suhuValid = (suhu >= 97.7 && suhu <= 99.5);
            }

            haridemamValid = (hariDemam <= config.batas_hari_demam);
            if(suhuValid && haridemamValid)
            {
                Console.WriteLine(config.pesan_diterima);
                config.ubahSatuan();
            } else
            {
                Console.WriteLine(config.pesan_ditolak);
               
            }

            Console.WriteLine($"Satuan suhu saat ini adalah {config.satuan_suhu}");

        }
    }
}
