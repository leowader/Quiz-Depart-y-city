using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioCity
    {
        List<Ciudad>lista=new List<Ciudad>();
        public ServicioCity()
        {
            Lista = new List<Ciudad>();
        }
        Datos.RepositorioCity datos=new Datos.RepositorioCity();

        public List<Ciudad> Lista { get => lista; set => lista = value; }
        public RepositorioCity Datos { get => datos; set => datos = value; }

        public string Agregar(Ciudad ciudad)
        {
            foreach (var item in Datos.leer())
            {
                if (ciudad.NombreCiudad.Equals(item.NombreCiudad))
                {
                    return $"la ciudad {ciudad.NombreCiudad} ya existe";
                }
                
            }
            Lista.Add(ciudad);
            var estado = Datos.Guardar(ciudad);
            return estado ? $"ciudad guardada con Nombre: {ciudad.NombreCiudad}" : $"Error al guardar la ciudad: {ciudad.NombreCiudad}";
        }
        public List<Ciudad> Mostrar()
        {
            try
            {
                Lista = Datos.leer();
            }
            catch (StackOverflowException Se)
            {
                Console.WriteLine(Se.Message);
            }
            catch (System.FormatException Fe)
            {

                Console.WriteLine(Fe.Message);

            }
            catch (FileNotFoundException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            
            return Lista;
        }
        public string Elimiar(string nombre)
        {
            try
            {
                var estado = Datos.Eliminar(nombre);
                return estado ? $"La ciudad:{nombre} ha sido eliminado" : $"la ciudad:{nombre} No ha sido eliminado";
            }
            catch (FormatException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            return null;
        }
    }
}
