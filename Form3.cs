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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Declarando as variáveis
        int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Convertendo as variáveis para receber o valor digitado pelo usuário
            n1 = int.Parse(txtgremio.Text);
            n2 = int.Parse(txtpalmeiras.Text);
            n3 = int.Parse(txtsantos.Text); 
            n4 = int.Parse(txtcorinthians.Text);
            n5 = int.Parse(txtpontepreta.Text);
            n6 = int.Parse(txtflamengo.Text);
            n7 = int.Parse(txtjuventude.Text);
            n8 = int.Parse(txtinternacional.Text);
            n9 = int.Parse(txtbotafogo.Text);
            n10 = int.Parse(txtcruzeiro.Text);
            n11 = int.Parse(txtvasco.Text);
            n12 = int.Parse(txtatletico.Text);

            //Condições para verificação de qual time é vencedor ou se teve empate
            //Grêmio e Juventude
            if (n1 > n7)
            {
                txtresultado1.Text = "Grêmio";
            }
            else if(n1 < n7)
            {
                txtresultado1.Text = "Juventude";
            }
            else if(n1 == n7)
            {
                txtresultado1.Text = "Empate";
            }

            //Palmeiras e Internacional
            if(n2 > n8)
            {
                txtresultado2.Text = "Palmeiras";
            }
            else if(n2 < n8)
            {
                txtresultado2.Text = "Internacional";
            }
            else if(n2 == n8)
            {
                txtresultado2.Text = "Empate";
            }

            //Santos e Botafogo
            if(n3 > n9)
            {
                txtresultado3.Text = "Santos";
            }
            else if(n3 < n9)
            {
                txtresultado3.Text = "Botafogo";
            }
            else if(n3 == n9)
            {
                txtresultado3.Text = "Empate";
            }

            //Corinthians e Cruzeiro
            if(n4 > n10)
            {
                txtresultado4.Text = "Corinthians";
            }
            else if(n4 < n10)
            {
                txtresultado4.Text = "Cruzeiro";
            }
            else if(n4 == n10)
            {
                txtresultado4.Text = "Empate";
            }
            
            //Ponte Preta e Vasco
            if(n5 > n11)
            {
                txtresultado5.Text = "Ponte Preta";
            }
            else if(n5 < n11)
            {
                txtresultado5.Text = "Vasco";
            }
            else if(n5 == n11)
            {
                txtresultado3.Text = "Empate";
            }

            //Flamengo e Atlético
            if(n6 > n12)
            {
                txtresultado6.Text = "Flamengo";
            }
            else if(n6 < n12)
            {
                txtresultado6.Text = "Atlético";
            }
            else if(n6 == n12)
            {
                txtresultado6.Text = "Empate";
            }

        }
    }
}
