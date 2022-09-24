using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_datos;

namespace Capa_Logica
{
    public static class ControladorMarca
    {

        public static void ComprobarCiYRedirigir(string ci, string fechaNueva)
        {
            MarcaModelo m = new MarcaModelo(ci);
            string fechaSalida = m.FechaSalida;
            string fechaEntrada = m.FechaEntrada;

            if (fechaSalida == null)
            {
                ControladorMarca.LleanarSalida(fechaNueva, fechaEntrada, ci);
            }
            if (fechaSalida != null)
            {
                ControladorMarca.CreacionYentrada(ci, fechaNueva);
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
    }
}
