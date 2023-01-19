using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginUnisur1
{
    public partial class Form1 : Form
    {
        static int intentos = 0;
        static int totales = 3;
        int testInt = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //usuario:alex
            //contraseña:Barco100
            string usuario = tbuser.Text;
            string password = tbcontrasena.Text;
            if (this.tbuser.Text == "alex" && this.tbcontrasena.Text == "Barco100")
            {
                intentos = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\Alexander Vazquez\source\repos\loginUnisur1\loginUnisur1\color.png");
                MessageBox.Show("Bienvenido");

                for (int i = 0; i < 3; i --)
                {
                    testInt += intentos;
                }
               
            }
            

            else if (intentos > 0 && intentos <= 3) ;

            {
                intentos--;
                MessageBox.Show("usuario o contraseña incorrecta");
                aviso.Text = " solo tienes " + Convert.ToString(intentos);
            if ( intentos == 0); 
                 {

                     button1.Enabled = false;
                    

                 }
                

            }

               

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
