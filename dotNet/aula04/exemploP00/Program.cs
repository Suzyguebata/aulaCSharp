using System;

namespace exemploP00
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-------- Escolha uma das opções abaixo: ");
            Console.WriteLine("- 1: Área de um Círculo");
            Console.WriteLine("- 2: Área de um Quadrado");
            Console.WriteLine("- 3: Área de um Retângulo");
            int.TryParse(Console.ReadLine(), out int opcao);

            switch (opcao)
            {
                case 1:
                    Console.Write(" - Digite o raio do círculo: ");
                    int.TryParse(Console.ReadLine(), out int raio);
                    Circulo meuCirculo = new Circulo();
                    Console.WriteLine("***Área do circulo: " + meuCirculo.calcularArea(raio));
                    break;
                case 2:
                    Console.Write(" - Digite a medida dos lados Quadrado: ");
                    int.TryParse(Console.ReadLine(), out int lado);
                    Quadrado areaQuadrado = new Quadrado();
                    Console.WriteLine("*** Área do Quadrado: " + areaQuadrado.calcularArea(lado));
                    break;
                case 3:
                    Console.Write(" - Digite a base do Retângulo: ");
                    int.TryParse(Console.ReadLine(), out int baseRetangulo);
                    Console.Write(" - Digite a altura do Retângulo: ");
                    int.TryParse(Console.ReadLine(), out int alturaRetangulo);
                    Retangulo areaRetangulo = new Retangulo();
                    Console.WriteLine("*** Área do Retângulo: " + areaRetangulo.calcularArea(baseRetangulo,alturaRetangulo));
                    break;
                default:
                    Console.WriteLine(" - Opção Inválida");
                    break;

            }

            
            /*
            Circulo meuCirculo = new Circulo();
            Console.WriteLine("Área do circulo: " + meuCirculo.calcularArea(5));

            Quadrado areaQuadrado = new Quadrado();
            Console.WriteLine("Área do quadrado: " + areaQuadrado.calcularArea(10));

            Retangulo areaRetangulo = new Retangulo();
            Console.WriteLine("Área do retângulo: " + areaRetangulo.calcularArea(8)); */
        }
    }
}