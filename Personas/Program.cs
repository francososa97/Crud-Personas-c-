using Personas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Personas = new List<Persona>();
            List<Cliente> Clientes = new List<Cliente>();
            var persona1 = new Persona
            {
                nombre = "juan",
                apellido = "perez",
                edad = 20,
                email = "juan.perez@gmail",
                ciudad = "Padua",
                direccion = "Calle falsa 123",
                dni = 00000001,
                tipo = tipoPersona.bebe,
            };
            var persona2 = new Persona
            {
                nombre = "juan",
                apellido = "perez",
                edad = 48,
                email = "juan.perez@gmail",
                ciudad = "Padua",
                direccion = "Calle falsa 123",
                dni = 00000001,
                tipo = tipoPersona.bebe,
    };
            var persona3 = new Persona
            {
                nombre = "juan",
                apellido = "perez",
                edad = 90,
                email = "juan.perez@gmail",
                ciudad = "Padua",
                direccion = "Calle falsa 123",
                dni = 00000001,
                tipo = tipoPersona.adolecente,
};
            Personas.Add(persona1);
            Personas.Add(persona2);
            Personas.Add(persona3);

            /*
            List<Persona> PersonaNull = new List<Persona>();


            foreach (var persona in Personas)
            {
                PersonaNull.Add(persona);
            }
            Console.WriteLine(PersonaNull);

            foreach (var item in PersonaNull)
            {
                Console.WriteLine(item.nombre);
                Console.WriteLine(item.tipo);
            }
            */

            foreach (var persona in Personas)
            {
                Cliente cliente = new Cliente
                {
                    nombre=persona.nombre,
                    direccion=persona.direccion,
                    telefono="00000000",
                    fecNac=new DateTime(2000,1,1),
                };
                Clientes.Add(cliente);
            }
             


            Console.WriteLine("Bienvenido al Crud de personas por favor ingrese que operacion quiere hacer");

            Console.WriteLine("C - Crear");
            Console.WriteLine("E - Eliminar");
            Console.WriteLine("M - Modificar");
            Console.WriteLine("B - Buscar por todo");
            Console.WriteLine("BE - Buscar especifica");
            Console.WriteLine("O - Ordenar");
            Console.WriteLine("O - Ordenar Especifica");

            var operacionElegida =Console.ReadLine();
            switch (operacionElegida.ToLower())
            {
                case "c":
                    bool operacionCorrecta = CrearPersona();
                    break;
                case "e":
                    break;
                case "m":
                    //proximamente
                    break;
                case "b":
                    Console.WriteLine("Ingrese el documento de la persona que quiera buscar");
                    int dni = Int32.Parse(Console.ReadLine());
                    BuscarPersona(dni);
                    //proximamente
                    break;
                case "be":
                    //proximamente
                    break;
                case "o":
                    //proximamente
                    break;
                case "oe":
                    //proximamente
                    //Persona personaBebe= new Persona();
                    var personaBebe = Personas.Where(x => x.tipo == tipoPersona.bebe).ToList();

                    break;





            }


            persona1.MostrarNombre(persona1.nombre, persona1.apellido);

            persona1.MostrarPersona(persona1);
            MostrarListadoPersonas(Personas);
            var personaMayor= Personas.OrderByDescending(x => x.edad).First();
            Console.WriteLine($"la persona mayor es: {personaMayor.nombre} + {personaMayor.apellido} con {personaMayor.edad}");
        }


        public static void MostrarListadoPersonas(List<Persona> personas)
        {
            Console.WriteLine("Listado de Personas Registradas");
            int i = 1;
            int CantidadPersonas = personas.Count();
            Console.WriteLine($"En la lista de personas tenemos {CantidadPersonas} registros de personas");
            personas.ForEach(persona =>
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Persona numero {i}");
                persona.MostrarPersona(persona);
                Console.WriteLine("--------------------------------------");
                i++;
            });
        }

        public static bool CrearPersona()
        {
            bool interaccionExitosa = false;
            var nuevaPersona = new Persona();
            Console.WriteLine("Usted eligio crear una persona");

            Console.WriteLine("ingrese el nombre: ");
            nuevaPersona.nombre = Console.ReadLine();

            Console.WriteLine("ingrese el apellido: ");
            nuevaPersona.apellido = Console.ReadLine();

            Console.WriteLine("ingrese la edad: ");
            nuevaPersona.edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el email: ");
            nuevaPersona.email = Console.ReadLine();

            Console.WriteLine("ingrese la ciudad: ");
            nuevaPersona.ciudad = Console.ReadLine();

            Console.WriteLine("ingrese la direccion: ");
            nuevaPersona.direccion = Console.ReadLine();

            Console.WriteLine("ingrese su numero de documento: ");
            nuevaPersona.dni = Int32.Parse(Console.ReadLine());

            try
            {
                //llamado ala bd
                Console.WriteLine(nuevaPersona);
                interaccionExitosa = true;
                nuevaPersona.MostrarPersona(nuevaPersona);
            }
            catch (Exception)
            {
                interaccionExitosa = false;
                throw;
            }
            return interaccionExitosa;
        }

        public static bool EliminarPersona()
        {
            return false;
        }
        public static void BuscarPersona( int caracterSolicitado)
        {

           
        }
    }
}
