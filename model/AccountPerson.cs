using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hera.model
{
    public class AccountPerson : Person
    {
             public AccountPerson()
            {
           
            }
           
            public override void Balance()
            {
                Saldo = (Deposity - WithDraw) * 1.02;
                Console.WriteLine($"Seu saldo:{Saldo}");
                Console.WriteLine($"Seu Nome:{Name}");
                Console.WriteLine($"Seu Depósito:{Deposity}");
                Console.WriteLine($"Seu Nome da conta:{Account}");
                Console.WriteLine($"Seu CPF:{Cpf}");
                Console.WriteLine($"Nome da Agencia:{Agence}");
            }

    }
}