using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            //tipo de variavel de referencia vai dar resultado false se comparar as duas, mesmo tendo o mesmo conteudo
            contaDaGabriela.titular = ("Gabriela");
            contaDaGabriela.agencia = (863);
            contaDaGabriela.conta = (863123);

            ContaCorrente contaDaGabrielaSilva = new ContaCorrente();
            contaDaGabrielaSilva.titular = ("Gabriela");
            contaDaGabrielaSilva.agencia = (863);
            contaDaGabrielaSilva.conta = (863123);

            Console.WriteLine(contaDaGabriela.titular);
            Console.ReadLine();

        }
    }
}
