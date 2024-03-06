namespace ilkOdevSuhedaYayla;

class Program
{
    static void Main(string[] args)
    {
    /////////////BİRİNCİ SORU
      Console.WriteLine("Lütfen sipariş numaranızı giriniz: ");
       int siparisNo= Convert.ToInt32(Console.ReadLine());

       switch(siparisNo){
            case 1:
                    Console.WriteLine("Sipariş edilen ürününüz: Laptop");
                    break;
            case 2:
                    Console.WriteLine("Sipariş edilen ürününüz: Telefon");
                    break;

            case 3:
                    Console.WriteLine("Sipariş edilen ürününüz: Klima");
                    break;
            case 4:
                    Console.WriteLine("Sipariş edilen ürününüz: Klavye");
                    break;

            case 5:
                    Console.WriteLine("Sipariş edilen ürününüz: Masaüstü Bilgisayar");
                    break;
            case 6:
                    Console.WriteLine("Sipariş edilen ürününüz: Bilgisayar ekranı");
                    break;
            default:
                Console.WriteLine("Geçersiz sipariş numarası girdiniz. Lütfen tekrar giriniz.");
                break;

        //----------------------------//    
    /////////////İKİNCİ SORU

        Console.WriteLine("Lütfen almak istediğiniz ürün miktarını giriniz: ");
        int urunMiktari=Convert.ToInt32(Console.ReadLine());
        double toplamTutar=0;
        for (int i =1; i<=urunMiktari; i++)
        {
            Console.WriteLine(i + ". "+ "Ürünün fiyatını giriniz: ");
            double urunFiyati=Convert.ToDouble(Console.ReadLine());
            toplamTutar+=urunFiyati;
        }
            Console.WriteLine("Toplam alışveriş tutarı: " + toplamTutar);

        //----------------------------//


     /////////////ÜÇÜNCÜ SORU
           // DO WHILE döngüsünde koşul sonda olur ve bu yüzden program o döngüye
            //mutlaka girmiş olur.aşağıdaki örnekte 1000den küçük sayı girdiğimizde
            //döngü sürekli tekrarlar, binden büyük sayı girdiğimizde çıkış yapar.
            int girilenSayi;
            do{
                Console.WriteLine("1000den büyük bir sayı giriniz: ");
                girilenSayi = int.Parse(Console.ReadLine());


            }while(girilenSayi<1000);

        //----------------------------//


     /////////////DÖRDÜNCÜ SORU

        Random rnd = new Random();
        int randomSayi=rnd.Next(1,10);
        while (true){    
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int tahmin=Convert.ToInt32(Console.ReadLine());
            if(randomSayi==tahmin){
                break;
            }
        }
             Console.WriteLine(" Doğru tahmin ");


        //----------------------------//


     /////////////BEŞİNCİ SORU
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int toplam=0;

            for (int i=1; i < sayi ; i++ ){
                if(sayi%i==0){
                    toplam+=i;
                }
              }
                if (toplam==sayi){
                    Console.WriteLine(sayi + " sayısı mükemmel sayıdır.");

                }else{
                   Console.WriteLine(sayi + " sayısı mükemmel sayı değildir.");

                } 
                }

                 
        //----------------------------//


     /////////////ALTINCI SORU
            //String ifadelerde değişik işlemler yapabilmek için hazır metodlar oluşuturulmuştur.
            //bunlardan bazıları; 
            //contains: stringin içerisinde aranan harf yada kelimenin olup olmadığını kontrol eder.
            //endswith: stringin sonunda aranan harf ya da kelimenin olup olmadığını kontrol eder.
            //startswith: stringin başında aranan harf ya da kelimenin olup olmadığını kontrol eder.
            //remove: stringin verilen index numarasından itibaren silme işlemini yapar
            //tolower: bütün harfleri küçü yapar.
            //toUpper: bütün harfleri büyütür.
            //trim: stringin başındaki ve sonundaki boşlukları siler.

         //----------------------------//

         
     ///////////YEDINCI SORU
     
            Console.WriteLine("Lütfen öğrenci sayısını giriniz: ");
            int ogrenciSayisi=Convert.ToInt32(Console.ReadLine());
            double ortalamaNot=0;
            for (int i =1; i<=ogrenciSayisi; i++)
            {
                Console.WriteLine("Öğrencinin adını ve soyadını giriniz: ");
                string ogrenciAdi=Console.ReadLine();
                Console.WriteLine("Öğrencinin 1. sınav notunu giriniz: ");
                int birinciSinav=Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Öğrencinin 2. sınav notunu giriniz: ");
                int ikinciSinav=Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Öğrencinin 3. sınav notunu giriniz: ");
                int ucuncuSinav=Convert.ToInt32(Console.ReadLine());
                
                ortalamaNot=(birinciSinav+ikinciSinav+ucuncuSinav)/3;
                Console.WriteLine(ogrenciAdi + " isimli öğrencinin ortalaması: " + ortalamaNot);


            }


        }

    

}

