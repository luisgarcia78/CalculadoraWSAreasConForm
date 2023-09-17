using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFormAreas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalCuadrado_Click(object sender, EventArgs e)
        {
            WSCalculadora.WebService1SoapClient cliente = new WSCalculadora.WebService1SoapClient();

            decimal resultado = cliente.AreaCuadrado(decimal.Parse(txtL1.Text), decimal.Parse(txtL2.Text));

            TxtResultCua.Text = resultado.ToString();

        }

        private void btnCalTria_Click(object sender, EventArgs e)
        {
            WSCalculadora.WebService1SoapClient cliente = new WSCalculadora.WebService1SoapClient();

            decimal resultado = cliente.AreaTriangulo(decimal.Parse(txtbase.Text), decimal.Parse(txtAltura.Text));

            txtRespuestaTria.Text = resultado.ToString();
        }

        private void BtnCalCirculo_Click(object sender, EventArgs e)
        {
            WSCalculadora.WebService1SoapClient cliente = new WSCalculadora.WebService1SoapClient();

            double resultado = cliente.AreaCirculo(double.Parse(txtRadio.Text));

            TxtRespuestaCir.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtL1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void txtL1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAltura_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BtnClearCua_Click(object sender, EventArgs e)
        {
            txtL1.Text = "";
            txtL2.Text = "";
            TxtResultCua.Text = "";
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclearTria_Click(object sender, EventArgs e)
        {
            txtRespuestaTria.Text = "";
            txtbase.Text = "";
            txtAltura.Text = "";
        }

        private void BtnClearCir_Click(object sender, EventArgs e)
        {
            txtRadio.Text = "";
            TxtRespuestaCir.Text = "";
        }
    }
}
