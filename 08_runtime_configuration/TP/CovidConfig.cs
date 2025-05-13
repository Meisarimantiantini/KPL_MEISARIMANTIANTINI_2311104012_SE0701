using System;
using System.IO;
using System.Text.Json;

namespace tpmodul8_2311104012
{
    public class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        private const string configFile = "covid_config.json";

        public CovidConfig()
        {
            if (File.Exists(configFile))
            {
                string jsonString = File.ReadAllText(configFile);
                CovidConfig data = JsonSerializer.Deserialize<CovidConfig>(jsonString);
                satuan_suhu = data.satuan_suhu;
                batas_hari_deman = data.batas_hari_deman;
                pesan_ditolak = data.pesan_ditolak;
                pesan_diterima = data.pesan_diterima;
            }
            else
            {
                satuan_suhu = "celcius";
                batas_hari_deman = 14;
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
                SaveConfig();
            }
        }

        public void SaveConfig()
        {
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(configFile, jsonString);
        }

        public void UbahSatuan()
        {
            if (satuan_suhu.ToLower() == "celcius")
                satuan_suhu = "fahrenheit";
            else
                satuan_suhu = "celcius";
            SaveConfig();
        }
    }
}
