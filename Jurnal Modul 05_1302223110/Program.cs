using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_05_1302223110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<long> basdat = new SimpleDataBase<long>();
            basdat.AddNewData(5);
            basdat.AddNewData(8);
            basdat.AddNewData(10);

            basdat.PrintAllData();
        }
    }
}
