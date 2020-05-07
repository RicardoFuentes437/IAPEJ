using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace IAPEJ
{
    class conexionBD
    {
        //Conexion con la base de datos
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = proyectoiapej; Database = IAPEJ");

        //conectar
        public void conectar()
        {
            conn.Open();
        }

        //desconectar
        public void desconectar()
        {
            conn.Close();
        }

        //consultar alumno
        public alumnos ConsultarA(string consulta)
        {
            string query = consulta;
            alumnos alumno = new alumnos();
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader datos = conector.ExecuteReader();
            while (datos.Read())
            {
                alumno.Code = Convert.ToInt32(datos[0]);
                alumno.Name = Convert.ToString(datos[1]);
                alumno.Apellidos = Convert.ToString(datos[2]);
                alumno.Dia_nac = Convert.ToString(datos[3]);
                alumno.Mes_nac = Convert.ToString(datos[4]);
                alumno.Anio_nac = Convert.ToString(datos[5]);
                alumno.Profesion = Convert.ToString(datos[6]);
                alumno.Sexo = Convert.ToString(datos[7]);
                alumno.Grado = Convert.ToString(datos[8]);
                alumno.Univ_proc = Convert.ToString(datos[9]);
                alumno.Lug_nac = Convert.ToString(datos[10]);
                alumno.Estatus = Convert.ToString(datos[11]);

            }
            return alumno;
        }

        //consulta principal
        public alumnos Consultar(string opcion, string dato, string dato2 = null)
        {
            string op = opcion, data = dato, data2 = dato2;
            alumnos alumno = new alumnos();
            conectar();
            string consulta;
            if (op == "Código de Estudiante")
            {
                consulta = "SELECT * FROM \"alumnos\" where \"codigo\" = '" + data + "'";
            }
            else
            {
                consulta = "SELECT * FROM \"alumnos\" where \"nombre\" = '" + data + "' AND \"apellidos\" = '" + data2 + "'";
            }
            alumno = ConsultarA(consulta);
            desconectar();
            return alumno;
        }

        //consultar maestros
        public maestros ConsultarM(string nombre, string apellidos)
        {
            conectar();
            string dato = nombre, dato2 = apellidos;
            string query = "SELECT * FROM \"maestros\" where \"nombre\" = '" + dato + "' AND \"apellidos\" = '" + dato2 + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader datos = conector.ExecuteReader();
            maestros maestro = new maestros();
            while (datos.Read())
            {
                maestro.Name = Convert.ToString(datos[0]);
                maestro.Apellidos = Convert.ToString(datos[1]);
                maestro.Dia_nac = Convert.ToString(datos[2]);
                maestro.Mes_nac = Convert.ToString(datos[3]);
                maestro.Anio_nac = Convert.ToString(datos[4]);
                maestro.Profesion = Convert.ToString(datos[5]);
                maestro.Sexo = Convert.ToString(datos[6]);
                maestro.Lug_nac = Convert.ToString(datos[7]);
            }
            desconectar();
            return maestro;
        }

        //insertar alumnos en la BD
        public void Insertar(int cod, string nom, string ape, string dia, string mes, string anio, string profesion, string sexo, string grado, string uni, string lugar, string estatus)
        {
            conectar();
            string query = "INSERT INTO \"alumnos\" VALUES (" + cod + ", '" + nom + "', '" + ape + "','" + dia + "', '" + mes + "', '" + anio + "', '" + profesion + "', '" + sexo + "', '" + 
                grado + "', '" + uni + "', '" + lugar + "', '" + estatus + "')";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            desconectar();
            
        }

        //insertar maestros en la BD
        public void InsertarM( string nom, string ape, string dia, string mes, string anio, string profesion, string sexo, string lugar)
        {
            conectar();
            string query = "INSERT INTO \"maestros\" VALUES ('" + nom + "', '" + ape + "','" + dia + "', '" + mes + "', '" + anio + "', '" + profesion + "', '" + sexo + "', '" + lugar + "')";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            desconectar();

        }

        //insertar calificaciones en la BD
        public void InsertarC(string materia, int calificacion, string estatus, int id)
        {
            conectar();
            string query = "INSERT INTO \"calificaciones\" VALUES ('" + materia + "', " + calificacion + ",'" + estatus + "', " + id + ")";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            desconectar();

        }

        //llenar tabla con calificaciones
        public DataTable calificaciones(int id)
        {
            string query = "SELECT \"materia\", \"calificacion\", \"estatus\" FROM \"calificaciones\" WHERE \"id_alumno\" = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


    }
}
