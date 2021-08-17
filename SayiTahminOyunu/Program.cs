using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
       basa:     Console.WriteLine("*** SAYI TAHMİN OYUNUNA HOŞ GELDİNİZ ***");
            Console.WriteLine("Aklınızdan 1 ile 100 arasında bir sayı tutunuz.");           

            Console.WriteLine("");
            string cevap;
            Random rastgele = new Random();
            int tahminEdilen = rastgele.Next(1, 101);
            
            Console.WriteLine("Tuttuğun sayı 50 ise E'ye daha buyukse B'ye daha küçükse K'ya bas");
            cevap = Console.ReadLine();
            if(cevap == "b" || cevap=="B")
            {
                tahminEdilen = rastgele.Next(51, 101);
                Console.WriteLine($"Tuttuğun sayı {tahminEdilen} ise E'ye daha buyukse B'ye daha küçükse K'ya bas");
                cevap = Console.ReadLine();
                
                
                    while (cevap == "b")
                    {

                        tahminEdilen = rastgele.Next(tahminEdilen + 1, 101);
                        Console.WriteLine($"Tuttuğun sayı {tahminEdilen} ise E'ye daha buyukse B'ye daha küçükse K'ya bas");
                        cevap = Console.ReadLine();

                    }
                
               
            }

            else if (cevap == "k" || cevap=="K")
            {
                while (cevap=="k")
                {
                    tahminEdilen = rastgele.Next(1, tahminEdilen);
                    Console.WriteLine($"Tuttuğun sayı {tahminEdilen} ise E'ye daha buyukse B'ye daha küçükse K'ya bas");
                    cevap = Console.ReadLine();
                    if (cevap == "e" || cevap == "E")
                    {
                        Console.WriteLine("Bildim.. Tekrar oynamak ister misin? E/H");
                        cevap = Console.ReadLine();
                        switch (cevap)
                        {
                            case "E":
                            case "e":
                                Console.Clear();
                                goto basa;
                            default:
                                Console.WriteLine("Görüşürüz..");
                                break;
                        }
                       
                    }
                    else
                    {

                    }
                }

                
                    
                
            }
            else if(cevap=="e" || cevap=="E")
            {
                Console.WriteLine("Bildim.. Tekrar oynamak ister misin? E/H");
                cevap = Console.ReadLine();
                switch (cevap)
                {
                    case "E":
                    case "e":
                        Console.Clear();
                        goto basa;
                    default:
                        Console.WriteLine("Görüşürüz..");
                        break;
                }
            }
                
               

            

            

           





            Console.ReadLine();

        }
        
    }
}
