using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAPA_Stack_Nodos
{
	class nodo
	{
		private string _Data;
		private nodo _next;

		public string Data
		{
			get { return _Data; }
			set { _Data = value; }
		}

		public nodo Next
		{
			get { return _next; }
			set { _next = value; }
		}

	}
}
