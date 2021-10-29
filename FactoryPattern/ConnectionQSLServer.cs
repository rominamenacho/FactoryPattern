using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConnectionQSLServer : GenericConnection, IConnection
    {
       
        public ConnectionQSLServer():base()
        {
            Username = "root";
            Password = "123";
            Host = "localhost";
            Port = "1433";
        }
        void IConnection.Connect()
        {
            Console.WriteLine("Se conecto a SQL Server");
        }

        void IConnection.Disconnect()
        {
            Console.WriteLine("Se desconecto a SQL Server");
        }
    }
}
