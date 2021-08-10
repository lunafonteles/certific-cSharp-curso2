using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            
            Console.WriteLine("Valor atual do Bruno " + contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(resultadoSaque);

            Console.WriteLine("Valor após o saque " + contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine("Valor após o deposito " + contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);
            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);


            Console.ReadLine();

        }
    }
}
