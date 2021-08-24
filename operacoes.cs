using System;

class Program {
    static void Main(string[] args) {
		double a;
		double b;
		double res;
		Console.WriteLine("Digite o primeiro valor: ");
		a = double.Parse(Console.ReadLine()); 
		Console.WriteLine("Digite o segundo valor: ");
		b = double.Parse(Console.ReadLine());
		res=a+b;
		Console.WriteLine("Soma= "+res);
		res=a-b;
		Console.WriteLine("Subtração= "+res);
		res=a*b;
		Console.WriteLine("Multiplicação= "+res);
		res=a/b;
		Console.WriteLine("Divisão= "+res);
    }
}
