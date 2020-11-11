using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAPA_Stack_Nodos
{
	class pila
	{
		public nodo primero;

		public pila()
		{
			primero = null;
		}

		public void push (string element)
		{
			nodo nuevo = new nodo();
			nuevo.Data = element;
			nuevo.Next = primero;
			primero = nuevo;
		}

		public string Visual (pila stk)
		{
			string temp = "";
			while (stk.primero != null)
			{
				temp += stk.primero.Data + "\n";
				stk.primero = stk.primero.Next;
			}

			return temp;

		}

		public string Buscar(pila stk, string subj)
		{
			string temp = "";
			bool found = false;
			while (stk.primero != null)
			{
				temp = stk.primero.Data;
				if (temp == subj)
				{
					found = true;
				}
				stk.primero = stk.primero.Next;
			}
			if (found)
			{
				return "El objeto fue encontrado en la lista";
			}
			else
			{
				return "No se encontro el objeto";
			}
			
		}

		public string Pop (pila stk)
		{
			string temp = "";
			temp = "Se ha eliminado el elemento\n" + stk.primero.Data;
			stk.primero = stk.primero.Next;
			return temp;

		}
	}
}
