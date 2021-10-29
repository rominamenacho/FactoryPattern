using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConnectionOracle : GenericConnection, IConnection
    {
      
        public ConnectionOracle():base()
        {
            Username = "root";
            Password = "123";
            Host = "localhost";
            Port = "1521";
        }
        void IConnection.Connect()
        {
            Console.WriteLine("Se conecto a Oracle");
        }

        void IConnection.Disconnect()
        {
            Console.WriteLine("Se desconecto a Oracle");
        }
    }
}
