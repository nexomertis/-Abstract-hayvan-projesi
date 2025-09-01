using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Hayvan3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus serce = new Kus();
            serce.Ad = "Serçe";
            serce.tur = "kuş";
            serce.yas = 2;
            serce.yasamalanı = "Ağaçlar";            
                
          serce.bilgiyaz();


            Kaplan kaplan = new Kaplan();
            kaplan.Ad = "Kara";
            kaplan.tur = "BENGAİ";
            kaplan.yas = 12;
            kaplan.yasamalanı = "ORMAN";

            kaplan.bilgiyaz();




        }
        public abstract class Hayvan

        {
            public  string Ad {  get; set; }
            public  string tur {  get; set; }

            public int yas { get; set; }

            public string yasamalanı { get; set; }



            public abstract void bilgiyaz();

        }
        public class Kus : Hayvan
        {
          
            
           public override void bilgiyaz()
            {

                Console.WriteLine($"Kuş Ad: {Ad}, Tür: {tur}, Yaş: {yas}, Yaşam Alanı: {yasamalanı}");

            }
               
        }
        public class Kaplan : Hayvan
        {
            public override void bilgiyaz()
            {
                Console.WriteLine($"Kaplan Ad: {Ad}, Tür: {tur}, Yaş: {yas}, Yaşam Alanı: {yasamalanı}");
            }
        }
    }
   
}
