
using System.Collections.Generic;

Dictionary < string, List = "" < double >

    > notasAlunos = new Dictionary<string, List= "" < double >

        > {
    {
        "Bárbara Elen", new List<double>
            { 10, 15, 12, 8, 5 } }, {
        "Alice Ellen", new List<double>
                { 10, 15, 5, 25 } }, {
        "Sarah Bianca", new List<double>
                    { 20, 18, 22, 24, 16 } }, {
        "Alex Junio", new List<double>
                        { 4, 5, 6, 5, 4 } }, };
foreach (var aluno in notasAlunos)
{
    double soma = 0;
    for (int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"Média de {aluno.Key}: {media}");
}