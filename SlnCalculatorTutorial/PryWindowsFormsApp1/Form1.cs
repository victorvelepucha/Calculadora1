using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryWindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEjecutar_Click(object sender, EventArgs e)
		{
			int longitud = 10;
			if ( txtNombre.Text == "" )
			{
				MessageBox.Show("Ingrese un nombre");
				return;
			}
			string saludo = "Hola " + txtNombre.Text;
			for (int i = 0; i < longitud; i++)
			{
				MessageBox.Show(saludo, "Mensaje de saludo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			}
		}
	}
}
