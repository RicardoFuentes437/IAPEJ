using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAPEJ
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        //Hora y Fecha
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Imagen del Maestro
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buscarMaestro maestros = new buscarMaestro();
            maestros.Show();
            this.Close();
        }

        //"Maestros"
        private void label3_Click(object sender, EventArgs e)
        {
            buscarMaestro maestros = new buscarMaestro();
            maestros.Show();
            this.Close();
        }

        //Imagen del alumno
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            buscarAlumno alumnos = new buscarAlumno();
            alumnos.Show();
            this.Close();

        }

        //"Alumnos"
        private void label4_Click(object sender, EventArgs e)
        {
            buscarAlumno alumnos = new buscarAlumno();
            alumnos.Show();
            this.Close();
        }
    }
}
