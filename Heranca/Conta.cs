using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public class Conta 
    {
        private double saldo;
        private double valor;
        private int numeroConta;

        public double Saldo { get => saldo; set => saldo = value; }
        public double Valor { get => valor; set => valor = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }

        public double depositar(double valor)
        {
            this.Saldo = this.valor + valor;

            return this.Saldo;
        }

       
        public void sacar()
        {

        }

        public void transferir()
        {

        }
    }
}
