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
    public partial class mostrarMaestro : Form
    {
        public mostrarMaestro()
        {
            InitializeComponent();
        }

        //Fecha y Hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        //Mostrar datos del maestro
        public void Datos(maestros maestro)
        {
            maestros ma = new maestros();
            ma = maestro;
            nombre.Text = ma.Name + " " + ma.Apellidos;
            fecha_nac.Text = ma.Dia_nac + "/" + ma.Mes_nac + "/" + ma.Anio_nac;
            sexo.Text = ma.Sexo;
            profesion.Text = ma.Profesion;
            lugar_nac.Text = ma.Lug_nac;
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
