//Criar um programa que le dois dados e calcula a area de um retangulo
try {
    double lado1, lado2, area;
Console.WriteLine("Não deixe os itens abaixo em branco");
//tratamento de erro acima (ruim mas funcional)
Console.WriteLine("Digite o lado 1 do retangulo");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o lado 2 do retangulo");
lado2 = double.Parse(Console.ReadLine());

area = lado1 + lado2;
Console.WriteLine("A area do retangulo é " + area.ToString());
}
catch (Exception ex )
{
    Console.WriteLine("Erro desconhecido ocorreu " + ex.Message);
}
Console.ReadKey(); 