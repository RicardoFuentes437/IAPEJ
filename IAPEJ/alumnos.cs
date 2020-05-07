using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAPEJ
{
    public class alumnos
    {
        private int _code;
        private string _name;
        private string _apellidos;
        private string _dia_nac;
        private string _mes_nac;
        private string _anio_nac;
        private string _profesion;
        private string _sexo;
        private string _grado;
        private string _univ_proc;
        private string _lug_nac;
        private string _estatus;

        public int Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Dia_nac { get => _dia_nac; set => _dia_nac = value; }
        public string Mes_nac { get => _mes_nac; set => _mes_nac = value; }
        public string Anio_nac { get => _anio_nac; set => _anio_nac = value; }
        public string Profesion { get => _profesion; set => _profesion = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Grado { get => _grado; set => _grado = value; }
        public string Univ_proc { get => _univ_proc; set => _univ_proc = value; }
        public string Lug_nac { get => _lug_nac; set => _lug_nac = value; }
        public string Estatus { get => _estatus; set => _estatus = value; }
    }
}
