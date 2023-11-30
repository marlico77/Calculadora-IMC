using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(textBox1.Text);
            float altura = float.Parse(textBox2.Text);
            float resultado = peso / (altura * altura);



            if (resultado < 18.5)

            {
                label4.Text = resultado.ToString(resultado + " Abaixo do Peso");

            }
            else if (resultado >= 18.5 && resultado < 24.9) 
            { 
                label4.Text = resultado.ToString("Seu IMC é: " + resultado + " (normal)");
            }
            else if (resultado  >= 25 && resultado < 29.9) 
            {
                label4.Text = resultado.ToString(resultado + " Sobrepeso");
            }
            else
            {
                label4.Text = resultado.ToString("Impossível"); 
            }
            

           


         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
