using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HoşgeldinizTanıtımYazısıMetodu();

            do
            {
                KullanıcıdanBirSayiTutmasınıİste();
                decimal Tahmin = BirTahminYap();
                bool TahminDoğru = TahminDoğruMu(Tahmin);
                while (true)
                {
                    TahminDoğru = TahminDoğruMu(Tahmin);
                    if (TahminDoğru)
                        break;

                    if (TahminKüçükMü(Tahmin))
                    {
                        Tahmin = YeniTahminYap(Tahmin, true);
                    }
                    else
                    {
                      Tahmin = YeniTahminYap(Tahmin, false);
                    }

                }
            
            } while (TekrarOynamakİstermisin());
            ProgramıBitir();
        }

        
        private static void ProgramıBitir()
        {
            Console.WriteLine("Güzel oynadık. \n Görüşmek üzere...");
            Console.ReadLine();
        }

      

        private static bool TekrarOynamakİstermisin()
        {
            return Kütüphane.KullanıcıdanBoolDeğerAl("Tekrar oynamak ister misin? (E/H)");
     
        }




        private static void TebriklerMesajıVer()
        {
            Console.WriteLine("Söylediğim gibi hangi sayıyı tahmin ettiğini buldum!");
            Console.WriteLine("Gördüğün gibi en iyisi benim");
        }

        private static void KullanıcıdanBirSayiTutmasınıİste()
        {
            Console.WriteLine("Aklından çok zor bilinebilecek bir sayı tut");
            Console.WriteLine("Sakın kimseye söyleme");
            Console.WriteLine("Sayıyı tutunca ENTER'a bas");
            Console.ReadLine();

        }

        private static void HoşgeldinizTanıtımYazısıMetodu()
        {
            // KullanıcıyaHoşGeldinDe
            Console.WriteLine("Beni Sayı Tahmin Oyunuma Hoş Geldin");

            //Programın nasıl Çalıştığını anlat
            Console.WriteLine("Aklından geçeni bileceğime eminim");
            Console.WriteLine("Beni denemek ister misin?");

        }

        private static bool TahminDoğruMu(decimal tahmin)
        {
            return Kütüphane.KullanıcıdanBoolDeğerAl("Tahmin ettiğim sayı doğru mu" + tahmin.ToString());
          
        }

        private static bool TahminKüçükMü(decimal tahmin)
        {
            return Kütüphane.KullanıcıdanBoolDeğerAl("Tahmin ettiğim sayı küçük mü(E/H)" + tahmin.ToString());

        }

        private static decimal YeniTahminYap(decimal EskiTahmin, bool Büyük)
        {
            decimal oran = OranGetir();
            if (Büyük)
            {
                return EskiTahmin + oran;
            }
            else
            {
                return EskiTahmin - oran;
            }
        }

        private static decimal OranGetir()
        {
            return 1;
        }

        private static decimal BirTahminYap()
        {
            return 5;
        }


    }
}
