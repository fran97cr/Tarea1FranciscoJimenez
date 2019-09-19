using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1.Clases;

namespace Tarea1
{
    public partial class FormHome : Form
    {
        //Se declaran las variables para la parte de clase Math
        int numero1;
        int numero2;
        int ResultadoMaxNum;
        int ResultadoMinNum;
        //Se declaran las variables para la parte de clase String
        string texto;
        char letra;
        int indice;
        string ManipulacionString;


        public FormHome()
        {
            
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumMax_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtNum1.Value);
            numero2 = Convert.ToInt32(txtNum2.Value);
            ResultadoMaxNum = Math.Max(numero1, numero2);
            MessageBox.Show("El número mayor es: " + ResultadoMaxNum);
            
        }

        private void BtnNumMin_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtNum1.Value);
            numero2 = Convert.ToInt32(txtNum2.Value);
            ResultadoMinNum = Math.Min(numero1, numero2);
            MessageBox.Show("El número menor es: " + ResultadoMinNum);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            texto = txtString.Text;
            letra = Convert.ToChar(txtIndex.Text);
            indice = texto.IndexOf(letra);
            MessageBox.Show("La posición de la letra es: " +indice+" (0 siendo el primer digito)");
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            texto = txtString.Text;
            ManipulacionString = texto.ToUpper();
            MessageBox.Show("Texto fue cambiado a mayusculas: '" + ManipulacionString + "'");
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            texto = txtString.Text;
            ManipulacionString = texto.ToLower();
            MessageBox.Show("Texto fue cambiado a minusculas: '" + ManipulacionString + "'");
        }

        private void btnParte3y4_Click(object sender, EventArgs e)
        {
            CostaRica cr = new CostaRica();
            Panama pn = new Panama();
            MessageBox.Show("Parte de Herencia: "+pn.Panama());
            MessageBox.Show("Parte de Abstracción: "+cr.costaRicaPais());
        }
    }
}
