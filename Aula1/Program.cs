//Trabalhando com variaveis em C# 


//strings
//Declarando variavel sem inicialização
string message1 =  null;
//Inicializando a variavel com nulo
string message2 = null;
//Inicializando uma string vazia
//string message3 = "";
// A forma certa de se inicializar uma string vazia é 
string message3 = System.String.Empty;
//Declarar uma string com valor implicito
var message4 = "Uma mensagem";

Console.WriteLine(message4);


//Concatenando Strings
string concat = (message1 == null ? " " : message1) + " " + message2 + " " + message3 + " " + message4;

Console.WriteLine("\n" + concat);

Console.WriteLine("A temperatura de Hoje {0:D} é {1}Cº", DateTime.Now, 23);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);