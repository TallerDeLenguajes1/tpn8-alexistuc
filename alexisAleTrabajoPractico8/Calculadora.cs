using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlexisAleTrabajoPractico8
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        LinkedList<string> listadoDeOperaciones = new LinkedList<string>();
        float numero1;
        float numero2;
        string operador;

        //numeros desde el 0 al 9
        private void button10_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += "9";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = float.Parse(cuadroDeTexto.Text);
            cuadroDeTexto.Clear();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = float.Parse(cuadroDeTexto.Text);
            cuadroDeTexto.Clear();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            operador = "*";
            numero1 = float.Parse(cuadroDeTexto.Text);
            cuadroDeTexto.Clear();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = float.Parse(cuadroDeTexto.Text);
            cuadroDeTexto.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cuadroDeTexto.Text += ",";
            //es extraño, pero funciona con la coma y no con el punto .
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            cuadroDeTexto.Clear();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            numero2 = float.Parse(cuadroDeTexto.Text);
            cuadroDeTexto.Clear();
            ClaseCalculadora calculator = new ClaseCalculadora();
            calculator.Numero1 = numero1;
            calculator.Numero2 = numero2;
            switch (operador)
            {
                case "+":
                    cuadroDeTexto.Text = calculator.Suma().ToString();
                    listaOperaciones.Items.Add(Convert.ToString(DateTime.Now) + "\t" + numero1 + " + " + numero2 + " = " + (numero1 + numero2));

                    break;
                case "-":
                    cuadroDeTexto.Text = calculator.Resta().ToString();
                    listaOperaciones.Items.Add(Convert.ToString(DateTime.Now) + "\t" + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                    break;
                case "*":
                    cuadroDeTexto.Text = calculator.Multiplicacion().ToString();
                    listaOperaciones.Items.Add(Convert.ToString(DateTime.Now) + "\t" + numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                    break;
                case "/":
                    cuadroDeTexto.Text = calculator.Division().ToString();
                    if (numero2 != 0)
                    {
                        listaOperaciones.Items.Add(Convert.ToString(DateTime.Now) + "\t" + numero1 + " / " + numero2 + " = " + (calculator.Division().ToString()));
                    }
                    break;
            }
        }

        private void listaOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaOperaciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("borrado!");
            listaOperaciones.Items.RemoveAt(listaOperaciones.SelectedIndex);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listaOperaciones.Items.Clear();
            MessageBox.Show("HISTORIAL ELIMINADO");
        }
    }
}
