using System;

class Program {
    static void Main(string[] args) {
		double raio;
		double area;
		const double pi = 3.14;
		Console.WriteLine("Digite o valor do raio: ");
		raio = double.Parse(Console.ReadLine()); 
		area=pi*raio*raio;
		Console.WriteLine("A area da circunferência é: "+area);
	
    }
}
