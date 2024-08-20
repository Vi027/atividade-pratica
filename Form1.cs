using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade_Prática
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declarando as variáveis
        int n1, n2, n3;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declarando a variável n1 como maior e menor
            int maior = n1;
            int menor = n1;

            //Convertendo os valores para receber o valor digitado pelo usuário
            n1 = int.Parse(txtvalor1.Text);
            n2 = int.Parse(txtvalor2.Text);
            n3 = int.Parse(txtvalor3.Text);

            //Encontrar o maior valor
            if (n2 > maior)
            {
                maior = n2;
            }
            if (n3 > maior)
            {
                maior = n3;
            }

            //Encontrar o menor valor
            if (n2 < menor)
            {
                menor = n2;
            }
            if (n3 < menor)
            {
                menor = n3;
            }

            //Exibindo os resultados
            txtresultadomaior.Text = maior.ToString();
            txtresultadomenor.Text = menor.ToString();
        }

    }
}
