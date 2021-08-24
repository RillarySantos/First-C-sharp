using System;

class Program {
    static void Main(string[] args) {
    double prestacao;
    double valor;
    double taxa;
    double tempo;
    Console.WriteLine("Digite o valor da prestação: ");
    valor = double.Parse(Console.ReadLine()); 
    Console.WriteLine("Digite a taxa de juros: ");
    taxa = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a qtd. de dias de atraso: ");
    tempo = double.Parse(Console.ReadLine());
    prestacao=valor+(valor*(taxa/100)*tempo);
    Console.WriteLine("O valor da prestação é= "+prestacao);
    }
}
