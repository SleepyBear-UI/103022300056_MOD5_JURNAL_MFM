// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
class simpleDatabase<T>
{
    private List<T> storeData;
    private List<DateTime> inputDate;

    public simpleDatabase()
    {
        storeData = new List<T>();
        inputDate = new List<DateTime>();
    }

    // menyimpan data berupa new data dan waktu input data tersebut
    public void addNewData(T data)
    {
        storeData.Add(data);
        inputDate.Add(DateTime.Now);
    }

    // menampilkan seluruh data yang disimpan kedalam storedata dan input date
    public void printAllData()
    {
        for (int i = 0; i < storeData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} Berisi: {storeData[i]}, yang disimpan pada waktu UTC : {inputDate[i]}");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        simpleDatabase<int> database = new simpleDatabase<int>();
        database.addNewData(12);
        database.addNewData(34);
        database.addNewData(56);
        database.printAllData();
    }

}