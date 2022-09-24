using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_datos
{
    public class MarcaModelo : Modelo
    {
        public string Ci { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }

        public MarcaModelo(string ci)
        {
            GetLastest(ci);
        }
        public MarcaModelo()
        {
        }

        public void Insertar()
        {
            this.Command.CommandText = "INSERT INTO marca (CiPersona, FechaHoraEntrada) " +
                "VALUES (STR_TO_DATE(@FechaHoraEntrada, '%d-%m-%Y %H:%i:%s'), FechaHoraEntrada);";
            this.Command.Parameters.AddWithValue("@CiPersona", this.Ci);
            this.Command.Parameters.AddWithValue("@FechaHoraEntrada", this.FechaEntrada);
            this.Command.Prepare();

            this.Command.ExecuteNonQuery();
        }

        public void CompletarSalida()
        {
            this.Command.CommandText = "UPDATE marca SET " +
                "FechaHoraSalida = STR_TO_DATE(@FechaHoraSalida, '%d-%m-%Y %H:%i:%s')" +
                "WHERE CiPersona = @CiPersona AND FechaHoraEntrada = STR_TO_DATE(@FechaHoraEntrada, '%d-%m-%Y %H:%i:%s');";
            this.Command.Parameters.AddWithValue("@CiPersona", this.Ci);
            this.Command.Parameters.AddWithValue("@FechaHoraEntrada", this.FechaEntrada);
            this.Command.Parameters.AddWithValue("@FechaHorasalida", this.FechaSalida);
            this.Command.Prepare();

            this.Command.ExecuteNonQuery();
        }

        public void GetLastest(string Ci)
        {
            this.Command.CommandText = "SELECT * FROM marca WHERE CiPersona = @Ci " +
                "ORDER BY FechaHoraEntrada DESC " +
                "LIMIT 1;";
            this.Command.Parameters.AddWithValue("@Ci", this.Ci);
            this.Command.Prepare();

            this.DataReader = this.Command.ExecuteReader();

            if (this.DataReader.Read())
            {
                this.FechaEntrada = this.DataReader["FechaHoraEntrada"].ToString();
                this.FechaSalida = this.DataReader["FechaHoraSalida"].ToString();
            }
        }
    }
}
