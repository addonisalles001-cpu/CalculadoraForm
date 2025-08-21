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
    public partial class Form1 : Form
    {
        // Variáveis Globais:
        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Implementar depois...
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
        

    }
}
