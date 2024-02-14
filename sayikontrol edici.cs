using System;

namespace SayiKontrolEdici
{
    class SayiKarsilastirici
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Bir değer giriniz: ");
                var x = Convert.ToInt32(Console.ReadLine());
            
                if (x > 5)
                {
                    Console.WriteLine("Girdiğiniz değer 5'ten büyük.");
                }
            
                else if (x < 5)
                {
                    Console.WriteLine("Girdiğiniz değer 5'ten küçük. ");
                }
            
                else
                {
                    Console.WriteLine("Girdiğiniz değer 5'e eşit.");
                }
            }
            
        }      
    }
}    
