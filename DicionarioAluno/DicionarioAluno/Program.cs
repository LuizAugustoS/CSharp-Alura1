Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>> { { "Luiz", new List<double> { 10, 9.5, 10 } }, 
    {  "Paulo", new List<double> { 10, 9.5, 10 } }, { "João", new List<double> { 10, 9.5, 10 } } };

    foreach (var key in notasAlunos.Keys)
        Console.WriteLine($"{key} - {Math.Round(notasAlunos[key].Sum(x=>x) / notasAlunos[key].Count,2)}");
