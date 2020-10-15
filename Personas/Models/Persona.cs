using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personas
{
    public class Persona
    {
        public tipoPersona tipo { get; set; } 
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public string email { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public int dni { get; set; }


        public void MostrarNombre(string nombre, string apellido)
        {
            string saludoPresentacion = "El nombre del objeto persona es " + nombre + apellido + ". Saludos";
            Console.WriteLine(saludoPresentacion);
        }

        public void MostrarPersona(Persona persona)
        {
            string infoPersona = $"La persona de nombre {persona.nombre} {persona.apellido} tiene {persona.edad} años. Su mail es {persona.email}, vive en {persona.ciudad} {persona.direccion}.";
            Console.WriteLine(infoPersona);
        }
        public void BuscarPersonaNombre(string nombre)
        {
            //busco por nombre
        }

    }



    public enum tipoPersona
    {
        bebe= 0,
        niño= 1,
        adolecente= 2,
        audlto= 3,
        anciano= 4,
    }
}
