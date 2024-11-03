using Newtonsoft.Json;


class Program
{
    public class Faturamento
    {
        public string dia { get; set; }
        public decimal valor { get; set; }
    }
    public class DadosFaturamento
    {
        public Faturamento[] Faturamentos { get; set; }
    }
    static void Main(string[] args)
    {
        string json = File.ReadAllText("faturas.json");
        DadosFaturamento dados = JsonConvert.DeserializeObject<DadosFaturamento>(json);

        List<decimal> valores = new List<decimal>();
        foreach (var faturamento in dados.Faturamentos)
        {
            if (faturamento.valor > 0)
            {
                valores.Add(faturamento.valor);
            }
        }

        decimal menorvalor = valores.Min();
        decimal maiorvalor = valores.Max();
        decimal mediavalor = valores.Average();

        int DiasAcimaMedia = valores.Count(v => v > mediavalor);


        Console.WriteLine($"O menor faturamento registrado foi de: {menorvalor}");
        Console.WriteLine($"O maior faturament registrado foi de: {maiorvalor}");
        Console.WriteLine($"O número de dias com faturamento acima da média foi de: {DiasAcimaMedia}");
    }
}
