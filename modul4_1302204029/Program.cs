using System;

namespace modul4_1302204029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahAngkaTiga<long>(13, 02, 20));
            List<int> obj data = new List<int>();
            objData.AddDataBaru(12);
            objData.AddDataBaru(34);
            objData.AddDataBaru(56);

            Console.WriteLine(objData.GetDataTerakhir());
            objData.PrintAllData();
        }
    }
    class Penjumlahan
    {
        public static T JumlahAngkaTiga<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;

            return tempA + tempB + tempC;
        }
    }
    class SimpleDataBase
    {
        private List<T> storedData;
        private List<Date> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
        }
        public void addDataBaru(Task dataBaru)
        {
            storedData.Add(dataBaru);
        }
        public void GetDataTerakhir()
        {
            int panjangList = storedData.Count;
            return storedData[panjangList - 1];
        }
        public void PrintAllData()
        {
            foreach( Task tiapData in storedData)
            {
                Console.WriteLine(tiapData);
            }
        }
    }
}
