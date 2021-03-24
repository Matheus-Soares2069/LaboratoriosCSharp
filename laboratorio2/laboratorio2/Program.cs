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

            Console.ReadLine();
            Console.WriteLine("BobNelson Depositou 5000 Dinheiros. ", BobNelson.Depositar(5000));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("TestolfoRocha Depositou 1500 Dinheiros. ", TestolfoRocha.Depositar(1500));
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("LisaLeite Depositou 2000 Dinheiros. ", LisaLeite.Depositar(2000));
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("BobNelson Transferiu 600 Dinheiros para a conta {0}. ", TestolfoRocha.Numero, BobNelson.Tranferir(600));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("TestolfoRocha recebeu 600 Dinheiros da conta {0}. ", BobNelson.Numero, TestolfoRocha.Receber(600));
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("LisaLeite sacou 250 Dinheiros. ", LisaLeite.Sacar(250));
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("LisaLeite transferiu 400 Dinheiros para a conta {0}. ", TestolfoRocha.Numero, LisaLeite.Tranferir(400));
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("TestolfoRocha recebeu 400 Dinheiros da conta {0}. ", LisaLeite.Numero, TestolfoRocha.Receber(400));
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("TestolfoRocha transferiu 1000 Dinheiros para a conta {0}. ", BobNelson.Numero, TestolfoRocha.Tranferir(1000));
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("BobNelson recebeu 1000 Dinheiros da conta {0}. ", TestolfoRocha.Numero, BobNelson.Receber(1000));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("BobNelson sacou 900 Dinheiros. ", BobNelson.Sacar(900));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("BobNelson transferiu 1500 Dinheiros para a conta {0}. ", LisaLeite.Numero, BobNelson.Tranferir(1500));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine(" LisaLeite recebeu 1500 Dinheiros da conta {0}. ", BobNelson.Numero, LisaLeite.Receber(1500));
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("TestolfoRocha transferiu 1200 Dinheiros para a conta {0}. ", LisaLeite.Numero, TestolfoRocha.Tranferir(1200));
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("LisaLeite recebeu 1200 Dinheiros da conta {0}. ", TestolfoRocha.Numero, LisaLeite.Receber(1200));
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("BobNelson sacou 2000 Dinheiros. ", BobNelson.Sacar(2000));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("LisaLeite depositou 100 Dinheiros. ", LisaLeite.Depositar(100));
            Console.Write("Saldo Atual: ");
            LisaLeite.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("TestolfoRocha transferiu 700 Dinheiros para a conta {0}. ", BobNelson.Numero, TestolfoRocha.Tranferir(700));
            Console.Write("Saldo Atual: ");
            TestolfoRocha.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("BobNelson recebeu 700 Dinheiros da conta {0}. ", TestolfoRocha.Numero, BobNelson.Receber(700));
            Console.Write("Saldo Atual: ");
            BobNelson.VerificarSaldo();
            Console.ReadLine();
        }
    }
}