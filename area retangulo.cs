using System;

class Program {
    static void Main(string[] args) {
    double area;
    double basee;
    double altura;
    Console.WriteLine("Digite o valor da base: ");
    basee = double.Parse(Console.ReadLine()); 
    Console.WriteLine("Digite o valor da altura: ");
    altura = double.Parse(Console.ReadLine());
    area=basee*altura;
    Console.WriteLine("A área do retângulo é: "+area);
    }
}
