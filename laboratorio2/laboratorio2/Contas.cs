using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Contas
    {
        protected float NumeroConta, saldoAtual;
        protected string Titular, TipoConta;

        public Contas(float numero, string nome, float saldoAtual, string tipoConta)
        {
            this.NumeroConta = numero;
            this.Titular = nome;
            this.saldoAtual = saldoAtual;
            this.TipoConta = tipoConta;
        }
        public float Numero { get => NumeroConta; }
        public string Nome { get => Titular; }
        public float SaldoAtual { get => saldoAtual; }

        public float Depositar(float x)
        {
            return saldoAtual = saldoAtual + x;
        }

        public float Tranferir(float x)
        {
            if (TipoConta == "ContaPoupanca" && saldoAtual > 0)
            {
                return saldoAtual = saldoAtual - x - (0.15f * (x / 100));
            }
            if (TipoConta == "ContaCorrente" && saldoAtual > 0)
            {
                return saldoAtual = saldoAtual - x - (0.10f * (x / 100));
            }
            return 0;
        }

        public void VerificarSaldo()
        {
            Console.WriteLine(saldoAtual);
        }
        public float Sacar(float x)
        {

            if (TipoConta == "ContaCorrente" && saldoAtual > 0)

            {
                return saldoAtual = saldoAtual - x - (0.37f * (x / 100));
            }
            if (TipoConta == "ContaPoupanca" && saldoAtual > 0)
            {
                return saldoAtual = saldoAtual - x - (0.20f * (x / 100));
            }
            return 0;
        }
        public float Receber(float x)
        {
            return saldoAtual = saldoAtual + x;
        }
    }
}