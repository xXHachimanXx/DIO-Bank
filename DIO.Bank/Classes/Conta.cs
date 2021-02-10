using System;

namespace DIO.Bank
{
	public class Conta
	{
		private TipoConta TipoConta { get; set; }
		private double Saldo { get; set; }
		private double Credito { get; set; }
		private string Nome { get; set; }

		public Conta(TipoConta TipoConta, double Saldo, double Credito, string Nome)
		{
			this.TipoConta = TipoConta;
			this.Saldo = Saldo;
			this.Credito = Credito;
			this.Nome = Nome;
		}

		public bool Sacar(double valorSaque)
		{
			bool resp = true;

			if (this.Saldo - valorSaque < (this.Credito * -1))
			{
					Console.WriteLine("Saldo insuficiente!");
					resp = false;
			}
			else
			{
					this.Saldo -= valorSaque;
					Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
			}

			return resp;
		}

		public void Depositar(double valorDeposito)
		{
			this.Saldo += valorDeposito;

			Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
		}

		public void Transferir(double valorTransferencia, Conta contaDestino)
		{
			if(this.Sacar(valorTransferencia)) {
				contaDestino.Depositar(valorTransferencia);
			}
		}

        public override string ToString()
        {
            return "Tipo Conta: " + this.TipoConta + "\n" +
				   "Tipo Nome: " + this.Nome + "\n" +
				   "Tipo Saldo: " + this.Saldo + "\n" +
				   "Tipo Credito: " + this.Credito;
        }

    

	}
}