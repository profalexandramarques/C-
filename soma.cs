// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Soma
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Soma ===");
        Console.WriteLine("Digite um valor:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro valor:");
        double b = Convert.ToDouble(Console.ReadLine());
        double soma = a + b;
        Console.WriteLine ("Soma eh "+soma);
    }
}