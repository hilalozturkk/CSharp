using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try//hata bulunabilecek kısım burada 
            {

                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            }
            catch (Exception ex)//hata varsa bu kısıma girer
            {
                Console.WriteLine("Hata :"+ ex.Message.ToString());//sadece exception mesajını göster
            }
            finally//her koşulda çalışır
            {
                Console.WriteLine("İşlem tamamlandı");
            }


            // Hangi hatada hangi Exception fırlatacağımızı belirleyebiliriz

            try
            {
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentException ex)
            {
                
               Console.WriteLine("Boş değer girdiniz...");
               Console.WriteLine(ex);
            }
            catch(FormatException ex){
   
               Console.WriteLine("Veri tipi uygun verilmedi...");
               Console.WriteLine(ex);
            }
            catch(OverflowException ex){
   
               Console.WriteLine("Aralığı kapsamayan bir sayı girildi...");
               Console.WriteLine(ex);
            }

        }
    }
}
