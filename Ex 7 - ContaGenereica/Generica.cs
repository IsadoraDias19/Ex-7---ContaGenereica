using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7___ContaGenereica
{
    public abstract class Generica
    {
        public string Banco { get; set; }

        public double Agencia { get; set; }

        public string Conta { get; set; }

        public double Saldo{ get; set; }

        public abstract void Depositar();

        public abstract void Sacar();
    }

    public class ContaCorrente1 : Generica 
    { 
        public double limite{ get; set; }
        public override void Depositar()
        {
            Console.WriteLine("\nVocê tem que depositar 1.500");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você tem que sacar 3.500");
        }
    }

    public class ContaCorrente2 : Generica
    {
        public double limite { get; set; }
        public override void Depositar()
        {
            Console.WriteLine("\nVocê tem que depositar 500");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você tem que sacar 300");
        }
    }

    public class ContaCorrente3 : Generica
    {
        public double limite { get; set; }
        public override void Depositar()
        {
            Console.WriteLine("\nVocê tem que depositar 2.500");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você tem que sacar 3.900");
        }
    }
}
