Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine("Frase minuscula: " + frase.ToLower());
Console.WriteLine("Frase maiuscula: " + frase.ToUpper());
Console.WriteLine("Numero de caracteres: " + frase.Length);
Console.WriteLine("Primeira palavra: " + frase[0]);
Console.WriteLine("Ultimo palavra: " + frase[frase.Length-1]);


