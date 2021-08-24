using System;

class Program {
    static void Main(string[] args) {
		double nmraula;
		double valoraula;
		double inss;
		double resultado;
		Console.WriteLine("Digite o numero de aulas: ");
		nmraula = double.Parse(Console.ReadLine()); 
		Console.WriteLine("Digite o valor da aula: ");
		valoraula = double.Parse(Console.ReadLine()); 
		Console.WriteLine("Digite o percentual de desconto do inss : ");
		inss = double.Parse(Console.ReadLine()); 
		resultado=(nmraula*valoraula)*(1-inss/100);
		Console.WriteLine("O salário é: "+resultado);

    
    }
}
