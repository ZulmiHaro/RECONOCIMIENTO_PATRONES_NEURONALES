using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerosRN
{
    public partial class Form1 : Form
    {
        public int[,] Patrones = new int[10,7];
        public int[] Xi = new int[7];
        public int[] Yd = new int[7];
        public double[] W = new double[7];
        public double[] Wd = new double[7];
        public int Yo,n,numero;
        public int bias = 1;
        public bool aprehendio = false;
        public double net, fAprendizaje,aleatorio, Wb;
        public Form1()
        {
            InitializeComponent();
            btnAnalizar.Focus();
            llenar();
        }
        private void llenar()
        {
            for (int i = 0; i < 7; i++)
            {
                Xi[i] = -1;
            }
            //txtPrue2.Text = Convert.ToString(Xi[2]);
        }
        private void cargarListView()
        {

            for (int i = 0; i < 7; i++)
            {
                int suma = i + 1;
                ListViewItem lista = new ListViewItem("Neurona  "+ suma);
                lista.SubItems.Add(Xi[i].ToString());
                lista.SubItems.Add(W[i].ToString());
                lvN.Items.Add(lista);
            }
        }
        private void cargarYD()
        {
            //for(int i = 0; i< 7; i++)
            //{
                //numero 0
                if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
                else if (Xi[0] == -1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
                else if (Xi[0] == 1 && Xi[1] == -1 && Xi[2] == 1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
                else if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
                else if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == -1 && Xi[4] == -1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
                else if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == -1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
                else if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 0;
                }
            //numero 1
                if (Xi[0] == -1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == -1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 1;
                }
                else if (Xi[0] == -1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == -1 && Xi[4] == -1 && Xi[5] == -1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 1;
                }
                else if (Xi[0] == -1 && Xi[1] == -1 && Xi[2] == -1 && Xi[3] == -1 && Xi[4] == 1 && Xi[5] == -1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 1;
                }
            //numero 2
                if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == -1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 2;
                }
                else if (Xi[0] == 1 && Xi[1] == -1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == -1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 2;
                }
                else if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == -1 && Xi[5] == -1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 2;
                }
            //numero 3
                if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == 1 && Xi[6] == 1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 3;
                }
                else if (Xi[0] == 1 && Xi[1] == -1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == -1 && Xi[6] == 1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 3;
                }
                else if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == 1 && Xi[6] == 1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 3;
                }
                else if (Xi[0] == 1 && Xi[1] == -1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == -1 && Xi[6] == 1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 3;
                }
            //numero 4
            if (Xi[0] == -1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == 1 && Xi[4] == 1 && Xi[5] == -1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 4;
                }
                //numero 5
                if (Xi[0] == 1 && Xi[1] == -1 && Xi[2] == 1 && Xi[3] == 1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 5;
                }
                //numero 6
                if (Xi[0] == 1 && Xi[1] == -1 && Xi[2] == 1 && Xi[3] == 1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 6;
                }
                //numero 7
                if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == -1 && Xi[3] == 1 && Xi[4] == 1 && Xi[5] == -1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 7;
                }
                //numero 8
                if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == 1 && Xi[4] == 1 && Xi[5] == 1 && Xi[6] == 1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 8;
                }
                //numero 9
                if (Xi[0] == 1 && Xi[1] == 1 && Xi[2] == 1 && Xi[3] == 1 && Xi[4] == 1 && Xi[5] == -1 && Xi[6] == -1)
                {
                    Yd[0] = 1; Yd[1] = 1; Yd[2] = 1; Yd[3] = 1; Yd[4] = 1; Yd[5] = 1; Yd[6] = 1;
                    numero = 9;
                }
            //}
        }
        private void generarDatosRn()
        {
            Random rdnW = new Random();
            Random rdnFA = new Random();
            Random rdnWb = new Random();

            for (int k = 0; k < 7; k++)
            {
                aleatorio = rdnW.NextDouble();
                W[k] = aleatorio;
                //txtR.Text = W[2].ToString();
            }
            fAprendizaje = rdnFA.NextDouble();
            //Wb = rdnWb.Next(-1,2);
            Wb = rdnWb.NextDouble()*2;
            //txtR.Text = fAprendizaje.ToString();
        }
        private void funcionNET()
        {
            //double suma = 0;
            //for (int i = 0;i > 7; i++)
            //{ 
            //    net = suma + Xi[i] * W[i];              
            //}
            net = Xi[0] * W[0]+ Xi[1] * W[1]+ Xi[2] * W[2]+ Xi[3] * W[3]+ Xi[4] * W[4]+
                Xi[5] * W[5]+ Xi[6] * W[6]+ bias* Wb;
            //txtR.Text = net.ToString();
            //txtR.Text = Wb.ToString();
        }
        private void CompYo()
        {
            if (net >= 0)
            {
                Yo = 1;
            }
            else
            {
                Yo = 0;
            }
        }
        private void CompYd()
        {
            for (int i = 0; i < 7; i++)
            {
                if (Yo == Yd[0] && Yo == Yd[1] && Yo == Yd[2] && Yo == Yd[3] && Yo == Yd[4] && Yo == Yd[5] && Yo == Yd[6])
                {
                    txtFinal.Text = numero.ToString();
                    aprehendio = true;
                    MessageBox.Show("SE DIO EL APRENDIZAJE");

                }
            }
            //if (Yo == Yd[0])
            //{
            //    txtFinal.Text = "0";
            //    MessageBox.Show("SE DIO EL APRENDIZAJE");
            //}
        }
        private void reglaDelta()
        {
            for (int i = 0;i < 7; i++)
            {
                Wd[i] = W[i] + fAprendizaje * (Yd[0] - Yo) * Xi[i];
                net = Xi[0] * Wd[0] + Xi[1] * Wd[1] + Xi[2] * Wd[2] + Xi[3] * Wd[3] + Xi[4] * Wd[4] +
                Xi[5] * Wd[5] + Xi[6] * Wd[6] + bias * Wb;
            }
        }
        private void cargarDatosGV()
        {
            n = 0;
            for (int i =0; i < 7; i++)
            {
                dgDatos.Rows.Add(n, n + 1, Convert.ToString(W[i]),net,Yo, Convert.ToString(Yd[i]), Convert.ToString(Wd[i]));
                n++;
            }
        }
        private void txt1_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt1.BackColor = Color.Red;
            Xi[0] = 1;
            //txtProbar.Text = Convert.ToString(Xi[0]);
        }

        private void txt2_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt2.BackColor = Color.Red;
            Xi[1] = 1;
        }

        private void txt3_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt3.BackColor = Color.Red;
            Xi[2] = 1;
        }

        private void txt4_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt4.BackColor = Color.Red;
            Xi[3] = 1;
        }

        private void txt5_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt5.BackColor = Color.Red;
            Xi[4] = 1;
        }

        private void txt6_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt6.BackColor = Color.Red;
            Xi[5] = 1;
        }

        private void txt7_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt7.BackColor = Color.Red;
            Xi[6] = 1;
        }

        private void txt1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt1.BackColor = Color.White;
            Xi[0] = -1;
        }

        private void txt2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt2.BackColor = Color.White;
            Xi[1] = -1;
        }

        private void txt3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt3.BackColor = Color.White;
            Xi[2] = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt4.BackColor = Color.White;
            Xi[3] = -1;
        }

        private void txt5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt5.BackColor = Color.White;
            Xi[4] = -1;
        }

        private void txt6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt6.BackColor = Color.White;
            Xi[5] = -1;
        }

        private void txt7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt7.BackColor = Color.White;
            Xi[6] = -1;
        }


        private void btnAnalizar_Click(object sender, EventArgs e)
        {

            dgDatos.Rows.Clear();
            dgDatos.Refresh();
            lvN.Items.Clear();
            cargarListView();
            cargarYD();
            generarDatosRn();
            funcionNET();
            CompYo();
            CompYd();
            reglaDelta();
            cargarDatosGV();

        }
    }
}
