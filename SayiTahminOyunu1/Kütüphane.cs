using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu1
{
    class Kütüphane
    {


        public static bool KullanıcıdanBoolDeğerAl(string SorulacakSoru)
        {
            Console.WriteLine(SorulacakSoru);
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "e":
                case "E":
                case "Evet":
                case "evet":
                    return true;
                case "H":
                case "h":
                case "Hayır":
                case "hayır":
                    return false;
                default:
                    Console.WriteLine("Cevabınız anlaşılmadı");
                    return KullanıcıdanBoolDeğerAl(SorulacakSoru);
            }
        }


        public static int KullanıcıdanİntegerDeğerOku(string SorulacakSoru, int Min, int Max)
        {
            Console.WriteLine(SorulacakSoru);
            string cevap = Console.ReadLine();
            try
            {
                int sonuc = Convert.ToInt32(cevap);
                if(sonuc<Min)
                {
                    Console.WriteLine("Girdiğiniz değer minimum değer olan" + Min.ToString() + " den küçük.");
                    Console.WriteLine("Lütfen tekrar giriş yapmayı deneyiniz");
                    return KullanıcıdanİntegerDeğerOku(SorulacakSoru, Min, Max);
                }
                if (sonuc > Max)
                {
                    Console.WriteLine("Girdiğiniz değer maksimum değer olan" + Max.ToString() + "den büyük.");
                    Console.WriteLine("Lütfen tekrar giriş yapmayı deneyiniz");
                    return KullanıcıdanİntegerDeğerOku(SorulacakSoru, Min, Max);
                }
                return sonuc;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rakam değeri oluşabilecek bir veri girmediniz");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Lütfen tekrar giriş yapmayı deneyiniz");
                return KullanıcıdanİntegerDeğerOku(SorulacakSoru, Min, Max);
               
            }
            
        }
    }
}
