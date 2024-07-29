using Calculadora;

Console.Write("Insira o primeiro valor: ");
double valorA = double.Parse(Console.ReadLine());

Console.Write("Insira o segundo valor: ");
double valorB = double.Parse(Console.ReadLine());

Console.Write("Insira a operação: ");
char operacao = char.Parse(Console.ReadLine());

double resultado = 0;

switch (operacao)
{
    case '+':
        resultado = Soma.Somar(valorA, valorB); 
        break;

    case '-':
        resultado = Subtrair.Subtracao(valorA, valorB);
        break;

    case '*':
        resultado = Multiplicar.Multiplicacao(valorA, valorB);
        break;
    case '/':
        resultado = Dividir.Divisao(valorA, valorB);
        break;

    case 'r':
        resultado = RaizQuadrada.Raiz(valorA);
        break;

    case '^':
        resultado = Potencia.Potenciacao(valorA, valorB);
        break;



}
Console.WriteLine($"O resultado da operação {operacao} é: {resultado}");
