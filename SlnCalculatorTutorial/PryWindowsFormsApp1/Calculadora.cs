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
	public partial class Calculadora : Form
	{
		char operador= '\0';
		public Calculadora()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			txtResultado.Text = txtResultado.Text + "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtResultado.Text = txtResultado.Text + "2";
		}

		
		private void btnIgual_Click(object sender, EventArgs e)
		{
			int resultado = 0;
			if (operador == '\0')
				return;
			string operacion = txtResultado.Text;
			string[] operaciones = operacion.Split(operador);
			if (operaciones.Length == 0)
				return;
			int parteIzquierda = Convert.ToInt32(operaciones[0]);
			int parteDerecha = Convert.ToInt32(operaciones[1]);
			switch (operador)
			{
				case '+':
					resultado = parteIzquierda + parteDerecha;
					//txtResultado.Text = Convert.ToString(resultado);
					txtResultado.Text = resultado.ToString();
					break;
				case '-':
					resultado = parteIzquierda - parteDerecha;
					//txtResultado.Text = Convert.ToString(resultado);
					txtResultado.Text = resultado.ToString();
					break;
				case 'x':
					resultado = parteIzquierda * parteDerecha;
					//txtResultado.Text = Convert.ToString(resultado);
					txtResultado.Text = resultado.ToString();
					break;
				case '/':
					resultado = parteIzquierda / parteDerecha;
					//txtResultado.Text = Convert.ToString(resultado);
					txtResultado.Text = resultado.ToString();
					break;
				default:
					txtResultado.Text = "";
					break;
			}

		}

		private void btnSuma_Click(object sender, EventArgs e)
		{
			txtResultado.Text += "+";
			operador = '+';
		}

		private void btnResta_Click(object sender, EventArgs e)
		{
			txtResultado.Text += "-";
			operador = '-';
		}

		private void btnMultiplica_Click(object sender, EventArgs e)
		{
			txtResultado.Text += "x";
			operador = 'x';
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			operador = '/';
			txtResultado.Text += operador.ToString();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
