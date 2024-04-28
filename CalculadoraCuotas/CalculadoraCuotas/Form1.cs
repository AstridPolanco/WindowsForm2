using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCuotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double interes = double.Parse(txtInteres.Text);
            double plazo = double.Parse(txtPlazo.Text);

            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes, plazo))) / (Math.Pow(1 + interes, plazo) - 1);
            cuotaMensual = Math.Round(cuotaMensual / 2);
            txtResultado.Text = cuotaMensual.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
