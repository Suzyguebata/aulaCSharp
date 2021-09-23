using System;

namespace exemploConversaoMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            conversaoEuroReal obj = new conversaoEuroReal();
            Console.WriteLine(obj.converter(100));

            
            obj.MudarValorEuro(6.10);
            Console.WriteLine(obj.converter(100));

            obj.MudarValorEuro(-5);
            Console.WriteLine(obj.converter(100));

            
            /*
            obj.euro = 6.10;
            
            //obj.euro = -5;
            
            */
        }
    }
}
