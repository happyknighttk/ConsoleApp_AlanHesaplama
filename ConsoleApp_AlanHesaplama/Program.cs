using System;

namespace ConsoleApp_AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;

            do
            {
                MenuYaz();

                Console.Write("Seçiminiz: ");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        KareAlanHesaplama();
                        break;
                    case 2:
                        DikdortgenAlanHesaplama();
                        break;
                    case 3:
                        UcgenAlanHesaplama();
                        break;
                    case 4:
                        YamukAlanHesaplama();
                        break;

                    default:
                        break;
                }
            } while (secim != 0);

            static void MenuYaz()
            {
                Console.Clear();

                EkranaBaslikYaz("Alan Hesaplama Uygulaması");
                Console.WriteLine();

                EkranaBaslikYaz("Menü");
                Console.WriteLine("1) Kare Alanı Hesapla");
                Console.WriteLine("2) Dikdörtgen Alanı Hesapla");
                Console.WriteLine("3) Üçgen Alanı Hesapla");
                Console.WriteLine("4) Yamuk Alanı Hesapla");
                Console.WriteLine("0) Çıkış");
                Console.WriteLine();
            }

            static void EkranaBaslikYaz(string baslik)
            {
                Console.WriteLine(baslik);

                for (int i = 0; i < baslik.Length; i++)
                    Console.Write('-');

                Console.WriteLine();
                Console.WriteLine();
            }

            static void DevamButonu()
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen devam etmek için bir tuşa basınız.");
                Console.ReadKey();
            }

            static void KareAlanHesaplama()
            {
                Console.Clear();

                EkranaBaslikYaz("Kare Alan Hesaplama");
                Console.Write("Lütfen a kenar giriniz(cm): ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Kare alanı: " + (a * a) + " cm^2");

                DevamButonu();
            }

            static void DikdortgenAlanHesaplama()
            {
                Console.Clear();

                EkranaBaslikYaz("Dikdörtgen Alan Hesaplama");

                Console.Write("Lütfen a kenar giriniz(cm): ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Lütfen b kenar giriniz(cm): ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Dikdörtgen alanı: " + (a * b) + " cm^2");

                DevamButonu();
            }

            static void UcgenAlanHesaplama()
            {
                Console.Clear();

                EkranaBaslikYaz("Üçgen Alan Hesaplama");

                Console.Write("Lütfen a kenar giriniz(cm): ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Lütfen h yükseklik giriniz(cm): ");
                int h = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Üçgen alanı: " + (Convert.ToDouble(a) * Convert.ToDouble(h) / 2d) + " cm^2");

                DevamButonu();
            }

            static void YamukAlanHesaplama()
            {
                Console.Clear();

                EkranaBaslikYaz("Yamuk Alan Hesaplama");

                Console.Write("Lütfen a kenar giriniz(cm): ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Lütfen b kenar giriniz(cm): ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Lütfen h yükseklik giriniz(cm): ");
                int h = int.Parse(Console.ReadLine());

                double sub = (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2d;
                double result = sub * Convert.ToDouble(h);

                Console.WriteLine();
                Console.WriteLine("Yamuk alanı: " + result + " cm^2");

                DevamButonu();
            }

            return;
        }
    }
}
