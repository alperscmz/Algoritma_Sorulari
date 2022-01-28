using System;
namespace Algoritma_Sorulari
{
    class Program
    {
        static void Main(string[]args)
        {
            //Ödev1 
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
          Console.WriteLine("***********ÖDEV1***********");
          Console.Write("Lütfen pozitif bir sayi giriniz: ");
          int n=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Lütfen {0} adet pozitif sayi giriniz: " ,n);
          for(int i=0; i<n ; i++)
          {
              Console.WriteLine("{0}. sayıyı giriniz",i+1);
              int sayi=Convert.ToInt32(Console.ReadLine());
              if(sayi%2==0)
              {
                  Console.WriteLine("Çift sayı girdiniz: " +sayi);
              }
              else
              {
                  Console.WriteLine("Tek sayı girdiniz: " +sayi);
                  Console.WriteLine("İşleminiz bitmiştir !");
                  
              }
          }
             //Ödev2
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("***********ÖDEV2***********");
            Console.WriteLine("Pozitif iki sayı giriniz: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            int m1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz : ",n1);
            for(int i=0; i<n1 ; i++)
            {
              Console.WriteLine("{0}. sayıyı giriniz",i+1);
              int sayi=Convert.ToInt32(Console.ReadLine());
              if((sayi==m1) || (sayi%m1==0))
              {
                  Console.WriteLine("Sayı m'ye eşit ve ya tam bölünmektedir: "+sayi);
                  Console.WriteLine("İşleminiz bitmiştir !");
                  
              }
            }
            //Ödev3
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("***********ÖDEV3***********");
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen {0} adet kelime giriniz: " ,n2);
            string[] kelimeler=new string[n2];
             for(int i=0;i<n2;i++)
            {
                kelimeler[i]=Console.ReadLine();
            }
            Console.WriteLine("Girilen kelimelerin sondan başa doğru sıralanışı: ");
            for(int i=n2-1;i>=0;i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
            //Ödev4
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("***********ÖDEV4***********");
            Console.WriteLine("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeler1 = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler1.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("toplam {0} tane  harf vardır.", sayac);
            Console.ReadLine();
            Console.WriteLine("İşleminiz bitmiştir !");
            Console.WriteLine(" ");
            //alper saçmaözü
        }
    }
}
