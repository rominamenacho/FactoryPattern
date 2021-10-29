using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConnectionMySQL : GenericConnection, IConnection
    {
     

        public ConnectionMySQL() :base() {
            Username = "root";
            Password = "123";
            Host = "localhost";
            Port = "3306";
        }
        void IConnection.Connect()
        {
            Console.WriteLine("Se conecto a MySQL ");
        }

        void IConnection.Disconnect()
        {
            Console.WriteLine("Se desconecto a MySQL");
        }
    }
}
