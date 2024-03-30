using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            float soma, media, valor;
            soma = 0;

            foreach(Control controle in this.Controls)
            {
                try
                {
                    if (controle is TextBox)
                    {
                        valor = Convert.ToSingle(((TextBox)controle).Text);
                        soma += valor;
                    }
                    media = soma / 4;
                    this.Controls["label7"].Text = media.ToString("F2");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Os valores estão vazios! " + ex.Message);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e) // Limpar
        {
            foreach(Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label7"].Text = "...";
            }
        }
    }
}
