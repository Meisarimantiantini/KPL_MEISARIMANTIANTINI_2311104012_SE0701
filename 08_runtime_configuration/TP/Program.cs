using System;

namespace tpmodul8_2311104012
{
    class Program
    {
        static void Main(string[] args)
        {
            CovidConfig config = new CovidConfig();

            Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}");
            double suhu = double.Parse(Console.ReadLine());

            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
            int hariDemam = int.Parse(Console.ReadLine());

            bool suhuNormal = false;
            if (config.satuan_suhu == "celcius")
                suhuNormal = (suhu >= 36.5 && suhu <= 37.5);
            else if (config.satuan_suhu == "fahrenheit")
                suhuNormal = (suhu >= 97.7 && suhu <= 99.5);

            bool hariValid = hariDemam < config.batas_hari_deman;

            if (suhuNormal && hariValid)
                Console.WriteLine(config.pesan_diterima);
            else
                Console.WriteLine(config.pesan_ditolak);

            // Ubah satuan suhu
            config.UbahSatuan();
            Console.WriteLine($"Satuan suhu baru: {config.satuan_suhu}");
        }
    }
}
