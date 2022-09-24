using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_datos;
using System.Data;

namespace Capa_Logica
{
    public class ControladorPersona
    {
        public static void Alta(string ci, string nombre, string apellido, string telefono)
        {
            PersonaModelo p = embedAttributes(ci, nombre, apellido, telefono);
            p.Save();
        }
        public static void Modificar(string ci, string nombre, string apellido, string telefono)
        {
            PersonaModelo p = embedAttributes(ci, nombre, apellido, telefono);
            p.Save();
        }
        
        private static PersonaModelo embedAttributes(string ci, string nombre, string apellido, string telefono)
        {
            PersonaModelo p = new PersonaModelo();
            p.Ci = ci;
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.Telefono = telefono;
            return p;
        }

        public static DataTable GetAll()
        {
            DataTable tablaDePersonas = createTable();

            PersonaModelo u = new PersonaModelo();
            List<PersonaModelo> todasLasPersonas = u.Get();

            fillTable(todasLasPersonas, tablaDePersonas);

            return tablaDePersonas;
        }

        public static DataTable GetSearch(string ci, string nombre, string apellido, string telefono)
        {
            DataTable queryTable = createTable();

            PersonaModelo p = embedAttributes(ci, nombre, apellido, telefono);

            List<PersonaModelo> PersonasLista = p.GetSearch();

            fillTable(PersonasLista, queryTable);

            return queryTable;
        }

        public static void Eliminar(string Ci)
        {
            PersonaModelo p = new PersonaModelo();
            p.Delete(Ci);
        }

        private static DataTable createTable()
        {
            DataTable tablePersonas = new DataTable();

            tablePersonas.Columns.Add("Ci", typeof(string));
            tablePersonas.Columns.Add("Nombre", typeof(string));
            tablePersonas.Columns.Add("Apellido", typeof(string));
            tablePersonas.Columns.Add("Telefono", typeof(string));

            return tablePersonas;
        }

        private static void fillTable(List<PersonaModelo> personasList, DataTable personasTable)
        {
            foreach (PersonaModelo u in personasList)
            {
                DataRow fila = personasTable.NewRow();
                fila["Ci"] = u.Ci;
                fila["Nombre"] = u.Nombre;
                fila["Apellido"] = u.Apellido;
                fila["Telefono"] = u.Telefono;
                personasTable.Rows.Add(fila);
            }
        }
    }
}
