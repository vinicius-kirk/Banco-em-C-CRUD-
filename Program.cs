using System;
using System.Collections.Generic;

namespace DIO.bank
{
    class Program
    {


        static List <Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {       

            string opcaoUsuario = obterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {

                switch(opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                       Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;   

                    default:
                            throw new ArgumentOutOfRangeException();     

                }

                    opcaoUsuario = obterOpcaoUsuario();
                    
        
            }

             Console.WriteLine("Obrigado por utilizar nossos serviços");
             Console.ReadLine();

            
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o ID da sua conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);

        }

        private static void ListarContas()
        {
            Console.WriteLine("Lista de Contas:");

            if(listContas.Count == 0)
            {

                Console.WriteLine("Nenhuma Conta Cadastrada");
                return;


            }

            for(int i = 0; i < listContas.Count;i++)
            {

                Conta conta = listContas[i];
                Console.WriteLine("#{0} -",i);
                Console.WriteLine(conta);

            }



        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir uma nova conta");

            Console.WriteLine("Digite 1 para pessoa juridica e 2 para Fisica");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do cliente");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo do cliente");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o credito do cliente");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta:(TipoConta)entradaTipoConta,nome:entradaNome,saldo:entradaSaldo,credito:entradaCredito);

            listContas.Add(novaConta);

        

        }

        public static void Depositar(){

            System.Console.WriteLine("Digite o ID da Conta que deseja Depositar: ");
            int indiceConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor que será depositado na conta: ");
            double valorDeposito = double.Parse(Console.ReadLine());

             listContas[indiceConta].Depositar(valorDeposito);
        }


        public static void Transferir(){

            System.Console.WriteLine("Digite o ID da Conta de saída: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o ID da Conta que deseja Depositar: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor que será depositado na conta: ");
            double valorTransferencia = double.Parse(Console.ReadLine());


            listContas[indiceContaOrigem].Transferir(valorTransferencia:valorTransferencia,listContas[indiceContaDestino]);
        }

        private static string obterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("Bem vindo ao Banco Teixeira!");
            Console.WriteLine("Informe abaixo a opção desejada:");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova Conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();


            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;          
        }
    }
}
