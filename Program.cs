double a, b, dividendo, divisor, resto;

Console.Clear();

Console.WriteLine("--- Máximo divisor comum ---\n");

// Usa-se a = dividendo para armazenar os valores iniciais para depois
Console.Write("Digite o primeiro número (a): ");
a = dividendo = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo número (b): ");
b = divisor = Convert.ToDouble(Console.ReadLine());
 
// Aplicando o Algoritmo de Euclides
do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
} 
while (resto != 0);

// Exibe resultado em verde
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nMDC({a}, {b}) = {dividendo}");
Console.ResetColor();

// Pausa para o usuário ver o resultado
Console.Write("\nPressione uma tecla para finalizar... ");
Console.ReadKey(); 
Console.Clear(); // Só acontece após o usuario pressionar uma tecla