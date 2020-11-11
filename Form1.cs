using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAPA_Stack_Nodos
{
	public partial class Form1 : Form
	{
		pila STK;
		public Form1()
		{
			STK = new pila();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			pila xfer = new pila();
			xfer.primero = STK.primero;
			richTextBox1.Text = STK.Visual(xfer);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			STK.push(textBox1.Text);
			textBox1.Clear();
			progressBar1.PerformStep();
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			pila xfer = new pila();
			xfer.primero = STK.primero;
			richTextBox1.Text = STK.Buscar(xfer, textBox2.Text);
		}

		private void button4_Click(object sender, EventArgs e)
		{

			if (STK.primero == null)
			{
				MessageBox.Show("No se puede extraer elementos de una Pila vacia", "ALERTA");
			}
			else
			{
				richTextBox1.Text = STK.Pop(STK);
				progressBar1.Value = progressBar1.Value - 1;
			}
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
