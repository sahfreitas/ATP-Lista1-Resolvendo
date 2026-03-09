//Entrada -> Processamento -> Saída
//Converter variaveis 
//Comando "WhiteLine" se entende como String e por isso o "int.Parse" transformando em Inteiro
// Exercício - 1
/*
double nota1, nota2, media;

Console.Write("Digite a primeira nota:");
nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota:");
nota2 = double.Parse(Console.ReadLine());

media = (nota1 * 2 + nota2 *3) / (2 + 3);

Console.WriteLine("A média ponderada de suas notas é:" + media);
*/
/*
int preco;
double novopreco;

Console.Write("Digite o preço do produto: ");
preco = int.Parse(Console.ReadLine());

novopreco = preco * 0.9;

Console.WriteLine("O novo preço do produto é:{0} ", novopreco);*/

/*
double salario, novosalario, aumento;

Console.Write("Digite o salario atual: ");
salario = double.Parse(Console.ReadLine());

aumento = salario * 0.15;

novosalario = salario + aumento;

Console.WriteLine("O novo salário é: {0} ", novosalario);
*/
double km, litro, consumo;

Console.Write("Digite os kms percorridos: ");
km = double.Parse(Console.ReadLine());
Console.Write("Digite os litros gastos: ");
litro = double.Parse(Console.ReadLine());

consumo = km / litro;

Console.WriteLine("Você percorreu {0}km por litro", consumo);

Console.ReadKey();

