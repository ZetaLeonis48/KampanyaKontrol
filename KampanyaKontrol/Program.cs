namespace KampanyaKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
        uyelikekrani:
            Console.WriteLine("Kampanya sorgulama ekranına hoşgeldiniz.");
            Console.WriteLine("Üyeliğiniz varsa evet yoksa hayır yazınız.");
            string uyelik = Console.ReadLine().ToLower();
            if (uyelik != "evet" && uyelik != "hayır")
            {
                Console.WriteLine("Geçersiz bir tanımlama yaptınız.");
                goto uyelikekrani;
            }
            Console.Clear();
        tutarEkrani:
            Console.WriteLine("Alışveriş tutarınızı giriniz.");
            int tutar = Convert.ToInt32(Console.ReadLine());
            if (tutar < 0)
            {
                Console.WriteLine("Girdiğiniz değer 0 dan küçük olamaz.");
                goto tutarEkrani;
            }
            Console.Clear();
        ilkEkrani:
            Console.WriteLine("İlk defa alışveriş yapıyorsanız evet ilk değilse hayır yazınız.");
            string ilkdefa = Console.ReadLine().ToLower();
            if (ilkdefa != "evet" && ilkdefa != "hayır")
            {
                Console.WriteLine("Geçersiz bir tanımlama yaptınız.");
                goto ilkEkrani;
            }
            Console.Clear();


            var indirim1 = 15;
            var indirim2 = 100;
            var tutar1 = tutar;

            if ((uyelik=="evet" && tutar>1000) || ilkdefa == "evet")
            {
                tutar1 *= indirim1;
                tutar1 /= indirim2;
                tutar -= tutar1;
                Console.WriteLine($"Kampanya kazandınız %15 indirim uygulandı. Ödemeniz gereken tutar {tutar} TL'dir.");
            }
            else
            {
                Console.WriteLine($"Kampanyadan yararlanamıyorsunzu. Ödemeniz gereken tutar {tutar} TL'dir.");
            }


        }
    }
}
