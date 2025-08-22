using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class txbCalculadora : Form
    {
        // Variáveis Globais:
        bool operadorClicado = true;

        public txbCalculadora()
        {
            InitializeComponent();
        }
        

        private void btnIgual_Click(object sender, EventArgs e)
        {
            

            // Implementar depois...
            try
            {
                var resultado = new DataTable().Compute(txbTela.Text, null);
                txbTela.Text = resultado.ToString();
                if(txbTela.Text == "∞")
                {
                    btnLimpar.PerformClick();
                    MessageBox.Show("Deu ruim Parsa");
                   

                }


            }
            catch (Exception ex)
            {
                btnLimpar.PerformClick();
                MessageBox.Show("");
                
             

             
            }



        }

        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando esse evento:
            Button botaoClicado = (Button)sender;

            // Adicionar o Text no botão clicado no TexBox:
            txbTela.Text += botaoClicado.Text;

            // "abaixar a bandeirinha"
            operadorClicado = false;
        }
        

        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda não foi clicado:
            if (operadorClicado == false)
            {
                // Obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o Text no botão clicado no TexBox:
                txbTela.Text += botaoClicado.Text;

                // Mudar o operadorClicado para true (levantar a bandeirinha):
                operadorClicado = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a tela:
            txbTela.Text = "";
            // Voltar o operador clicado para true:
            operadorClicado = true;

        }
    }
}
