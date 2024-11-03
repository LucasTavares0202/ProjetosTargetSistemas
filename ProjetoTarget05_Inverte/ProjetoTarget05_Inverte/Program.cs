Console.Write("String normal: ");
string entrada = Console.ReadLine();
string inverso = "";

for (int i = entrada.Length - 1; i >= 0; i--)
{
    inverso += entrada[i];
}
Console.WriteLine($"String invertida: {inverso}");