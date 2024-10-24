namespace Siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıcının girdiği sayıları diziye at ve diziyi büyükten küçüğe doğru sırala.

            


            Console.WriteLine("****SIRALAMA YAPILACAK SAYILARI GİRİN****");
            Console.WriteLine("Kaç Haneli Dizi OLuşturacaksın ?");
              int  hane = Convert.ToInt32(Console.ReadLine());
            int sayilar;
            int sayac = 1;
            List<int> list = new List<int>();
            int enbuyuk = int.MaxValue;
            int deger;
         
            for (int i = 1; i <=hane; i++)
            {
                Console.Write($"{i}.Sayıyı gir:");
                sayilar = Convert.ToInt32(Console.ReadLine());
                list.Add(sayilar);
                sayac++;
            }

            Console.WriteLine("OLUŞTURDUĞUN DİZİ");
            foreach (var sayi in list)
            {

                Console.Write(sayi);

            }


            // 5,9,7,8

            for (int i = 0; i < list.Count; i++)
            {
              

                    for (int j = 0; j < i; j++)
                    {

                        if (list[i] > list[j])
                        {

                            deger = list[i]; // deger=5 , list[i]=5 list[i+1]=9

                            list[i] = list[j]; // list[i] =9 ,deger=5 , list[i+1]=5
                            list[j] = deger;

                        }



                    }
                    
                }
                
            Console.WriteLine("SIRALANAN  DİZİ");
            foreach (var sayi in list)
            {

                Console.Write(sayi);

            }


        }
    }
}
