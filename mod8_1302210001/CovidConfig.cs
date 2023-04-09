using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod8_1302210001
{
    internal class CovidConfig
    {
        public string SatuanSuhu { get; set; } = "celcius";
        public int BatasHariDemam { get; set; } = 14;
        public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public string PesanDiterima { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";

        public void UbahSatuan()
        {
            if (SatuanSuhu == "celcius")
            {
                SatuanSuhu = "fahrenheit";
            }
            else if (SatuanSuhu == "fahrenheit")
            {
                SatuanSuhu = "celcius";
            }
        }
    }
}