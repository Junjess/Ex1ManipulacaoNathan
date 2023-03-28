Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine();
string[] fraseV = frase.Split(' ');

string fraseFinal = "";

for (int i = 0; i < fraseV.Length; i++)
{
    string palavra = fraseV[i];
    if(palavra.Length > 0)
    {
        string primeiraLetra = palavra.Substring(0,1).ToUpper();
        string resto = palavra.Substring(1);
        fraseFinal += primeiraLetra + resto + " ";
    }
}

Console.WriteLine("\n" + fraseFinal);
