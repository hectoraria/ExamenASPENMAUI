using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsCandidato
    {

        #region Propiedades
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }
        public String Pais { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNac { get; set; }
        public double PrecioMedio { get; set; }
        #endregion

        #region Constructores

       public clsCandidato() { }
       public clsCandidato(int id, string nombre, string apellidos, string direccion,string pais, String telefono, DateTime fechaNac, double precioMedio)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Pais = pais;
            Telefono = telefono;
            FechaNac = fechaNac;
            PrecioMedio = precioMedio;
        }


        #endregion
    }
}
