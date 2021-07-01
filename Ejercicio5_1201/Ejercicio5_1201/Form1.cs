using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {

            int[,] matriz = new int[Convert.ToInt32(textBox1_filas.Text), Convert.ToInt32(textBox2_columnas.Text)];

            Random matrizAleatoria = new Random();


            for ( int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for(int columna =0; columna< matriz.GetLength(1); columna++)
                {

                    matriz[filas, columna] = matrizAleatoria.Next(0, 100);

                    listBox1_imprimir.Items.Add("La posición es:" + filas + " , " + columna + " = " + matriz[filas, columna].ToString());
                }

            } 
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox1_filas.Clear();
            textBox2_columnas.Clear();
            listBox1_imprimir.Items.Clear();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
