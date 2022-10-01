using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calısma_konsolu2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            const double vize = 0.40;
            const double final = 0.60;

            Double vize_notu, final_notu ,sayi1, sayi2 , toplam;
            string girilen_vize, girilen_final;

            Console.WriteLine("Vize Ve Final Not Ortalaması :");
            Console.WriteLine("Vize Notu Giriniz : ");
            girilen_vize = Console.ReadLine();
            Console.WriteLine("Final Notu Giriniz : ");
            girilen_final = Console.ReadLine();
            sayi1 = Convert.ToByte(girilen_vize);
            sayi2 = Convert.ToByte(girilen_final);


            vize_notu = (sayi1 * vize);
            final_notu = (sayi2 * final);
            toplam = (sayi1 * vize) + (sayi2 * final);
            Console.WriteLine("Vize Notu : {0} ", vize_notu);
            Console.WriteLine("Final Notu : {0}", final_notu);
            Console.WriteLine("Toplam Not Ortalaması : {0}", toplam);

            Console.ReadLine();



         




           
          
            

            





        }
    }
}
