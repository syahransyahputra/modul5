// See https://aka.ms/new-console-template for more information

using System.Linq;

internal class program
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {

            this.storedData.Add(data);
            this.inputDates.Add(DateTime.Now);

        }

        public void PrintAllData()
        {
            for(int i = 0; i < storedData.Count(); i++)
            {
                Console.WriteLine("Data "+ i +" berisi "+ storedData[i]+ 
                    ", yang di simpan pada waktu UTC: "+ inputDates[i]);
            }
        }


    }
    static void Main(string[] args)
    {
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(21);
        data.PrintAllData();
    }
}
