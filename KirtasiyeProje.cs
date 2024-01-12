using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirtasiyeProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            12.Ürünler
            //Defter Kalem Silgi Not defteri
            //Kalem
            //açacağı Pergel


            //Fiyatları
            //6,50 tl 1 tl 0,50 tl 2,50 TL 0,5 1,50 tl
            //Yukarıda bir kırtasiyeye ait ürünler ve fiyatları verilmiştir.Sizden istenen programda olması gerekenler;
            //• Ürünler ve fiyatları ile ilgili bir uygun veri türünü kullanarak dizi tanımlamanız ve bilgileri
            //yerleştirmenizdir.
            //• Program kullanıcıya tüm ürünler için kaç adet almak istediğini soracak. Örneğin "Kalem almak ister 
            //misiniz? Eğer almak isterseniz adetini istemezseniz 0 giriniz." 
            //• Bir kullanıcının yapmış olduğu alışverişe göre ödemesi gereken fiyatı ekrana yazdırılması
            //istenmektedir.Aşağıda ekranda görülmesi gereken görüntü örneği verilmiştir;
            //            Kalem 2 adet = 2x1 = 1 tl
            //            Not defteri 6 adet = 6x2.50 = 15 tl
            //            Pergel 1 adet = 1x1.50 = 1.50 tl
            ////            Toplam 17.50 tl
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("                          ÜRÜN LİSTESİ VE FİYATLARI                     ");
            Console.WriteLine("******************************************************************************************");


            string[,] dizi = new string[2, 7];
            string ürünler = " ÜRÜNLER :";
            string fiyat = "FİYATLAR :";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string defter = "6.50TL";
            string kalem = "1TL";
            string silgi = "0.5TL";
            string notdefteri = "2.50TL ";
            string açıcak = "0.5TL";
            string pergel = "50TL";

            dizi[0, 0] = ürünler;
            dizi[0, 1] = "Defter";
            dizi[0, 2] = "Kalem";
            dizi[0, 3] = "Silgi";
            dizi[0, 6] = "Not Defteri ";
            dizi[0, 5] = "Açıcak";
            dizi[0, 4] = "Pergel";


            dizi[1, 0] = fiyat;
            dizi[1, 1] = defter;
            dizi[1, 2] = kalem;
            dizi[1, 3] = silgi;
            dizi[1, 6] = notdefteri;
            dizi[1, 5] = açıcak;
            dizi[1, 4] = pergel;


            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {

                    Console.Write("\t" + dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("******************************************************************************************");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("KALEM ALMAK İSTERMİSİNİZ ALMAK İSTERSENİZ ALMAK İSTEDİGİNZ KALEM ADETİNİ GİRİNİZ İSTEMEZSENİZ 0 BASIN : ");
            Double Kadet = Convert.ToDouble(Console.ReadLine());
            double a = Kadet;
            if (Kadet != 0)
                Kadet *= 1;
            Console.WriteLine();
            Console.Write("DEFTER ALMAK İSTERMİSİNİZ ALMAK İSTERSENİZ ALMAK İSTEDİGİNZ DEFTER ADETİNİ GİRİNİZ İSTEMEZSENİZ 0 BASIN: ");
            Double Dadet = Convert.ToDouble(Console.ReadLine());
            double b = Dadet;
            if (Dadet != 0)
                Dadet *= 6.5;
            Console.WriteLine();
            Console.Write("SİLGİ ALMAK İSTERMİSİNİZ ALMAK İSTERSENİZ ALMAK İSTEDİGİNZ SİLGİ ADETİNİ GİRİNİZ İSTEMEZSENİZ 0 BASIN: ");
            Double Sadet = Convert.ToDouble(Console.ReadLine());
            Double c = Sadet;
            if (Sadet != 0)
                Sadet *= 0.5;
            Console.WriteLine();
            Console.Write("NOT DEFTERİ ALMAK İSTERMİSİNİZ ALMAK İSTERSENİZ ALMAK İSTEDİGİNZ NOT DEFTERİ ADETİNİ GİRİNİZ İSTEMEZSENİZ 0 BASIN: ");
            Double Nadet = Convert.ToDouble(Console.ReadLine());
            double d = Nadet;
            if (Nadet != 0)
                Nadet *= 2.5;
            Console.WriteLine();
            Console.Write("PERGEL ALMAK İSTERMİSİNİZ ALMAK İSTERSENİZ ALMAK İSTEDİGİNZ PERGEL ADETİNİ GİRİNİZ İSTEMEZSENİZ 0 BASIN: ");
            Double Padet = Convert.ToDouble(Console.ReadLine());
            double e = Padet;
            if (Padet != 0)
                Padet *= 50;
            Console.WriteLine();
            Console.Write("AÇICAK ALMAK İSTERMİSİNİZ ALMAK İSTERSENİZ ALMAK İSTEDİGİNZ AÇICAK ADETİNİ GİRİNİZ İSTEMEZSENİZ 0 BASIN: ");
            Double Aadet = Convert.ToDouble(Console.ReadLine());
            double f = Aadet;
            if (Aadet != 0)
                Aadet *= 0.5;
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Kalem\t" + "     " + a + "Adet ->   " + a + "X" + "1" + "=" + Kadet + "TL");
            Console.WriteLine("Defter\t" + "     " + b + "Adet ->   " + b + "X" + "6.5" + "=" + Dadet + "TL");
            Console.WriteLine("silgi\t" + "     " + c + "Adet ->   " + c + "X" + "0.5" + "=" + Sadet + "TL");
            Console.WriteLine("Not Defteri" + "  " + d + "Adet ->   " + d + "X" + "2.5" + "=" + Nadet + "TL");
            Console.WriteLine("Pergel\t" + "     " + e + "Adet ->   " + e + "X" + "50" + "=" + Padet + "TL");
            Console.WriteLine("Açıcak\t" + "     " + f + "Adet ->   " + f + "X" + "0.5" + "=" + Aadet + "TL");
            double ürüntoplam = Kadet + Dadet + Padet + Sadet + Nadet + Aadet;
            Console.Write("+  ");
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" *** TOPLAM ALIŞVERİŞ ÜCRETİNİZ = {0}", ürüntoplam + "TL" + "***");
            Console.WriteLine("                                                             İYİ GÜNLER DİLERİZ                                                       ");

            Console.Read();
        }
    }
}
