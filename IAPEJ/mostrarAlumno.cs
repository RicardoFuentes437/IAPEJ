using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace IAPEJ
{
    public partial class mostrarAlumno : Form
    {
        conexionBD conectar = new conexionBD();
        public mostrarAlumno()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //Fecha y Hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        //Mostrar resultados de la consulta
        public void Datos(alumnos alumn)
        {
            alumnos al = new alumnos();
            al = alumn;
            nombre.Text = al.Name + " " + al.Apellidos;
            codigo.Text = Convert.ToString(al.Code);
            fecha_nac.Text = al.Dia_nac + "/" + al.Mes_nac + "/" + al.Anio_nac;
            sexo.Text = al.Sexo;
            profesion.Text = al.Profesion;
            grado.Text = al.Grado;
            lugar_nac.Text = al.Lug_nac;
            estatus.Text = al.Estatus;
            univ_proc.Text = al.Univ_proc;
        }

        private void codigo_Click(object sender, EventArgs e)
        {

        }

        public void tabla_Calif_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Insertar calificaciones a la tabla
        private void button1_Click(object sender, EventArgs e)
        {
            conexionBD aniadir = new conexionBD();
            aniadir.InsertarC(materia.Text, Convert.ToInt32(calificacion.Text), status.Text, Convert.ToInt32(codigo.Text));
            tabla_Calif.DataSource = conectar.calificaciones(Convert.ToInt32(codigo.Text));

        }
    }
}
