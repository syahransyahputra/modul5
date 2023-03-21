// See https://aka.ms/new-console-template for more information

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T no1, T no2, T no3)
    {
        dynamic nomor1 = no1;
        dynamic nomor2 = no2;
        dynamic nomor3 = no3;

        return nomor1 + nomor2 + nomor3;
    }

    static void Main(string[] args)
    {
        Penjumlahan jumlah= new Penjumlahan();
        Console.WriteLine(jumlah.JumlahTigaAngka(13, 02, 21));
    }

}