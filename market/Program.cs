using System.Linq.Expressions;  

Console.WriteLine("====MARKET====");
Console.WriteLine("hosgeldiniz");

 string[] urunler = { "su ", "kahve ", "sandvic ", "cikolata "};
 int[] fiyatlar = { 20 , 160  , 240 , 50 };
 int toplam = 0;
 List<string> sepet = new List<string>();
while (true)
{ 
    Console.WriteLine("1-su | 2-kahve | 3-sandvic | 4-cikolata | 0-bitir");
    Console.WriteLine("urun seciniz");
    string giris = Console.ReadLine();
    if (!int.TryParse(giris, out int secim) || secim < 0 || secim > urunler.Length)
    {
        Console.WriteLine("lutfen gecerli bir sayi giriniz");
        continue;
    }
    
    if (secim >=1 && secim <= urunler.Length)
    {
        Console.WriteLine(urunler[secim - 1] +  "sectiniz " + "fiyati: " + fiyatlar[secim - 1] + " TL");

        int adet;
        while (true)
        {
            Console.WriteLine("kac adet istiyorsunuz istemiyorsaniz 0'a basiniz");
            Console.WriteLine("en fazla 100 tane secebilirsiniz");
            string adetgiris = Console.ReadLine();

            if (int.TryParse(adetgiris, out adet) && adet >= 0 && adet <=100)
            {
                break;
            }
            Console.WriteLine("gecerli bir adet giriniz");
        }
        int aratoplam = fiyatlar[secim - 1] * adet;
        Console.WriteLine("ara toplam: " + aratoplam + "TL");
        toplam += aratoplam;

        sepet.Add(urunler[secim - 1] + " * " + adet + " = " + aratoplam + " TL");
    }
    else if (secim == 0)
    {
        Console.WriteLine();
        Console.WriteLine("====SEPET====");

        foreach(string urun in sepet)
        {
            Console.WriteLine(urun);
        }

        Console.WriteLine("toplam tutar: " + toplam + " TL");
        
        string odeme;

        while (true)
        {
            Console.WriteLine("odeme yontemi secin");
            Console.WriteLine("1-kart");
            Console.WriteLine("2-nakit");

            odeme = Console.ReadLine();

            if (odeme == "1" || odeme == "2")
            {
               break;
            }

         Console.WriteLine("lutfen gecerli bir odeme yontemi secin");
        }

        if (odeme == "1")
        {
            Console.WriteLine("kart ile odeme secildi");
        }
        else
        {
            Console.WriteLine("nakit ile odeme secildi");
        }

        Console.WriteLine("odenecek tutar: " + toplam + " TL");
        Console.WriteLine("program kapatiliyor");
            break;
    }
}