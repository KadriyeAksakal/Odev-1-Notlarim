using System;

namespace GoogleApp
{
    class Program
    //**************** Modül 2 *************************
    //{ 
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!"); // gelen yazının bir alt satırdan başlamasını sağlar.
    //        Console.Write("Yeni Yazı"); // bir sonraki gelen yazı hemen sonuna eklenir.
    //        Console.Write("Diğer Yeni Yazı");
    //        Console.ReadLine(); // terminalin kapanmasını önler

    //    }
    //}

    //**************** Modül 3 *************************

    //{ // Değişkenler
    //    // private int a; // private keywordu başka bir class'tan erişilemez. public keywordu başka class'lardan erişilebilir.
    //    static int a;
    //    static float b;
    //    static bool c; // true || false logic operasyonlarında oldukça kullanılır.
    //    static string d; // birden fazla karakter yazabiliyoruz ekrana. 
    //    static void Main(string[] args)
    //    {
    //        a = 1; // a değişkenine a = 1 diyerek değer atayamayız bunun için değişken tipini private'tan static'e çeviriyoruz.
    //        b = 1.1f;
    //        c = true;
    //        d = "Birden fazla karakter";
    //        Console.WriteLine(a); //buna integar literal denir.
    //        Console.WriteLine(123); // direkt sayının kendisi de yazılabilir.
    //        Console.WriteLine(b);
    //        Console.WriteLine(4.0m); // decimal literal m olarak kullanılır.Bu suffix'i ister m istersek M olarak kullanabiliriz.
    //        Console.WriteLine(c);
    //        Console.WriteLine(false);
    //        Console.WriteLine(d);
    //        Console.ReadLine(); 

    //    }
    //}


    //{ // Deklarasyon 
    //    static void Main(string[] args)
    //    {
    //            var tam = true; // implicit declaration
    //            var floatDeger = 1.0f; // implicit declaration
    //            int tamSayi = 0;
    //            string benimAdım; //  isimlendirme için #$ koyulamaz _ koyulabilir başına keyword kesinlikle kullanılamaz. string, int gibi isim verilemez.
    //            benimAdım = "Kadriye";
    //            Console.WriteLine(benimAdım);
    //            benimAdım = "Aksakal";
    //            Console.WriteLine(benimAdım);
    //            Console.WriteLine(tamSayi);
    //            Console.WriteLine(tam);
    //            // tam = "hello world"; // bunun için hata verecektir çünkü değer tipi uyuşmamaktadır.
    //            Console.WriteLine(floatDeger);
    //            Console.ReadLine();

    //    }
    //    }


    //{ // Deklarasyon örnek
    //    static string city;
    //static void Main(string[] args)
    //{
    //        // İzmir'de bomba yedim ve tanesi 5 liraydı ve hava sıcaklığı 25,5 dereceydi.
    //        string food;
    //        int price;
    //        var temperature = 25.5;
    //        city = "İzmir'de";
    //        food = "bomba";
    //        price = 5;
    //        Console.WriteLine(city + ' '+ food + " yedim ve tanesi " + price + " liraydı ve hava sıcaklığı " + temperature + " dereceydi.");
    //        city = "İzmit'te";
    //        food = "pişmaniye";
    //        price = 10;
    //        temperature = 35.6;
    //        Console.WriteLine(city + ' ' + food + " yedim ve tanesi " + price + " liraydı ve hava sıcaklığı " + temperature + " dereceydi.");
    //        Console.ReadLine();

    //    }
    //}

    //{ // Escape Character Örnekler
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World"); // Aynı satırda aralarına boşluk bırakır.
    //        Console.WriteLine("Hello\nWorld"); // World kelimesini bir alt satıra yazar.
    //        Console.WriteLine("Hello\tWorld"); // World kelimesinden önce bir tab kadar boşluk bırakır.
    //        Console.WriteLine("\"Hello World\""); // "Hello World" şeklinde çıktı verir \ tan sonra yazılan " ekrana yazılır.
    //        Console.WriteLine("c:\\users\\kadriye\\appdata"); // ekrana c:\users\kadriye\appdata çıktısını verir.
    //        Console.WriteLine(@"c:\users\kadriye\appdata"); // Verbatim yani doğrudan kullanım şekli diyebiliriz.
    //        Console.ReadLine();

    //    }
    //}

    //{ // String Concatanate & Interpolation
    //    static void Main(string[] args)
    //    {
    //        string birinci = "Tolgay";
    //        string ikinci = "Unity Certificate Instructor " + birinci; // + işaretiyle birden fazla stringi birleştirebiliyoruz.
    //        string ucuncu = $"{birinci} {ikinci}"; // String Interpolation
    //        string dorduncu = $"{birinci} {ikinci} elle yazı yazabiliyoruz"; // String Interpolation
    //        string besinci = $@"c:\users\kadriye\{ikinci}\veri"; // verbatim ve string interpolation
    //        Console.WriteLine(ikinci);
    //        Console.WriteLine(ucuncu); // ekrana Tolgay Unity Certificate Instructor Tolgay yazacaktır.
    //        Console.WriteLine(dorduncu);
    //        Console.WriteLine(besinci);
    //        Console.ReadLine();

    //    }
    //}


    //**************** Modül 4 *************************

    { // Sayısal Operatörler
      // toplama
      //static void Main(string[] args)
      //{
      //    int birinci = 35;
      //    int ikinci = 34;
      //    Console.WriteLine(birinci + ikinci + " bir string"); // toplama
      //    Console.WriteLine(birinci + " bir string" + ikinci + 10); // 35 bir string 3410
      //    Console.WriteLine((birinci + 10) + " bir string" + ikinci + 10); // 45 bir string 3410
      //    Console.ReadLine();

        //}

        // dört işlem
        // işlem sırası önceliği () > Power(üstel sayilar) > çarpma ve bölme soldan sağa > toplama ve çıkarma soldan sağa
        //static void Main(string[] args)
        //{
        //    int birinci = 35;
        //    int ikinci = 34;
        //    int toplama = 35 + 34;
        //    int cikarma = 35 - 34;
        //    int carpma = 35 * 34;
        //    // int bolme = 35 / 34;
        //    float bolme = 35f / 34;
        //    float ikinciBolme = (float)birinci / ikinci; // type casting runtime da değiştirilir veri
        //    int mod = birinci % ikinci; // mod almak için % işareti kullanılır.
        //    Console.WriteLine("Toplam " +toplama + "\nCikarma " + cikarma + "\nCarpma " + carpma + "\nBolme " + bolme + "\nMod " + mod);
        //    Console.ReadLine();

        //}


        // Sayı operasyonları
        //static void Main(string[] args)
        //{
        //    // cm cinsinden inch e cevirme
        //    // m2 den sqfeet e cevirme
        //    // 150cm olan bir agacım 1000m2 arazimde tek başına duruyor.

        //    // 2.54cm = 1 inch
        //    // 1sqfeet = 0.092903m2 10.764

        //    int agac = 150;
        //    int alan = 1000;

        //    Console.WriteLine((agac/2.54f) + " inch olan bir ağacım " + (alan*10.764f) + " sqfeet arazimde tek başına duruyor.");
        //    // Console.WriteLine(15 + 2 * 4 + " sayısı, " + 2 + " sayısına tam bölünür");
        //    Console.ReadLine();

        //}


        //**************** Modül 5 *************************

        // Class: Namespace Yapıları
        //static void Main(string[] args)
        //{
        //    Yeni inst = new Yeni(); // instantiate runtime da yeni tipinde bir instance'ımız oluşacak böylelikle

        //    inst.birinci = 10;
        //    inst.ikinci = 20;

        //    // Console.WriteLine(inst.birinci + inst.ikinci);
        //    Console.WriteLine(inst.toplama()); // fonk. kullanımı


        //    Console.WriteLine(Math.Pow(10f, 2f)); // 10 un 2. kuvveti
        //    Console.WriteLine(Math.Min(20,10));// en kucuk deger
        //    Console.WriteLine(Math.Abs(-24.5f));// mutlak deger


        //    Console.ReadLine();

        //}

        //class Yeni
        //{
        //    public int birinci; // başka classtan okunabilsin diye public olarak tanımlıyoruz.
        //    public int ikinci;

        //    public int toplama()
        //    {
        //        return birinci + ikinci;
        //    }
        //}

        // Mantıksal Operasyonlar
        static void Main(string[] args)
        {

            // 20ye kadar sayi olan bir zar
            // 15-20 arasinda buyuk zarar
            //10-15 arasinda orta zarar
            // 5-10 arasinda zarar yok
            // 0-5 arasinda kendine zarar

            Random zar = new Random();

            int birinciAtis = zar.Next(1,21); // istersek belirli aralıkta veya sonsuz sayi araliginda sayi dondurur (1 ile 20 arasında sayi dondurur)
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;

            if(ortalama > 15)
            {
                Console.WriteLine("Büyük zarar verdin.");
            }

            if(ortalama > 10 && ortalama <= 15)
            {
                Console.WriteLine("Orta zarar verdin.");
            }

            if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("Zarar Yok.");
            }

            if (ortalama <= 5)
            {
                Console.WriteLine("Kenidine zarar verdin.");
            }

            Console.WriteLine(ortalama);
            Console.WriteLine(birinciAtis + " " + ikinciAtis + " " + ucuncuAtis + " " + dorduncuAtis + " " + besinciAtis); 
            Console.ReadLine();
        

        }
    }
}
