/****************************************************************************
**			    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**			    2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Serhat BİLAL
**				ÖĞRENCİ NUMARASI.......:B191210309
**              DERSİN ALINDIĞI GRUP...:A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            double ortalama;

            int AA = 0; int BA = 0; int BB = 0; int CB = 0; int CC = 0; int DC = 0; int DD = 0; int FD = 0; int FF = 0; int toplamOgrenciSayisi; //Her harf notu için bir değişken tanımlandı.

            StreamReader reader = new StreamReader("B191210309.txt"); //txt. dosyasının içindeki veriyi okumak için kullanıldı.
            string data = reader.ReadLine(); //satır okumak için readLine() metodu kullanıldı.
            while (data != null) // txt. dosyası boş değilse döngü başlayacak
            {
                Console.WriteLine(data); //satırları yaz.
                string[] values = data.Split(' '); // Bosluk ile ayrılanları parçalara ayır diziye yaz.

                data = reader.ReadLine();


                var odev1 = Convert.ToInt32(values[3]); //Dizinin 3.indisini al int'e çevir odev1 degişkenine at.
                var odev2 = Convert.ToInt32(values[4]); //Dizinin 4.indisini al int'e çevir odev2 degişkenine at.
                var vize = Convert.ToInt32(values[5]);  //Dizinin 5.indisini al int'e çevir vize degişkenine at.
                var final = Convert.ToInt32(values[6]); //Dizinin 6.indisini al int'e çevir final degişkenine at.

                ortalama = ((odev1 * 0.1) + (odev2 * 0.1) + (vize * 0.3) + (final * 0.5)); //ödevlerin ve sınavların kat sayıları yazılıp ortalama hesaplandı.


                //ortalamanın harf aralığı bulundu ve uygun değişken sayısı bir artırıldı.
                if (ortalama <= 100 && ortalama >= 90)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU: AA");
                    Console.WriteLine();

                    AA++;
                }
                else if (ortalama < 90 && ortalama >= 85)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  BA");
                    Console.WriteLine();

                    BA++;
                }
                else if (ortalama < 85 && ortalama >= 80)
                {
                    Console.WriteLine("Ortalamanız : " + ortalama + " HARF NOTU :BB");
                    Console.WriteLine();

                    BB++;
                }
                else if (ortalama < 80 && ortalama >= 75)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  CB");
                    Console.WriteLine();

                    CB++;
                }
                else if (ortalama < 75 && ortalama >= 65)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  CC");
                    Console.WriteLine();

                    CC++;
                }
                else if (ortalama < 65 && ortalama >= 58)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  DC");
                    Console.WriteLine();

                    DC++;
                }
                else if (ortalama < 58 && ortalama >= 50)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  DD");
                    Console.WriteLine();

                    DD++;

                }
                else if (ortalama < 49 && ortalama >= 40)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  FD");
                    Console.WriteLine();

                    FD++;
                }

                else if (ortalama < 40 && ortalama >= 0)
                {
                    Console.WriteLine("Ortalamanız: " + ortalama + " HARF NOTU:  FF");
                    Console.WriteLine();

                    FF++;
                }
            }

            StreamWriter yaz = File.AppendText("istatistik.txt"); // StreamWriter ile verilerimizi belirtilen konuma txt. olarak yazıp kaydettik.

            toplamOgrenciSayisi = (AA + BA + BB + CB + CC + DC + DD + FF + FD); //istatistik çıkarmak için tüm öğrenci sayıları bulundu.

            DateTime bugun = DateTime.Now; //Program birden çok çalıştırıldığında txt. dosyasında hangi kayıdın güncel oldugu anlaşılsın diye üzerine zaman eklendi.


            yaz.WriteLine("Kayıt tarihi " + bugun);

            //Bütün istatistikler ve zaman txt.dosyasına yazılıp dosya kapatıldı.

            yaz.WriteLine("HARF NOTU SAYISI ve YÜZDELİK KARŞILIĞI:");
            yaz.WriteLine("HARF NOTU AA OLAN  ÖĞRENCİ SAYİSİ : " + AA + " YÜZDESİ %: " + (100 * AA) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU BA OLAN  ÖĞRENCİ SAYİSİ : " + BA + " YÜZDESİ %: " + (100 * BA) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU BB OLAN  ÖĞRENCİ SAYİSİ : " + BB + " YÜZDESİ %: " + (100 * BB) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU CB OLAN  ÖĞRENCİ SAYİSİ : " + CB + " YÜZDESİ %: " + (100 * CB) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU CC OLAN  ÖĞRENCİ SAYİSİ : " + CC + " YÜZDESİ %: " + (100 * CC) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU DC OLAN  ÖĞRENCİ SAYİSİ : " + DC + " YÜZDESİ %: " + (100 * DC) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU DD OLAN  ÖĞRENCİ SAYİSİ : " + DD + " YÜZDESİ %: " + (100 * DD) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU FD OLAN  ÖĞRENCİ SAYİSİ : " + FD + " YÜZDESİ %: " + (100 * FD) / toplamOgrenciSayisi);
            yaz.WriteLine("HARF NOTU FF OLAN  ÖĞRENCİ SAYİSİ : " + FF + " YÜZDESİ %: " + (100 * FF) / toplamOgrenciSayisi);
            yaz.WriteLine();
            yaz.WriteLine();

            yaz.Close();

            //Aynı bilgiler program çalıştıktan sonra consol ekranına yazıldı zaman hariç.
            Console.WriteLine("HARF NOTU SAYISI ve YÜZDELİK KARŞILIĞI:");
            Console.WriteLine("HARF NOTU AA OLAN  ÖĞRENCİ SAYİSİ : " + AA + " YÜZDESİ %: " + (100 * AA) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU BA OLAN  ÖĞRENCİ SAYİSİ : " + BA + " YÜZDESİ %: " + (100 * BA) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU BB OLAN  ÖĞRENCİ SAYİSİ : " + BB + " YÜZDESİ %: " + (100 * BB) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU CB OLAN  ÖĞRENCİ SAYİSİ : " + CB + " YÜZDESİ %: " + (100 * CB) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU CC OLAN  ÖĞRENCİ SAYİSİ : " + CC + " YÜZDESİ %: " + (100 * CC) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU DC OLAN  ÖĞRENCİ SAYİSİ : " + DC + " YÜZDESİ %: " + (100 * DC) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU DD OLAN  ÖĞRENCİ SAYİSİ : " + DD + " YÜZDESİ %: " + (100 * DD) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU FD OLAN  ÖĞRENCİ SAYİSİ : " + FD + " YÜZDESİ %: " + (100 * FD) / toplamOgrenciSayisi);
            Console.WriteLine("HARF NOTU FF OLAN  ÖĞRENCİ SAYİSİ : " + FF + " YÜZDESİ %: " + (100 * FF) / toplamOgrenciSayisi);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; //Bildirim yazısının rengi kırmızı yazıldı.
            Console.WriteLine("Veriler text'e işlendi...");

            Console.ReadKey();

        }

    }
}