//NOME: Heitor Krawczuk Mota,Enzo Santos, Gustavo Oliveira Dias Santana
string cargo;
double salario;
Console.WriteLine("escreva o cargo (supervisor, tecnico ou outro): ");
cargo = Console.ReadLine();
Console.WriteLine("salario  da pessoa: ");
salario=Convert.ToDouble(Console.ReadLine());
switch (cargo)
{
case "supervisor":
     Console.WriteLine("cargo: " + cargo + ". salario reajustado: " + (salario + salario * 0.30));
     break;
case "tecnico":
     Console.WriteLine("cargo: " + cargo + ". salario reajustado: " + (salario + salario * 0.20));
     break;
case "outro":
     Console.WriteLine("cargo: " + cargo + ". salario reajustado: " + (salario + salario * 0.10));
     break;
default:
      Console.WriteLine("esse cargo nao existe nessa empressa");
      break;
}