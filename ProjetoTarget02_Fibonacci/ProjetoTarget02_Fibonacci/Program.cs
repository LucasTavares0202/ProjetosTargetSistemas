Console.Write("informe seu número: ");
int numero = int.Parse(Console.ReadLine());
bool pertence = false;

int n1 = 0, n2 = 1, temp=0;

if (numero == n1|| numero == n2)
{
    pertence = true;
}
else
{
    while (n2 <= numero && pertence == false)
    {
        temp = n1 + n2;
        n1 = n2;
        n2 = temp;

        if(numero == n2)
        {
            pertence = true;
        }
    }
}
if (pertence == true)
{
    Console.WriteLine($"{numero} pertence a sequência de fibonacci.");
}
else
{
    Console.WriteLine($"{numero} não pertence a sequência de fibonacci.");
}