namespace mahmut_hoca_odev_yoklama
{
    
class Program
        {
            static void Main()
            {
                
                string a = "temiz";
                string b = "temiz";

                
                Random random = new Random();
                if (random.Next(2) == 0)
                {
                    a = "kirli";
                }
                if (random.Next(2) == 0)
                {
                    b = "kirli";
                }

                
                if (a == "kirli")
                {
                    Console.WriteLine("Zemin A kirli. Temizleme işlemi yapılıyor.");
                   
                }
                else
                {
                    Console.WriteLine("Zemin A temiz. Herhangi bir işlem yapılmıyor.");
                }

                if (b == "kirli")
                {
                    Console.WriteLine("Zemin B kirli. Temizleme işlemi yapılıyor.");
                    
                }
                else
                {
                    Console.WriteLine("Zemin B temiz. Herhangi bir işlem yapılmıyor.");
                }
            }
        }

    }

