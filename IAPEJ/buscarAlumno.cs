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
    public partial class buscarAlumno : Form
    {
        public buscarAlumno()
        {
            InitializeComponent();
        }

        //Fecha y Hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        //Recolectar datos y realizar busqueda
        private void button1_Click(object sender, EventArgs e)
        {
            alumnos alumn = new alumnos();
            mostrarAlumno mostrar = new mostrarAlumno();
            conexionBD conectar = new conexionBD();
            if(opcion.Text == "Código de Estudiante")
            {
                alumn = conectar.Consultar(opcion.Text, dato.Text);
            }else
            {
                alumn = conectar.Consultar(opcion.Text, dato.Text, dato2.Text);
            }
            mostrar.tabla_Calif.DataSource = conectar.calificaciones(alumn.Code);
            mostrar.Datos(alumn);
            mostrar.Show();
            this.Close();
        }

        private void dato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
