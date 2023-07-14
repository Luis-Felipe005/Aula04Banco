using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {


        //Variáveis globais
        List<String> extratos = new List<String>();





        public Form1()
        {
            InitializeComponent();
        }

    

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            double saldo;
            double valor;
            valor = double.Parse( txtValor.Text);
            saldo = double.Parse(lblSaldo.Text.Replace("R$", "") );

            double soma;

            if( lblOperacao.Text == "SAQUE")
            {

                soma =  saldo - valor;
                extratos.Add("SAQUE no valor de R$" + valor);
            }
            else
            {

                 soma = valor + saldo;
                extratos.Add("DEPÓSITO no valor de R$" + valor);

            }

            


            soma = saldo + valor;

            lblSaldo.Text = "R$" + soma;

           



        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            BtnDepositar.BackColor = Color.Gainsboro;
            BtnDepositar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.DodgerBlue;



            lblOperacao.Text = "SAQUE";



        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor =  Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            BtnDepositar.BackColor = Color.LightBlue;
            BtnDepositar.ForeColor = Color.DodgerBlue;
            lblOperacao.Text = "DEPÓSITO";

        }

        private void BtnExtrato_Click(object sender, EventArgs e)
        {


            Form2 telaExtrato = new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();



        }
    }
}
