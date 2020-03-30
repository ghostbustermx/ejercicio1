using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;

            for (i = 0; i <= 100; i++)
                if (i % 3 == 0 && i % 5 == 0 ){
                    Console.WriteLine("TC");
                }else if (i % 5 == 0 ){
                    Console.WriteLine("C");
                }else if ( i % 3 == 0 ){
                    Console.WriteLine("T");
                }else{
                    Console.Write("{0}|", i);
                }
                

                Console.ReadLine();
            
            
        }
    }
}
