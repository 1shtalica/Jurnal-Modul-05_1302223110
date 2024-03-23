using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_05_1302223110
{
    internal class SimpleDataBase<T>
    {
        private List<T> storeData;

        private List<DateTime> inputDates;

        public SimpleDataBase() 
        {
            storeData = new List<T>();
            inputDates = new List<DateTime>();  

        }

        public void AddNewData(T data)
        {
            storeData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine($"Data {i+1} berisi: {storeData.ElementAt(i)}, yang disimpan pada waktu UTC: {inputDates.ElementAt(i)}");
            }
        }
    }
}
