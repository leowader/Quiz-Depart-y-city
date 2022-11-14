using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCity:Archivos
    {
        public RepositorioCity()
        {
            ruta = "Ciudades.txt";
        }
        public bool Guardar(Entidades.Ciudad ciudad)
        {
            try
            {
                StreamWriter sr = new StreamWriter(ruta, true);
                sr.WriteLine(ciudad.ToString());
                sr.Close();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }
        public Ciudad Mapear(string linea)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.NombreCiudad = linea.Trim();
            return ciudad;
        }
        public List<Ciudad> leer()
        {
            StreamReader streamReader=new StreamReader(ruta);
            List<Ciudad> listaCity = new List<Ciudad>();
            while (!streamReader.EndOfStream)
            {
                listaCity.Add(Mapear(streamReader.ReadLine()));

            }
            streamReader.Close();
            return listaCity;
        }
        public bool Eliminar(string Nombre)
        {
            StreamReader lectura;
            StreamWriter escribir;
            bool encontrado = false;
            string cadena;
            lectura = File.OpenText(ruta);
            escribir = File.CreateText("tmp.txt");
            cadena = lectura.ReadLine();
            string[] campos = new string[1];
            char[] separador = { ';' };
            while (cadena != null)
            {
                campos = cadena.Split(separador);
                if (campos[0].Trim().Equals(Nombre))
                {
                    encontrado = true;
                }
                else
                {
                    escribir.WriteLine(cadena);
                }
                cadena = lectura.ReadLine();
            }
            if (encontrado == false)
            {

                return false;
            }
            lectura.Close();
            escribir.Close();
            File.Delete(ruta);
            File.Move("tmp.txt", ruta);
            return true;
        }
    }
}
