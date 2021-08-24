using System;

class Program {
    static void Main(string[] args) {
    double valor1;
    double valor2;
    double res;
    Console.WriteLine("Digite o primeiro valor: ");
    valor1 = double.Parse(Console.ReadLine()); 
    Console.WriteLine("Digite o segundo valor: ");
    valor2 = double.Parse(Console.ReadLine()); 
    res=valor1%valor2;
    Console.WriteLine("O resto da divisão de "+valor1+" por "+valor2+" é: "+res);
    }
}

