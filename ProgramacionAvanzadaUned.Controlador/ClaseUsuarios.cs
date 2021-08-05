using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionAvanzadaUned.Controlador;

namespace ProgramacionAvanzadaUned.Controlador
{
    public class ClaseUsuarios
    {

        public int opcion { get; set; }
        public string NombreUsuario { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int cedula { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }

        public ClaseUsuarios(int opcion, string usuario, string clave, string NombreUsuario, string Apellidos, int Telefono, DateTime fechaNacimiento, int cedula)
        {
            opcion = 0;
            usuario = "";
            clave = "";
            NombreUsuario = "";
            Apellidos = "";
            Telefono = 0;
            fechaNacimiento = DateTime.Today;
            cedula = 0;
        }

        public ClaseUsuarios()
        {
            opcion = opcion;
            usuario = usuario;
            clave = clave;
            NombreUsuario = NombreUsuario;
            Apellidos = Apellidos;
            Telefono = Telefono;
            fechaNacimiento = fechaNacimiento;
            cedula = cedula;
        }
    }
}