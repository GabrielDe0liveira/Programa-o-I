//Substituindo conteúdo de strings

string nomeCompleto = "Gabriel de Olivera";
nomeCompleto = 
    nomeCompleto.Replace("de", "Dell");
Console.WriteLine(nomeCompleto);

//Comparação de Strings
bool isNomeEqual =
    (nomeCompleto == "Gabriel de Oliveira");
bool isNomeEqual2 =
    string.Equals(nomeCompleto, "Gabriel dell Oliveira");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

