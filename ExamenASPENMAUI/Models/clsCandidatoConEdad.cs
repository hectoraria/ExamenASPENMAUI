using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenASPENMAUI.Models
{
    public class clsCandidatoConEdad : clsCandidato
    {
        private int edad;

        public int Edad
        {
            get { return edad; }
        }

        public clsCandidatoConEdad(clsCandidato candidato) 
        { 
            this.Id = candidato.Id; 
            this.Nombre = candidato.Nombre;
            this.Apellidos = candidato.Apellidos;
            this.Direccion = candidato.Direccion;
            this.Pais = candidato.Pais;
            this.Telefono = candidato.Telefono;
            this.FechaNac= candidato.FechaNac;
            this.PrecioMedio = candidato.PrecioMedio;
            getEdad();

        }


        private void getEdad() 
        { 
            this.edad = DateTime.Now.Year - this.FechaNac.Year;
        }


    }
}
