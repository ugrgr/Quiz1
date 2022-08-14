// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tüm prensipleri tek senaryoda uygulamaya çalıştım");
public interface Hayvanlar
{
    string SolunumYapar();
    string Beslenir();
}
public interface Ucar
{
    string Ucabilir();
}
public interface Yuzer
{
    string Yuzebilir();
}
public interface Yumurtlar
{
    string Yumurtlayabilir();
}
public interface Dogurur
{
    string Dogurabilir();
}


public abstract class Kuslar : Hayvanlar
{   //kuşlar uçabilir ama tüm kuşlar uçamaz o yüzden uçma özelliğini ayrı bir interface olarak tanımladım kuşlar ile kalıtım sağlamadım ki  kuşlardan türeyen tavuk
    //  uçma özelliğinden etkilenmesin.
    public string Beslenir()
    {
        return "Kuşlar beslenir";
    }
    public string SolunumYapar()
    {
        return "Kuşlar solunum Yapar";
    }
}
public abstract class Balik : Hayvanlar, Yuzer
{
    public string Solungac()
    {
        return "Balıkların solungacı var";
    }
    public string SolunumYapar()
    {
        return "Balıklar solunum yapar";
    }
    public string Beslenir()
    {
        return "Balıklar beslenir";
    }
    public string Yuzebilir()
    {
        return "Balıklar yüzeribir";
    }
    public string Yumurtlayabilir()
    {
        return "Balıklar yumurtlayabilir";
    }
}

class Yarasa : Kuslar, Dogurur
{
    // yarasalar yumurtlayamaz ama kuşların ve hayvanların diğer özelliklerini taşırlar
    public string Dogurabilir()
    {
        return "Yarasalar doğurabilir";
    }
}

class leylek : Kuslar, Yumurtlar, Ucar
{
    public string Ucabilir()
    {
        return "Yarasa uçabilir";
    }

    public string Yumurtlayabilir()
    {
        return "Leylek yumurtlayabilir";
    }
}

class Hamsi : Balik, Yumurtlar
{
    public string Yumurtlar()
    {
        return "Hamsi yumurtlayabilir";
    }
}

class Tavuk : Kuslar, Yumurtlar
{// tavuk kuşlar ve hayvanların tüm özelliklerini taşır ama uçamaz
    public string Yumurtlayabilir()
    {
        return "Tavuk yumurtlayabilir";
    }
}
class Yunus : Balik, Dogurur
{// Yunus balikların hayvanların tüm özelliklerini taşır ama yumrutlamaz doğurur
    public string Dogurabilir()
    {
        return "Yunuslar doğurabilir";
    }
}