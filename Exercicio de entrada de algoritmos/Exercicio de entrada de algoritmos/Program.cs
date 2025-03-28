using System.Globalization;
using System.Xml;
//Texto
Console.Write("Informe seu nome completo: ");
string? nomeCompleto = Console.ReadLine();

//Número inteiro
Console.WriteLine();
Console.Write("Quantos quartos tem na sua casa? ");
 int quartos =int.Parse(Console.ReadLine());

//Numero com vírgula
Console.WriteLine();
Console.Write("Informe o preço da sua internet: ");
double precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//Linha de texto de variaveis diferentes
Console.WriteLine();
Console.Write("Informe seu ultimo nome, idade e altura: ");
string linha = Console.ReadLine();
//Vetor de texto, divide sempre que encontra o que está entre ''
string[] vetor = linha.Split(' ');
string sobrenome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);

Console.WriteLine();
Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString("F2"));//F2 define 2 casas decimais
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));


