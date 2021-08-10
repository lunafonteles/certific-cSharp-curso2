using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using _05_ByteBank; desnecessatio pq esta no namespace

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.cpf = "048.578.978-65";
            gabriela.profissao = "Contadora";
            */
            ContaCorrente conta = new ContaCorrente();

            /*conta.titular = gabriela; esta com erro
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "048.578.978-65";
            conta.titular.profissao = "Contadora";
            */

            conta.agencia = 563;
            conta.conta = 563123;
            conta.saldo = 500;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em cota.titular é null");
            }
                

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
