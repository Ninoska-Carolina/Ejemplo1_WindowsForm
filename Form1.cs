using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ul_ejemplo_1
{
    public partial class txtN1 : Form
    {
        public txtN1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("FUNCIONA");
            //int numero1 = Convert.ToInt32(txtN1.Text);
            int numero1 = Convert.ToInt32(txtN_1.Text);
            int numero2 = Convert.ToInt32(txtN_2.Text);


            int suma = Sumar(numero1, numero2);
            int resta = Resta(numero1, numero2);
            int multiplicar = Multiplicar(numero1, numero2);
            double dividir = Dividir(numero1, numero2);

            MessageBox.Show($"LA SUMA ES:{suma}\n"+
                $"LA RESTA ES:{resta}\n"+
                $"LA MULTIPLICACION ES:{multiplicar}\n"+
                $"LA DIVISION ES:{dividir}\n");

        }

        private double Dividir(int numero1, int numero2)
        {
            return  (double)numero1/numero2;
        }

        private int Multiplicar(int numero1, int numero2)
        {
            return numero1* numero2;
        }

        private int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN_1.Text);
            int numero2 = Convert.ToInt32(txtN_2.Text);

            int primos = Primos(numero1, numero2);

            MessageBox.Show($"Los numeros primos seran:{primos}");

        }
        private int Primos(int numero1, int numero2) {
                for (int i = numero1; i <= numero2; i++)
                {
                    int cont = 0;
                    for (int j = numero2; j <= numero1; j++)
                    {
                        if (i % j == 0)
                        {
                            cont++;
                        }
                    }
                    if (cont == 2)
                    {
                    
                        MessageBox.Show($"{i}");
                    }

                }
                return 0;

            }
    }
}
