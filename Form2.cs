using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Prática
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Declarando as variáveis
        double peso, calculo;

        //Calcular o peso conforme a opção do planeta escolhido 
        private void btnpeso_Click(object sender, EventArgs e)
        {
            //Convertendo a variável para receber o valor digitado pelo usuário 
            peso = double.Parse(txtpeso.Text);

            if(rbmercurio.Checked)
            {
                calculo = (peso * 0.37);
                MessageBox.Show("O seu peso em Mercurio é: " + calculo);
            }
            else if(rbvenus.Checked)
            {
                calculo = (peso * 0.88);
                MessageBox.Show("O seu peso em Vênus é: " + calculo);
            }
            else if (rbmarte.Checked)
            {
                calculo = (peso * 0.38);
                MessageBox.Show("O seu peso em Marte é: " + calculo);
            }
            else if (rbjupter.Checked)
            {
                calculo = (peso * 2.64);
                MessageBox.Show("O seu peso em Júpter é: " + calculo);
            }
            else if (rbsaturno.Checked)
            {
                calculo = (peso * 1.15);
                MessageBox.Show("O seu peso em Saturno é: " + calculo);
            }
            else if (rburano.Checked)
            {
                calculo = (peso * 1.17);
                MessageBox.Show("O seu peso em Urano é: " + calculo);
            }
        }
    }
}
