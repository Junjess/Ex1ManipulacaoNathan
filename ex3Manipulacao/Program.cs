Console.Write("Digite uma palavra para ver a cifra de césar: ");
string palavra = Console.ReadLine();

palavra = palavra.ToUpper();

string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string novaPalvra = "";

for (int i = 0; i < palavra.Length; i++)
{
    for (int j = 0; j < alfabeto.Length; j++) 
    {
        if (palavra[i] == alfabeto[j])
        {
            novaPalvra += alfabeto[j+2];
            break;
        }
    }
}

Console.WriteLine(novaPalvra);

