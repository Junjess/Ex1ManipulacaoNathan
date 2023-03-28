Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

int nPalavras = 1;

for (int i = 0; i <= frase.Length-1; i++)
{
    if (frase[i] == ' ')
    {
        nPalavras++;
    }
}

Console.WriteLine("Numero de palavras na frase: " + nPalavras);
