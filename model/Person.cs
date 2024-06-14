using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hera.model
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
            Deposity = 900;
            WithDraw = 250;
            Name = "Francisco";
            Cpf = "500.299.999-79";
            Agence = "NGChash";
            Account = "Conta do Francisco";
        }
       public Guid Id {get; set;}
       public string Name {get; set;}
       public string Cpf {get; set;}
       public string Agence {get; set;}
       public string Account {get; set;}
       public double WithDraw {get; set;}
       public double Deposity {get; set;}
       public double Saldo {get; set;}
       public virtual void Balance()
       {
        Saldo = Deposity - WithDraw;
       }
    }
}