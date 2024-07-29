using System.ComponentModel.DataAnnotations;
using System.Configuration;

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
string chute= "";
int chuteNumber = 0;

do
{
    Console.Write("Insira o seu número entre 1 e 100:");
        chute = Console.ReadLine();
    chuteNumber = int.Parse(chute);
    if (chute == "")
    {
        Console.WriteLine("Quantidade invalida, por favor digite um número!");
        
    } 
    else if (chute.Count() >3 || chute.Count() < 0)
        {
        Console.WriteLine("Quantidade invalida, digite outro");

    }
    else if  (chuteNumber >100 || chuteNumber <1)
    {
        Console.WriteLine("Numero inválido, digite outro");
        
    }
     
    else if (chuteNumber == numeroSecreto)
    {
        Console.WriteLine("Parabéns!! Você acertou o numero secreto");
        break;
    }
    else if (chuteNumber < numeroSecreto)
    {
        Console.WriteLine("Errou!! Seu numero é MENOR que o numero secreto");
    }
    else if (chuteNumber > numeroSecreto)
    {
        Console.WriteLine("Errou!! Seu numero é MAIOR que o numero secreto");
    }
}
while (true);