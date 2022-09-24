using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_datos
{
    public class PersonaModelo : Modelo
    {
        public string Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
    
        public PersonaModelo(string identifier)
        {
            this.Get(identifier);
        }
        public PersonaModelo()
        {
        }

        public void Save()
        {
            if (this.Ci == "") Insert();
            else Update();
        }
        private void Insert()
        {
            this.Command.CommandText = "INSERT INTO persona (Nombre, Apellido, Telefono) VALUES (" +
                "@Nombre, " +
                "@Apellido, " +
                "@Telefono);";
            
            this.Command.Parameters.AddWithValue("@Nombre", this.Nombre);
            this.Command.Parameters.AddWithValue("@Apellido", this.Apellido);
            this.Command.Parameters.AddWithValue("@Telefono", this.Telefono);

            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
        }

        private void Update()
        {
                this.Command.CommandText = "UPDATE persona SET " +
                    "Nombre = @Nombre," +
                    "Apellido = @Apellido," +
                    "Telefono = @Telefono " +
                    "WHERE Ci = @Ci";

            this.Command.Parameters.AddWithValue("@Ci", this.Ci);
            this.Command.Parameters.AddWithValue("@Nombre", this.Nombre);
            this.Command.Parameters.AddWithValue("@Apellido", this.Apellido);
            this.Command.Parameters.AddWithValue("@Telefono", this.Telefono);

            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
        }

        public List<PersonaModelo> Get()
        {
            List<PersonaModelo> todasLasPersonas = new List<PersonaModelo>();
            this.Command.CommandText = "SELECT * from persona";
            this.DataReader = Command.ExecuteReader();

            while (this.DataReader.Read())
            {
                PersonaModelo p = new PersonaModelo(this.DataReader["Ci"].ToString());
                todasLasPersonas.Add(p);
            }
            return todasLasPersonas;

        }
        public void Get(string identifier)
        {
            this.Command.CommandText = "select * from persona where Ci = @CI";
            this.Command.Parameters.AddWithValue("@Ci", identifier);
            this.Command.Prepare();

            this.DataReader = this.Command.ExecuteReader();

            if (this.DataReader.Read())
            {
                this.Ci = this.DataReader["Ci"].ToString();
                this.Nombre = this.DataReader["Nombre"].ToString();
                this.Apellido = this.DataReader["Apellido"].ToString();
                this.Telefono = this.DataReader["Telefono"].ToString();

            }
        }

        public List<PersonaModelo> GetSearch()
        {
            List<PersonaModelo> lista = new List<PersonaModelo>();

            this.Command.CommandText = "SELECT * FROM persona WHERE " + where();
            DataReader = Command.ExecuteReader();

            while (this.DataReader.Read())
            {
                PersonaModelo p = new PersonaModelo(this.DataReader["Ci"].ToString());
                lista.Add(p);
            }

            return lista;
        }

        private string where()
        {
            string where = "";

            if (this.Ci != "") where = concatenateQuerty(where) + $"Ci = {this.Ci}";
            if (this.Nombre != "") where = concatenateQuerty(where) + $"Nombre = '{this.Nombre}'";
            if (this.Apellido != "") where = concatenateQuerty(where) + $"Apellido = '{this.Apellido}'";
            if (this.Telefono != "") where = concatenateQuerty(where) + $"Telefono = {this.Telefono}";

            return where;
        }

        private string concatenateQuerty(string query)
        {
            string newQuery;
            if (query == "")
                newQuery = "";
            else
                newQuery = query + " AND ";
            return newQuery;
        }

        public void Delete(string identifier)
        {
            this.Command.CommandText = "DELETE FROM persona WHERE Ci = @Ci";
            this.Command.Parameters.AddWithValue("@Ci", identifier);
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
        }
    }
}
