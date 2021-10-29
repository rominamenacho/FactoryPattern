using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConnectionPostgreSQL : GenericConnection, IConnection
    {
      

        public ConnectionPostgreSQL():base()
        {
            Username = "root";
            Password = "123";
            Host = "localhost";
            Port = "5433";
        }
        void IConnection.Connect()
        {
            Console.WriteLine("Se conecto a PostgreSQL");
        }

        void IConnection.Disconnect()
        {
            Console.WriteLine("Se desconecto a PostgreSQL ");
        }
    }
    
}
