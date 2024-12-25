// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

// 1.ÖRNEK: "While" ile kullanıcıdan alınan bir değer kadar metinsel ifade yazdırmak.

Console.WriteLine("Bir limit değeri giriniz: ");
int limit = int.Parse(Console.ReadLine());
int sayac = 0;

            while (sayac <= limit)

            {
                    Console.WriteLine("Ben bir Patika'lıyım!");
                    sayac++;

            }

    // 2.ÖRNEK: Birinci örneğin aynısı "Do-While" ile yapılmıştır.
    // ÖNEMLİ NOT: Örneklerin ayrı ayrı yazılması gereksiz ya da spagetti kod olarak yorumlanmamalı.
    // Geri bildirim verecek olan arkadaşın yorum satırına daha kolay alarak test etmesi amaçlanmıştır.

Console.WriteLine("Bir limit değeri giriniz: ");
int limit = int.Parse(Console.ReadLine());
int sayac = 0;

            do

            {
                Console.WriteLine("Ben bir Patika'lıyım!");
                sayac++;
            }

            while (sayac <= limit); 
      // 1.Örnekte While kullanılmış ve koşul sağlandığı takdirde uygulama çalışmıştır.
      // Örneğin 1. örnekte limit değer olarak -8 yazınca ekrana herhangi bir çıktı gelmemektedir.
      // Bunun nedeni While'ın koşulu en başta kontrol etmesi ve koşul sağlanmazsa çıktı vermemesidir.
      // Fakat 2.Örnekte Do-While döngüsü koşul negatif bir deper bile girilse en az bir kere ekrana çıktı vermektedir.
      // Bunun nedeni ise Do-While'ın koşulu 1 kere yazdırdıktan sonra sonda kontrol etmesidir.
        
