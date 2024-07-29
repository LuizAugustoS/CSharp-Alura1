namespace Calculadora
{
    internal class Dividir
    {
        public static double Divisao(double valorA, double valorB)
        {
            if (valorB != 0)
            {
                return valorA / valorB;
            }
            else
            {
            Console.WriteLine("Valor inválido.");
                return 0;
            }

        }
    }
}
