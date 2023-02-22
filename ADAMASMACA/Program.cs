using System;

class Program
{
    static void Main(string[] args)
    {
        // Kelimeleri bir dizi içinde tanımlayın
        string[] kelimeler = { "elma", "armut", "muz", "portakal", "çilek", "üzüm" };

        // Rastgele bir kelime seçin
        Random random = new Random();
        int index = random.Next(kelimeler.Length);
        string kelime = kelimeler[index];

        // Kelimenin uzunluğunu hesaplayın ve bir tahmin dizisi oluşturun
        int uzunluk = kelime.Length;
        char[] tahmin = new char[uzunluk];
        for (int i = 0; i < uzunluk; i++)
        {
            tahmin[i] = '_';
        }

        // Kullanıcının tahmin hakkını belirleyin ve bir tahmin dizisi oluşturun
        int tahminHakki = 15;
        char[] kullaniciTahmin = new char[uzunluk];

        // Oyun döngüsünü başlatın
        while (tahminHakki > 0)
        {
            // Tahmin dizisini ekrana yazdırın
            Console.WriteLine(tahmin);

            // Kullanıcıdan bir karakter girdisini alın
            Console.Write("Bir harf tahmin edin: ");
            char harf = char.Parse(Console.ReadLine());

            // Eğer kullanıcının tahmini doğruysa, tahmin dizisini güncelleyin
            bool dogruTahmin = false;
            for (int i = 0; i < uzunluk; i++)
            {
                if (kelime[i] == harf)
                {
                    tahmin[i] = harf;
                    dogruTahmin = true;
                }
            }

            // Eğer kullanıcının tahmini yanlışsa, tahmin hakkını azaltın
            if (!dogruTahmin)
            {
                tahminHakki--;
            }

            // Kullanıcının tüm karakterleri doğru tahmin ettiğini kontrol edin
            bool tamamlandi = true;
            for (int i = 0; i < uzunluk; i++)
            {
                if (tahmin[i] == '_')
                {
                    tamamlandi = false;
                    break;
                }
            }

            // Eğer kullanıcı tüm karakterleri doğru tahmin ettiyse, oyunu kazandı
            if (tamamlandi)
            {
                Console.WriteLine("Tebrikler, kelimeyi doğru tahmin ettiniz: " + kelime);
                break;
            }

            // Eğer kullanıcının tahmin hakkı kalmadıysa, oyunu kaybetti
            if (tahminHakki == 0)
            {
                Console.WriteLine("Tahmin hakkınız kalmadı, kelime: " + kelime);
                break;
            }
        }
    }
}
