﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200;
            

            Console.WriteLine (conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.conta);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
