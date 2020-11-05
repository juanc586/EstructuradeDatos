using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pilas
{
    class pilas
    {
        private int maximo;
        private int cima;
        private int[] lapila;
        private pilas() { }
        private pilas(int max)
        {
            lapila = new int[max];
            maximo = max;
            cima = -1;
        }
        public Boolean pila_llena()
        {
            if (cima == maximo - 1)
            { return true; }
            else
            { return false; }
        }
        public Boolean pila_vacia()
        {
            if (cima == -1)
                return true;
            else
                return false;
        }
        public void push(int n)
        {
            if (pila_llena() == true)
            {
                MessageBox.Show("pila llena");
            }
            else
            { cima++; lapila[cima] = n; }
        }
        public int pop()
        {
            int n = 0;
            if (pila_vacia() == true)
            {
                MessageBox.Show("pila vacia");
                return n;
            }
            else
            {
                n = lapila[cima];
                cima--;
                return n;
            }
        }
    }
}

