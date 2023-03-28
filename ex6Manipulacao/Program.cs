Dictionary<char, List<string>> cidadesPorLetra = new Dictionary<char, List<string>>();
Dictionary<string, List<string>> cidadesPorEstado = new Dictionary<string, List<string>>();

using (var reader = new StreamReader("C:\\Users\\rafae\\OneDrive\\Área de Trabalho\\cidades.csv"))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(',');

        // valores[0] = posição
        string codigoIBGE = values[1];
        string cidade = values[2];
        string uf = values[3];
        int populacao = int.Parse(values[4]);

        // Agrupa por letra inicial
        char primeiraLetra = cidade[0];
        if (!cidadesPorLetra.ContainsKey(primeiraLetra))
        {
            cidadesPorLetra[primeiraLetra] = new List<string>();
        }
        cidadesPorLetra[primeiraLetra].Add(cidade);

        // Agrupa por estado
        if (!cidadesPorEstado.ContainsKey(uf))
        {
            cidadesPorEstado[uf] = new List<string>();
        }
        cidadesPorEstado[uf].Add(cidade);
    }
}

Console.WriteLine("Cidades agrupadas por letra inicial:");
foreach (var item in cidadesPorLetra)
{
    Console.WriteLine(item.Key + ": " + string.Join(", ", item.Value));
}

Console.WriteLine("\nCidades agrupadas por estado:");
foreach (var item in cidadesPorEstado)
{
    Console.WriteLine(item.Key + ": " + string.Join(", ", item.Value));
}