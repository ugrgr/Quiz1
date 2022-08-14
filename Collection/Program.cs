// See https://aka.ms/new-console-template for more information
using System.Collections;
//*********   kısa olanları Burda yaptım uznları farklı classlarda   *********************


Console.WriteLine("Sonraki örnek için bir tuşa basın:");
//*************** Arraylist **********
Console.WriteLine("************* Arraylist ****************");

ArrayList arrayList = new ArrayList();
arrayList.Add("Uğur");
arrayList.Add(12);
arrayList.Add(8f);
arrayList.Add(new string[]
    { "Onur", "Mustafa", "Can" });
Console.WriteLine(arrayList[0]);
Console.WriteLine(arrayList[1]);
Console.WriteLine(arrayList[2]);
Console.WriteLine((arrayList[3] as string[])[0]);
Console.WriteLine((arrayList[3] as string[])[1]);
Console.WriteLine((arrayList[3] as string[])[2]);
Console.ReadKey();

//************* Kuyruk ****************
Console.WriteLine("************* Kuruk ****************");

Queue queue = new Queue();
queue.Enqueue("1. Nesne");
queue.Enqueue("2. Nesne");
queue.Enqueue("3. Nesne");
Console.WriteLine("Kuyrukta " + queue.Count + " adet nesne var");
Console.WriteLine(queue.Dequeue());
Console.WriteLine("Kuyrukta " + queue.Count + " adet nesne var");
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.ReadKey();

//************* Yığın (Stack) ****************
Console.WriteLine("************* Stack ****************");

Stack stack = new Stack();
stack.Push("1.Nesne");
stack.Push("2.Nesne");
stack.Push("3.Nesne");
Console.WriteLine("Yığında " + stack.Count + " adet nesne var");
Console.WriteLine(stack.Pop());
Console.WriteLine("Yığında " + stack.Count + " adet nesne var");
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.ReadKey();

//************* Listeler ****************
    Console.WriteLine("************* Listeler ****************");

    List<string> ulkeler = new List<string>();
    ulkeler.Add("Türkiye");
    ListeYaz(ulkeler);
    ulkeler.Add("Azerbaycan"); 
    ListeYaz(ulkeler);
    ulkeler.Add("Fransa"); 
    ListeYaz(ulkeler);
    ulkeler.Add("Almanya");
    ListeYaz(ulkeler);
    ulkeler.Add("Hollanda"); 
    ListeYaz(ulkeler);
    ulkeler.Add("İspanya"); 
    ListeYaz(ulkeler);
    ulkeler.Add("Şili"); 
    ListeYaz(ulkeler);
    ulkeler.Remove("Almanya"); 
    ListeYaz(ulkeler);
    ulkeler.RemoveAt(4); 
    ListeYaz(ulkeler);
    ulkeler.Reverse(); 
    ListeYaz(ulkeler);
    ulkeler.AddRange(new string[5]
    {
        "Irak", "İran", "Pakistan", "Hindistan", "Çin"
    }); 
    ListeYaz(ulkeler);
    ulkeler.Insert(3, "Rusya");
    ListeYaz(ulkeler);
    string[] yeni_ulkeler = new string[]
        { "Norveç", "İsveç", "Danimarka" };

    ulkeler.InsertRange(5, yeni_ulkeler);
    ListeYaz(ulkeler);

    Console.WriteLine(ulkeler.IndexOf("Türkiye"));
    Console.ReadKey();

static void ListeYaz(List<string> ulkeler)
{
    Console.Clear();
    foreach (var ulke in ulkeler)
        Console.WriteLine(ulke);
    Console.ReadKey();
}


//************* HashSet ****************

Console.WriteLine("************* HashSet ****************");

HashSet<string> hashSet = new HashSet<string>();
hashSet.Add("Ali");
HashSetYaz(hashSet);
hashSet.Add("Samet");
HashSetYaz(hashSet);
hashSet.Add("Ali");
HashSetYaz(hashSet);
hashSet.Add("Mustafa"); 
HashSetYaz(hashSet);
hashSet.Add("Yasin"); 
HashSetYaz(hashSet);
bool eklenme_durumu = hashSet.Add("Ali");
Console.WriteLine(eklenme_durumu);
Console.ReadKey();


static void HashSetYaz(HashSet<string> kisiler)
{
    Console.Clear();
    foreach (var kisi in kisiler)
        Console.WriteLine(kisi);
    Console.ReadKey();
}