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

//Tipos Numéricos
 /* 
    sbyte: Armazena valores entre -128 e 127.
    short: Armazena valores entre -32,768 e 32,767.
    int: Armazena valores entre -2,147,483,648 e 2,147,483,647.
    long: Armazena valores entre -9,223,372,036,854,775,808 e -9,223,372,036,854,775,807
 */
 float myFloat = 10f;
 double myDouble = 5d;
 decimal myDecimal = 7m;
 int myInteger = 0;


 