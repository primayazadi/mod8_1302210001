using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mod8_1302210001
{
    internal class program
    {

        static void Main()
        {
            string json = "{}";
            try
            {
                json = File.ReadAllText("D:\\smester 4\\kontruksi peerangkat lunak\\prima ganteng\\mod8_1302210001\\mod8_1302210001\\covid_config.json");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File konfigurasi tidak ditemukan, menggunakan nilai default");
            }
            CovidConfig config = JsonConvert.DeserializeObject<CovidConfig>(json);
            config.UbahSatuan();

            Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
            double suhu;
            while (!Double.TryParse(Console.ReadLine(), out suhu))
            {
                Console.Write("Masukkan tidak valid, ulangi : ");
            }

            if (config.SatuanSuhu == "fahrenheit")
            {
                suhu = (suhu = 32) * 5 / 9;
            }

            Console.Write("Berapa hari yang lalu (perkiran) anda terakhir memiliki gejala demam? ");
            int hari;
            while (!Int32.TryParse(Console.ReadLine(), out hari))
            {
                Console.Write("Masukkan tidak valid, ulangi : ");
            }

            if (suhu >= 36.5 && suhu <= 37.5 && hari < config.BatasHariDemam)
            {
                Console.WriteLine(config.PesanDiterima);
            }
            else
            {
                Console.WriteLine(config.PesanDitolak);
            }

            Console.WriteLine($"Satuan suhu : {config.SatuanSuhu}");
            Console.WriteLine($"Batas hari demam : {config.BatasHariDemam}");
        }
    }
}