using System.Security.AccessControl;

string name, email, dob, genre, CEP, street, number, nbhd, city, UF, country  = string.Empty;


Console.WriteLine("Qual é o seu nome?");
name = Console.ReadLine();
Console.WriteLine("Qual é o seu E-mail?");
email = Console.ReadLine();
Console.WriteLine("Qual é a sua Data de nascimento?");
dob = Console.ReadLine();
Console.WriteLine("Qual é o seu Gênero?");
genre = Console.ReadLine();
Console.WriteLine("Qual é o seu CEP?");
CEP = Console.ReadLine();
Console.WriteLine("Qual é a sua Rua?");
street = Console.ReadLine();
Console.WriteLine("Qual é o numero da sua casa?");
number = Console.ReadLine();
Console.WriteLine("Qual é o nome do seu Bairro?");
nbhd = Console.ReadLine();
Console.WriteLine("Qual é a sua cidade ?");
city = Console.ReadLine();
Console.WriteLine("Qual é a sua Unidade Federal?");
UF = Console.ReadLine();
Console.WriteLine("Qual é o seu País?");
country = Console.ReadLine();

Console.WriteLine("Aqui está sua ficha de cadastro!!");
Console.WriteLine($"Seu nome é: {name} \n Seu email é: {email}");
Console.WriteLine($"Seu email é: {email}");
Console.WriteLine($"Sua data de nascimento é: {dob}");
Console.WriteLine($"Seu gênero é: {genre}");
Console.WriteLine($"Seu CEP é: {CEP}");
Console.WriteLine($"Sua rua é: {street}");
Console.WriteLine($"O numero de sua casa é: {number}");
Console.WriteLine($"Seu bairro é: {nbhd}");
Console.WriteLine($"Sua cidade é: {city}");
Console.WriteLine($"Sua unidade federal é: {UF}");
Console.WriteLine($"Seu país é: {country}");