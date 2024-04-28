using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCapital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double capitalInicialText = double.Parse(inicialText.Text);
            double tasaInteresText = double.Parse(txttasa.Text);
            double tiempo = double.Parse(txtTi.Text);


            double operacionCapital = capitalInicialText * (1 + tasaInteresText) * tiempo;

            txtfinal.Text = operacionCapital.ToString();


        }
    }
}
