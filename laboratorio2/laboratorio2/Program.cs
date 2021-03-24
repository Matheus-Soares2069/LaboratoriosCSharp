using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Contas BobNelson = new Contas(123456, "Bob Nelson", 0, "ContaCorrente");
            Contas TestolfoRocha = new Contas(717171, "Testolfo Rocha", 0, "ContaPoupanca");
            Contas LisaLeite = new Contas(654321, "Lisa Leite", 0, "ContaCorrente");

            BobNelson.Depositar(5000);
            TestolfoRocha.Depositar(1500);
            LisaLeite.Depositar(2000);
            BobNelson.Tranferir(600);
            TestolfoRocha.Receber(600);
            LisaLeite.Sacar(250);
            LisaLeite.Tranferir(400);
            TestolfoRocha.Receber(400);
            TestolfoRocha.Tranferir(1000);
            BobNelson.Receber(1000);
            BobNelson.Sacar(900);
            BobNelson.Tranferir(1500);
            LisaLeite.Receber(1500);
            TestolfoRocha.Tranferir(1200);
            LisaLeite.Receber(1200);
            BobNelson.Sacar(2000);
            LisaLeite.Depositar(100);
            TestolfoRocha.Tranferir(700);
            BobNelson.Receber(700);
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();

        }
    }
}