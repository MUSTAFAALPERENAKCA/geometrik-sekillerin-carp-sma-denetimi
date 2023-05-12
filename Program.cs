using carpısmadenetimi;

namespace aaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Nokta nokta = new Nokta();
            dikdortgen dikdortgen = new dikdortgen();
            dikdortgen dikdortgen1 = new dikdortgen();
            dikdortgen dikdortgen2 = new dikdortgen();
            Nokta3d nokta3d = new Nokta3d();
            Cember cember = new Cember();
            Cember cember1 = new Cember();
            Cember cember2 = new Cember();
            DikdortgenPrizması Prizma = new DikdortgenPrizması();
            DikdortgenPrizması Prizma1 = new DikdortgenPrizması();
            DikdortgenPrizması Prizma2 = new DikdortgenPrizması();
            kure kure1 = new kure();
            kure kure2 = new kure();
            kure kure = new kure();
            Silindir silindir = new Silindir();
            Silindir silindir1 = new Silindir();
            Silindir silindir2 = new Silindir();
            Yuzey yuzey = new Yuzey();

            Console.WriteLine("MENÜ");
            Console.WriteLine("1) Nokta, Dörtgen çarpışma denetimi\r\n" +
                "2) Nokta, çember çarpışma denetimi\r\n" +
                "3) Dikdörtgen, dikdörtgen çarpışma denetimi\r\n" +
                "4) Dikdörtgen, çember çarpışma denetimi\r\n" +
                "5) Çember, çember çarpışma denetimi\r\n" +
                "6) Nokta, Küre çarpışma denetimi\r\ng" +
                "7) Nokta, dikdörtgen prizma çarpışma denetimi\r\n" +
                "8) Nokta, Silindir çarpışma denetimi\r\n" +
                "9) Silindir, silindir çarpışma denetimi\r\n" +
                "10) Küre, küre çarpışma denetimi\r\n" +
                "11) Küre silindir çarpışma denetimi\r\n" +
                "12) Yüzey, küre çarpışma denetimi\r\n13) Yüzey, dikdörtgen prizma çarpışma denetimi\r\n" +
                "14) Yüzey silindir çarpışma denetimi\r\n" +
                "15) Küre, dikdörtgen prizma çarpışma denetimi\r\n" +
                "16) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi\r\n");
            Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ GİRİNİZ");
            int işlem=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("seçiminiz:"+işlem);
            if (işlem == 5)
            {
                if (CollisionDetection.CemberCember(cember1, cember2))
                    Console.WriteLine(" çemberler çarpışıyor");
                else
                    Console.WriteLine(" çemberler çarpışmıyor");
            }

            if (işlem == 4) 
            {
                if (CollisionDetection.DikdortgenCember(dikdortgen, cember))
                    Console.WriteLine(" çemberle dikdörtgen çarpışıyor");
                else
                    Console.WriteLine(" çemberle dikdörtgen çarpışmıyor");
            }


            if (işlem == 3)
            {
                if (CollisionDetection.DikdortgenDikdortgen(dikdortgen1, dikdortgen2))
                    Console.WriteLine(" dikdörtgenler çarpışıyor");
                else
                    Console.WriteLine(" dikdörtgenler çarpışmıyor");
            }
            if (işlem == 16)
            {
                if (CollisionDetection.DikdörtgenprizmasıDikdörtgenprizması(Prizma1, Prizma2))
                    Console.WriteLine(" prizmalar çarpışıyor");
                else
                    Console.WriteLine(" prizmalar çarpışmıyor");
            }
            if (işlem == 15)
            {
                if (CollisionDetection.DikdörtgenprizmasıKüre(Prizma, kure))
                    Console.WriteLine("prizma ve küre çarpışıyor");
                else
                    Console.WriteLine(" prizma ve küre çarpışmıyor");
            }
            if (işlem == 13)
            {
                if (CollisionDetection.DikdörtgenprizmasıYüzey(Prizma, yuzey))
                    Console.WriteLine("prizma ve yüzey çarpışıyor");
                else
                    Console.WriteLine(" prizma ve yüzey çarpışmıyor");
            }

            if (işlem == 10)
            {
                if (CollisionDetection.KureKure(kure1, kure2))
                    Console.WriteLine("küreler çarpışıyor");
                else
                    Console.WriteLine(" küreler çarpışmıyor");
            }
            if (işlem == 11)
            {
                if (CollisionDetection.KureSilindir(kure, silindir))
                    Console.WriteLine("küre ve silindir çarpışıyor");
                else
                    Console.WriteLine(" küre ve silindir çarpışmıyor");
            }
            if (işlem == 12)
            {
                if (CollisionDetection.KureYüzey(kure, yuzey))
                    Console.WriteLine("küre ve yüzey çarpışıyor");
                else
                    Console.WriteLine(" küre ve yüzey çarpışmıyor");
            }
            if (işlem == 2)
            {
                if (CollisionDetection.NoktaCember(nokta, cember))
                    Console.WriteLine(" çemberle nokta çarpışıyor");
                else
                    Console.WriteLine(" çemberle nokta çarpışmıyor");
            }
            if (işlem == 7)
            {
                if (CollisionDetection.NoktaDikdortgenPrizması(nokta3d, Prizma))
                    Console.WriteLine(" prizma ve nokta çarpışıyor");
                else
                    Console.WriteLine(" prizma ve nokta çarpışmıyor");
            }
            if (işlem == 1)
            {
                if (CollisionDetection.NoktaDikdörtgen(nokta, dikdortgen))
                    Console.WriteLine(" dikdörtgenle nokta çarpışıyor");
                else
                    Console.WriteLine(" dikdörtgenle nokta çarpışmıyor");
            }
            if (işlem == 6)
            {
                if (CollisionDetection.NoktaKure(nokta3d, kure))
                    Console.WriteLine(" küreyle nokta çarpışıyor");
                else
                    Console.WriteLine(" küreyle nokta çarpışmıyor");
            }
            if (işlem == 8)
            {
                if (CollisionDetection.NoktaSilindir(nokta3d, silindir))
                    Console.WriteLine(" silindirle nokta çarpışıyor");
                else
                    Console.WriteLine(" silindirle nokta çarpışmıyor");
            }

            if (işlem == 9)
            {
                if (CollisionDetection.SilindirSilindir(silindir1, silindir2))
                    Console.WriteLine(" silindirler çarpışıyor");
                else
                    Console.WriteLine(" siliindirler çarpışmıyor");
            }
            if (işlem == 14)
            {
                if (CollisionDetection.SilindirYüzey(silindir, yuzey))
                    Console.WriteLine(" silindirle yüzey çarpışıyor");
                else
                    Console.WriteLine(" siliindirle yüzey çarpışmıyor");
            }
            else
                Console.WriteLine("yanlış girdiniz");
        }
    }
}