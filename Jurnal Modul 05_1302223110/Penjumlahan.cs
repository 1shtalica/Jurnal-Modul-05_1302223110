using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_05_1302223110
{
    internal class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic num3 = c;

            dynamic sum = num1 + num2 + num3;
            Console.WriteLine("Hasil Penjumlahan: " + sum);
        }
    }
}
