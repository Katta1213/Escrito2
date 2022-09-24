using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Capa_de_datos
{
    public abstract class Modelo
    {
        private string IpDataBase;
        private string UserDataBase;
        private string PasswordDataBase;
        private string NameDataBase;
        private string PortDataBase;

        public MySqlConnection Connection;
        public MySqlCommand Command;
        public MySqlDataReader DataReader;

        public Modelo()
        {
            loadConnectionParameters();
            connectionDataBase();
            initializeCommand();
            Console.Write(Connection.State);
        }

        private void loadConnectionParameters()
        {
            this.IpDataBase = "127.0.0.1";
            this.UserDataBase = "root";
            this.PasswordDataBase = "toor";
            this.NameDataBase = "escrito2";
            this.PortDataBase = "3306";
        }

        public void connectionDataBase()
        {
            this.Connection = new MySqlConnection(
                $"server ={this.IpDataBase};" +
                $"userid={this.UserDataBase};" +
                $"password={this.PasswordDataBase};" +
                $"database={this.NameDataBase};" +
                $"port={this.PortDataBase};" +
                $"Max Pool Size=500;"
            );
            this.Connection.Open();
        }
        public void initializeCommand()
        {
            this.Command = new MySqlCommand();
            this.Command.Connection = this.Connection;
        }
    }
}
