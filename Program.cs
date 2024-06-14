using Hera.model;
using System;

class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Quer acessar a conta Corporativa ou a Poupança?");
        Console.WriteLine("1 - Conta Corporativa");
        Console.WriteLine("2 - Conta poupança");
        int escolha = Convert.ToInt32(Console.ReadLine());
        if(escolha == 1)
        {
            BusinessPerson businessPerson = new BusinessPerson();
            Console.WriteLine("Você escolheu a Conta Corporativa");
            businessPerson.Balance();
        }
        else if(escolha == 2)
        {
            AccountPerson accountPerson  = new AccountPerson();
            Console.WriteLine("Você escolheu a Conta poupança");
            accountPerson.Balance();
        }
    }
}