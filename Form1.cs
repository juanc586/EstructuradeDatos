using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Pilas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtmaximo.Text);
    
            MessageBox.Show("Pila creada");

        }

        private void push_Click(object sender, EventArgs e)
        {

                int n;
            n = int.Parse(txtmaximo.Text);
                txtnumero.Clear();
                txtnumero.Focus();

            }

        private void button3_Click(object sender, EventArgs e)
        {
 
                MessageBox.Show("Salio");

            }
        }
}

