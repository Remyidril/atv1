//NOMES:Heitor Krawczuk Mota, Enzo Santos, Gustavo oliveira dias santana

double num;
string operaçao;
Console.WriteLine("escreva '101' se quiser a raiz quadrada, '102' para a metade, '103' para 10% do numero e '104' para o dobro");
operaçao = Convert.ToString(Console.ReadLine());
Console.WriteLine("Escreva seu numero");
num = Convert.ToInt32(Console.ReadLine());  


switch (operaçao)
{
    case "101":
        Console.WriteLine("a raiz quadrada" + num + " é igual " + Math.Sqrt(num));
        break;
    case "102":
        Console.WriteLine("a metade" + num + "é" + num / 2);
        break;
    case "103":
        Console.WriteLine("10% dele" + num + "é" + 10* num / 100);
        break;
    case "104":
        Console.WriteLine("o dobro" + num + "é" + num * 2);    
        break;
    default:
        Console.WriteLine("operação invalida");
        break;


}
