using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReconocimentodeNúmeros_RN
{
    public partial class Form1 : Form
    {
        int numero,Yo,Yd;
        int numeroBin;
        double[] W = new double[100];
        int[] X = new int[100];
        int bías = 1;
        double net, fAprendizaje;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            generarDatosRn();
            cargarDatos();
        }
        private void cargarDatos()
        {
            numero = cboNumeros.SelectedIndex;
            if (numero == 0)
            {
                txt1.BackColor = Color.Red;
                txt2.BackColor = Color.Red;
                txt3.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                txt6.BackColor = Color.Red;
                txt7.BackColor = Color.Red;
                numeroBin = 0000;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 1)
            {
                txt2.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                numeroBin = 0001;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 2)
            {
                txt1.BackColor = Color.Red;
                txt2.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt6.BackColor = Color.Red;
                txt7.BackColor = Color.Red;
                numeroBin = 0010;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 3)
            {
                txt1.BackColor = Color.Red;
                txt2.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                txt7.BackColor = Color.Red;
                numeroBin = 0011;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 4)
            {
                txt2.BackColor = Color.Red;
                txt3.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                numeroBin = 0100;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 5)
            {
                txt1.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt3.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                txt7.BackColor = Color.Red;
                numeroBin = 0101;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 6)
            {
                txt1.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt3.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                txt6.BackColor = Color.Red;
                txt7.BackColor = Color.Red;
                numeroBin = 0110;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 7)
            {
                txt2.BackColor = Color.Red;
                txt1.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                numeroBin = 0111;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 8)
            {
                txt1.BackColor = Color.Red;
                txt2.BackColor = Color.Red;
                txt3.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                txt6.BackColor = Color.Red;
                txt7.BackColor = Color.Red;
                numeroBin = 1000;
                txtP.Text = Convert.ToString(numeroBin);
            }
            else if (numero == 9)
            {
                txt1.BackColor = Color.Red;
                txt2.BackColor = Color.Red;
                txt3.BackColor = Color.Red;
                txt4.BackColor = Color.Red;
                txt5.BackColor = Color.Red;
                numeroBin = 1001;
            }
        }
        private void valordeNeuronas()
        {
            numero = cboNumeros.SelectedIndex;
            for (int i = 0; i < 7; i++)
            {

                if (numero == 0)
                {
                    W[0] = 1;
                    W[1] = 1;
                    W[2] = 1;
                    W[3] = 0;
                    W[4] = 1;
                    W[5] = 1;
                    W[6] = 1;
                }
                else if (numero == 1)
                {
                    W[0] = 0;
                    W[1] = 1;
                    W[2] = 0;
                    W[3] = 0;
                    W[4] = 1;
                    W[5] = 0;
                    W[6] = 0;
                }
                else if (numero == 2)
                {
                    W[0] = 1;
                    W[1] = 1;
                    W[2] = 0;
                    W[3] = 1;
                    W[4] = 0;
                    W[5] = 1;
                    W[6] = 1;
                }
                else if (numero == 3)
                {
                    W[0] = 1;
                    W[1] = 1;
                    W[2] = 0;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 0;
                    W[6] = 1;
                }
                else if (numero == 4)
                {
                    W[0] = 0;
                    W[1] = 1;
                    W[2] = 1;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 0;
                    W[6] = 0;
                }
                else if (numero == 5)
                {
                    W[0] = 1;
                    W[1] = 0;
                    W[2] = 1;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 0;
                    W[6] = 1;
                }
                else if (numero == 6)
                {
                    W[0] = 1;
                    W[1] = 0;
                    W[2] = 1;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 1;
                    W[6] = 1;
                }
                else if (numero == 7)
                {
                    W[0] = 1;
                    W[1] = 1;
                    W[2] = 0;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 0;
                    W[6] = 0;
                }
                else if (numero == 8)
                {
                    W[0] = 1;
                    W[1] = 1;
                    W[2] = 1;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 1;
                    W[6] = 1;
                }
                else if (numero == 9)
                {
                    W[0] = 1;
                    W[1] = 1;
                    W[2] = 1;
                    W[3] = 1;
                    W[4] = 1;
                    W[5] = 0;
                    W[6] = 0;
                }

            }
        }
        private void generarDatosRn()
        {
            Random rdn = new Random();
            for (int k = 1; k < 9; k++)
            {
                W[k] = rdn.NextDouble();
                //txtR.Text = pesos[5].ToString();
            }
            fAprendizaje= rdn.NextDouble();
            //txtR.Text = fAprendizaje.ToString();
        }
        private void funcionNet()
        {

        }
    }
}
