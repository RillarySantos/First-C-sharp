using System;

class Program {
    static void Main(string[] args) {
		double a;
		double b;
		double c;
		Console.WriteLine("Digite o primeiro valor: ");
		a = double.Parse(Console.ReadLine()); 
		Console.WriteLine("Digite o segundo valor: ");
		b = double.Parse(Console.ReadLine());
		c=a;
		a=b;
		b=c;
		Console.WriteLine("Primeiro valor="+a+" Segundo valor="+b);		  
    }
}
