using System;

class Program
{
    static void Main()
    {
        // Definição das variáveis
        int a, b, c, d;

        // Solicitação e leitura dos valores do usuário
        Console.Write("Digite o valor para a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor para b: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor para c: ");
        c = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor para d: ");
        d = int.Parse(Console.ReadLine());

        // Cálculo da soma dos quatro números
        int soma = a + b + c + d;

        // Cálculo do produto dos quatro números
        int produto = a * b * c * d;

        // Impressão dos resultados
        Console.WriteLine("A soma dos números é: " + soma);
        Console.WriteLine("O produto dos números é: " + produto);

        // Aguardar a entrada do usuário para fechar o console
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
