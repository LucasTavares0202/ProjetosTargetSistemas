float[] faturamento = { 67836.43f, 36678.66f, 29229.88f, 27165.48f, 19849.53f};
float total = 0;
float percentual = 0;
for (int i = 0; i < faturamento.Length; i++)
{
    total += faturamento[i];
}
string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
for (int i = 0; i < estados.Length; i++)
{
    percentual = (faturamento[i] / total) * 100;
    Console.WriteLine($"Percentual de {estados[i]} = {percentual:f2}%");
}

