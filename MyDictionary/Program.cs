using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();

            sehirler.Add(26, "Eskişehir");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(48, "Muğla");
            sehirler.Add(35, "İzmir");
            sehirler.Add(01, "Adana"); 
            sehirler.Add(59, "Tekirdağ");
            Console.WriteLine(sehirler.Count);

            MyDictionary<string, string> sozluk = new MyDictionary<string, string>();
            sozluk.Add("door", "kapı");
            sozluk.Add("bag", "çanta");
            Console.WriteLine(sozluk.Count);
        }
    }
}