using Week5Kapanis;

class Program
{
    static void Main(string[] args)
    {
        List<Araba> yeniAraba = new List<Araba>();

        while (true)
        {
            Console.WriteLine("Bir araba üretmek için 'e' yoksa 'h' tuşuna basınız.");
            string secim = Console.ReadLine().ToLower();
            if (secim == "h")
            {
                Console.WriteLine("İyi günler dileriz.");
                break;
            }
            else if (secim == "e")
            {
                Araba araba = new Araba();
                Console.WriteLine("Lütfen arabanın seri numarasını giriniz.");
                araba.SeriNumarasi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen arabanın markasını giriniz.");
                araba.Marka = Console.ReadLine();
                Console.WriteLine("Lütfen arabanın modelini giriniz.");
                araba.Model = Console.ReadLine();
                Console.WriteLine("Lütfen arabanın rengini giriniz.");
                araba.Renk = Console.ReadLine();
            kapiGirisi: Console.WriteLine("Lütfen arabanın kapı sayısını giriniz.");
                string kapiSayisi = Console.ReadLine();
                try
                {
                    araba.KapiSayisi = int.Parse(kapiSayisi);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz bir format girişi yaptınız.");
                    goto kapiGirisi;
                }
                yeniAraba.Add(araba);
            }
            else
            {
                Console.WriteLine("Geçersiz bir giriş yaptınız.");
            }

            Console.WriteLine("\n*** ÜRETİLEN ARABALAR***");
            foreach (var araba in yeniAraba)
            {
                Console.WriteLine($"Arabanın Seri Numarası : {araba.SeriNumarasi}" +
                                  $"\nArabanın Markası : {araba.Marka}");

            }
        }
    }
}