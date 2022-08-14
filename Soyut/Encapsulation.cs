// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ulke devlet1 = new ulke();
devlet1.Ad = "Türkiye";
devlet1.Baskent = "Ankara";
devlet1.ParaBirimi = "TL";
devlet1.Nufus = 9000000;
devlet1.Yazdir();

ulke devlet2 = new ulke();
devlet2.Ad = "Almanya";
devlet2.Baskent = "Berlin";
devlet2.Nufus = 10000000;
devlet2.ParaBirimi = "Euro";
devlet2.Yazdir();

Console.ReadKey();

class ulke
{

    string ?ad;
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }
    string ?baskent;

    public string Baskent
    {
        get { return baskent; }
        set { baskent = value; }
    }
    int nufus = 1500;

    public int Nufus
    {
        get { return nufus; }
        set { nufus = value; }
    }
    string ?paraBirimi;

    public string ParaBirimi
    {
        get { return paraBirimi; } 
        set { paraBirimi = value; } 
    }

    public void Yazdir()
    {
        Console.WriteLine("Ülke Adı    : " + ad);
        Console.WriteLine("Başkenti    : " + baskent);
        Console.WriteLine("Nüfusu      : " + nufus);
        Console.WriteLine("Para Birimi : " + paraBirimi);
        Console.WriteLine("=============================");
    }
}