using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para digitar a base
        Console.Write("Digite o comprimento da base do retângulo: ");
        double baseRetangulo = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário para digitar a altura
        Console.Write("Digite a altura do retângulo: ");
        double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

        // Calcula a área do retângulo
        double area = baseRetangulo * alturaRetangulo;

        // Calcula o perímetro do retângulo
        double perimetro = 2 * (baseRetangulo + alturaRetangulo);

        // Imprime a área e o perímetro calculados
        Console.WriteLine("Área do retângulo: " + area);
        Console.WriteLine("Perímetro do retângulo: " + perimetro);

        // Pausa para ver a saída
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();  // Espera que o usuário pressione uma tecla
    }
}
