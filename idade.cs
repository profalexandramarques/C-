// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class CalculoIdade
{
    public static void Main(string[] args)
    {
        int ano = 2025;
        Console.WriteLine("Digite seu ano de nascimento:");
        int anonasc = Convert.ToInt32(Console.ReadLine());
        int idade = ano - anonasc;
        Console.WriteLine ("Sua idade no ano atual eh "+idade);
    }
}