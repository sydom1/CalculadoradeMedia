using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //calcular
        {
            float soma, media, valor;
            soma = 0;
            

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);

                    soma += valor;
                }

                media = soma / 4;
                this.Controls["label7"].Text = media.ToString();

                if (media >= 7 && media < 10) 
                {
                    this.Controls["label8"].Text = media.ToString("APROVADO");
                }

                else if (media < 7 && media >= 5)
                {
                    this.Controls["label8"].Text = media.ToString("RECUPERAÇÃO");
                }

                else if (media < 5 && media >=0 )
                {
                    this.Controls["label8"].Text = media.ToString("REPROVADO");
                }

                else
                {
                    this.Controls["label8"].Text = media.ToString("VALOR INVALIDO");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //limpar
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }

                this.Controls["label7"].Text = "...";

                this.Controls["label8"].Text = "...";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
