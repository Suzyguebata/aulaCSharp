using System;

namespace exemploConversaoMoeda
{
    class conversaoEuroReal
    {  private double euro = 6.20;

        public double converter(double quantidade)
        {
            return quantidade * euro;
        }

        public void MudarValorEuro(double novoValor)
        {
            if(novoValor > 0)
            {
                euro = novoValor;
            }
        }
    }
}