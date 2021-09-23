using System;

namespace exemploP00
{
    class Circulo
    {
        //fórmula para calcular área de um circulo é PI * raio * raio
        //Match.Pow(raio,2) --> Faz a potência de raio ao quadrado.
        //Match.PI = 3.1416...

        private double pi = 3.1416;

        public double calcularArea( int raio)
        {
            return pi * raio * raio;
        }
    }
}