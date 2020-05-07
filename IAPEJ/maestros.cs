using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAPEJ
{
    public class maestros
    {
        private string _name;
        private string _apellidos;
        private string _dia_nac;
        private string _mes_nac;
        private string _anio_nac;
        private string _profesion;
        private string _sexo;
        private string _lug_nac;

        public string Name { get => _name; set => _name = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Dia_nac { get => _dia_nac; set => _dia_nac = value; }
        public string Mes_nac { get => _mes_nac; set => _mes_nac = value; }
        public string Anio_nac { get => _anio_nac; set => _anio_nac = value; }
        public string Profesion { get => _profesion; set => _profesion = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Lug_nac { get => _lug_nac; set => _lug_nac = value; }
    }
}
