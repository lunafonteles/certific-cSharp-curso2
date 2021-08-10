
using System;
using _06_ByteBank;

public class ContaCorrente
{
    public Cliente Titular { get; set; }

    public short Agencia { get; set; }
    public int Numero { get; set; }

    private double _saldo = 100;
	//valor inicial padrao foi mudado pra 100. sera usado se no programa nao for definido um valor
	//encapsulamos o saldo pra ser privado
	

	public double Saldo
    {
        get
        {
            return _saldo;
        }

        set
        {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
        }
            
    }
    


    /*public double GetSaldo()
    {
        return saldo;
    }
 
    public void SetSaldo(double saldo)
    {
    if(saldo < 0)
    {
        return;
    }

        this.saldo = saldo;
}
//return para a funcao
//mesmo resultado do que foi escrito no get e set
*/

public bool Sacar(double valor)
    {
        if (this._saldo < valor)
        {
            return false;
        }
        else
        {
            this._saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this._saldo += valor;
    }
    //void nao tem retorno

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this._saldo < valor)
        {
            Console.WriteLine("Saldo Insuficiente");
            return false;
        }
        else
        {
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}