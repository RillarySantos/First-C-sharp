using System;

class Program {
    static void Main(string[] args) {
    double c;
    double f;
    Console.WriteLine("Digite a temperatura em fahrenheit: ");
    f = double.Parse(Console.ReadLine()); 
    c=(f-32)/1.8;
    Console.WriteLine("A temperatura em celsius é: "+c);
    }
}

