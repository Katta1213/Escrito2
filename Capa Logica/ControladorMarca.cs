using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_datos;
using System.Data;

namespace Capa_Logica
{
    public static class ControladorMarca
    {
        public static void ComprobarCiYRedirigir(string ci, string fechaNueva)
        {
            MarcaModelo m = new MarcaModelo(ci);
            string fechaSalida = m.FechaSalida;
            string fechaEntrada = m.FechaEntrada;
            Console.Write(fechaSalida);

            if(fechaEntrada == "")
            {
                ControladorMarca.CreacionYentrada(ci, fechaNueva);
            }
            else
            {
                if (fechaSalida == "")
                {
                    ControladorMarca.LleanarSalida(fechaNueva, fechaEntrada, ci);
                }
                if (fechaSalida != "")
                {
                    ControladorMarca.CreacionYentrada(ci, fechaNueva);
                }
            }
            
        }

        public static void CreacionYentrada(string ci, string fechaEntrada)
        {
            MarcaModelo m = new MarcaModelo();
            m.Ci = ci;
            m.FechaEntrada = fechaEntrada;
            m.Insertar();
        }

        public static void LleanarSalida(string fechaSalida, string fechaEntrada, string ci)
        {
            MarcaModelo m = new MarcaModelo();
            m.Ci = ci;
            m.FechaEntrada = fechaEntrada;
            m.FechaSalida = fechaSalida;
            m.CompletarSalida();
        }

        public static DataTable ObtenerPorCi(String ci)
        {
            MarcaModelo m = new MarcaModelo();
            List<MarcaModelo> lista = m.GetWithCi(ci);

            DataTable tablaDeMarcas = new DataTable();
            tablaDeMarcas.Columns.Add("Entrada", typeof(DateTime));
            tablaDeMarcas.Columns.Add("Salida", typeof(DateTime));

            foreach (MarcaModelo mm in lista)
            {
                DataRow fila = tablaDeMarcas.NewRow();
                fila["Entrada"] = mm.FechaEntrada;
                fila["Salida"] = mm.FechaSalida;
                tablaDeMarcas.Rows.Add(fila);
            }

            return tablaDeMarcas;
        }
    }
}
