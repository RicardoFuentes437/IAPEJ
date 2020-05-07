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
    public partial class buscarMaestro : Form
    {
        public buscarMaestro()
        {
            InitializeComponent();
        }

        //Fecha y Hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Recolectar datos y realizar busqueda
        private void button1_Click(object sender, EventArgs e)
        {
            maestros maestro = new maestros();
            mostrarMaestro mostrar = new mostrarMaestro();
            conexionBD conectar = new conexionBD();
            maestro = conectar.ConsultarM(dato.Text, dato2.Text);
            mostrar.Datos(maestro);
            mostrar.Show();
            this.Close();
        }
    }
}
