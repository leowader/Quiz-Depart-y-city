using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioDepartamento
    {
        List<Departamentos> lista = new List<Departamentos>();
        public ServicioDepartamento()
        {
            Lista = new List<Departamentos>();
        }
        Datos.RepositorioDepartamento datos = new Datos.RepositorioDepartamento();

        public List<Departamentos> Lista { get => lista; set => lista = value; }
        public RepositorioDepartamento Datos { get => datos; set => datos = value; }

        public string Agregar(Departamentos departamento)
        {
            foreach (var item in Datos.leer())
            {
                if (departamento.NombreDepartamento.Equals(item.NombreDepartamento))
                {
                    return $"el departamento {departamento.NombreDepartamento} ya existe";
                }

            }
            Lista.Add(departamento);
            var estado = Datos.Guardar(departamento);
            return estado ? $"departamento guardada con Nombre: {departamento.NombreDepartamento}" : $"Error al guardar el departamento: {departamento.NombreDepartamento}";
        }
        public List<Departamentos> Mostrar()
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
                return estado ? $"El departamento:{nombre} ha sido eliminado" : $"el departamento:{nombre} No ha sido eliminado";
            }
            catch (FormatException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            return null;
        }

    }
}
