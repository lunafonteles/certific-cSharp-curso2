
using System;
using _04_byteBank;


public class ContaCorrente
    {
        public string titular;
        public short agencia;
        public int conta;
        public double saldo = 100;
        //valor inicial padrao foi mudado pra 100. sera usado se no programa nao for definido um valor

        //função e metodo sao sinonimos, mas metodo eh mais usado quando nao tem retorno e função quando tem
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
            //pq nao precisa do else?
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        //void nao tem retorno

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }

