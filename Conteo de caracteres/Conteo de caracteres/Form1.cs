using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conteo_de_caracteres
{
    public partial class Form1 : Form
    {
        public void TextoInicio()
        {
            MessageBox.Show("Realizado por Agustin Macoggi", "Bienvenido",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Form1()
        {
            InitializeComponent();
            TextoInicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cuadro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_cuadro_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txt_cuadro_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btn_tarea1_Click(object sender, EventArgs e)
        {
            string cadena = Convert.ToString(txt_cuadro.Text).ToLower();
            char aBuscar = 'a';
            int canta=0, cantl=0;
            foreach (char c in cadena)
            {
               if (c==aBuscar) ++canta;
            }
            cantl = txt_cuadro.Text.Length;
            MessageBox.Show(string.Format("El texto que escribio contiene " + canta + " veces la letra A.\nEl mismo tiene " + cantl + " de caracteres en total."), "Tarea 1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_cuadro.Text = "";
            txt_cuadro.Focus();
        }

        private void btn_tarea2_Click(object sender, EventArgs e)
        {
            string cadena = Convert.ToString(txt_cuadro.Text);
            System.IO.File.WriteAllText(@"C:\Tarea2.txt", cadena);
            MessageBox.Show("Se ha creado un archivo de texto en \nel disco C con el nombre 'Tarea2'", "Tarea 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_tarea3_Click(object sender, EventArgs e)
        {
            int count = txt_cuadro.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count(); //PREGUNTARLE AL PROFE QUE ONDA
            MessageBox.Show(string.Format("El texto que escribio contiene " + count + " palabras en total."), "Tarea 3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
