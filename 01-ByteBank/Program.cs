using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 846;
            contaDaGabriela.numero = 846354;
            contaDaGabriela.saldo = 200.00;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            if(contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }


            Console.ReadLine();
        }
    }
}
