using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpModul8_1302223023
{
    public class CovidConfig
    {
        public String satuan_suhu { get; set; } = "celcius";
        public int batas_hari_demam { get; set; } = 14;
        public String pesan_ditolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public String pesan_diterima { get; set; } = "Anda dipersilakan untuk masuk ke dalam gedung ini";

        public CovidConfig() {
            if (File.Exists("covid_config.json"))
            {
                var json = File.ReadAllText("covid config.json");
                var config = JsonConvert.DeserializeObject<CovidConfig>(json);

                satuan_suhu = config.satuan_suhu;
                batas_hari_demam = config.batas_hari_demam;
                pesan_ditolak = config.pesan_ditolak;
                pesan_diterima = config.pesan_diterima;
            }
        }

        public void ubahSatuan()
        {
            if(satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            } else if(satuan_suhu == "fahrenheit")
            {
                satuan_suhu = "celcius";
            }
        }
    }

}
