using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BABoostKütüphane;

namespace SayiTopla
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 100, Min = 1;
            int EklenecekSayı, Toplam;
            

            Login();
            Toplam = KullanıcıdanVeriAlmaİşlemleri.KullanıcıdanİntegerDeğerOku("lütfen ilk değeri giriniz",Min,Max);

            do
            {
                EklenecekSayı = KullanıcıdanVeriAlmaİşlemleri.KullanıcıdanİntegerDeğerOku("lütfen eklenecek değeri giriniz", Min, Max);
                Toplam += EklenecekSayı;
                ToplamıEkranYaz(Toplam);

            } while (KullanıcıdanVeriAlmaİşlemleri.KullanıcıdanBoolDeğerAl("Ek bir rakamı daha toplamak istermisiniz?"));
            

            
            Logout();
        }

        private static void ToplamıEkranYaz(int Toplam)
        {
            Console.WriteLine("Toplam= " + Toplam.ToString());
        }

        private static void Logout()
        {
            Console.WriteLine("İyi günler");
            Console.ReadLine();
        }

        private static void Login()
        {
            Console.WriteLine("Hoşgeldiniz. İstediğiniz kadar sayı toplayabilirsiniz.");
        }
    }
}
