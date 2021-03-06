
using System;

namespace DIO.bank

{
    public class Conta
    {   
        private string Nome {get;set;}

        private double Saldo {get;set;}

        private double Credito {get;set;}

        private TipoConta TipoConta {get;set;}


         public Conta (TipoConta tipoConta,string nome,double saldo,double credito)
         {

                this.TipoConta = tipoConta;
                this.Saldo = saldo;
                this.Nome = nome;
                this.Credito = credito;

         } 
        

        public bool Sacar(double valorSaque)
        {

                if(this.Saldo - valorSaque < (this.Credito * -1)){

                    Console.WriteLine("Saldo INSUFICIENTE");

                    return false;


                }

                this.Saldo -= valorSaque;

                Console.WriteLine("Saldo atual da conta de {0] é {1}",this.Nome,this.Saldo);

                return true;

        }
           

           public void Depositar(double valorDeposito)
           {
               this.Saldo += valorDeposito;
               Console.WriteLine("O seu novo saldo é {0}",this.Saldo);
           }


            public void Transferir(double valorTransferencia,Conta contaDestino)
            {

                if(this.Sacar(valorTransferencia)){

                contaDestino.Depositar(valorTransferencia);

                }

            }


            public override string ToString()
            {

                string retorno = "";
                retorno += "Tipo Conta " + this.TipoConta + " | "   ;
                retorno += "Nome " + this.Nome + " | "   ;
                retorno += "Saldo " + this.Saldo + " | "   ;
                retorno += "Crédito " + this.Credito;

                return retorno;


                
            }


    }


   
}